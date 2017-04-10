namespace BaristaLabs.ChromeDevTools.Runtime
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Concurrent;
    using System.Threading;
    using System.Threading.Tasks;
    using WebSocket4Net;

    /// <summary>
    /// Represents a websocket connection to a running chrome instance that can be used to send commands and recieve events.
    ///</summary>
    public sealed class ChromeSession : IDisposable
    {
        private readonly string m_endpointAddress;
        private readonly ConcurrentDictionary<string, ConcurrentBag<Action<object>>> m_eventHandlers = new ConcurrentDictionary<string, ConcurrentBag<Action<object>>>();
        private readonly ConcurrentDictionary<Type, string> m_eventTypeMap = new ConcurrentDictionary<Type, string>();

        private WebSocket m_sessionSocket;
        private ManualResetEventSlim m_openEvent = new ManualResetEventSlim(false);
        private ManualResetEventSlim m_responseReceived = new ManualResetEventSlim(false);
        public JToken m_lastResponseResult;
        private long m_currentCommandId = 0;

        public ChromeSession(string endpointAddress)
        {
            if (String.IsNullOrWhiteSpace(endpointAddress))
                throw new ArgumentNullException(nameof(endpointAddress));
            
            CommandTimeout = 5000;
            m_endpointAddress = endpointAddress;

            m_sessionSocket = new WebSocket(m_endpointAddress);
            m_sessionSocket.EnableAutoSendPing = false;
            m_sessionSocket.MessageReceived += Ws_MessageReceived;
            m_sessionSocket.Error += Ws_Error;
            m_sessionSocket.Opened += Ws_Opened;
        }

        /// <summary>
        /// Gets or sets the number of milliseconds to wait for a command to complete.
        /// </summary>
        public int CommandTimeout
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the endpoint address of the session.
        /// </summary>
        public string EndpointAddress
        {
            get { return m_endpointAddress; }
        }

        /// <summary>
        /// Sends the specified command and returns the associated command response.
        /// </summary>
        /// <typeparam name="TCommand"></typeparam>
        /// <param name="command"></param>
        /// <returns></returns>
        public async Task<ICommandResponse<TCommand>> SendCommand<TCommand>(TCommand command, bool throwExceptionIfResponseNotReceived = true)
            where TCommand : ICommand
        {
            return await SendCommand<TCommand>(command, CancellationToken.None, throwExceptionIfResponseNotReceived);
        }

        /// <summary>
        /// Sends the specified command and returns the associated command response.
        /// </summary>
        /// <typeparam name="TCommand"></typeparam>
        /// <param name="command"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<ICommandResponse<TCommand>> SendCommand<TCommand>(TCommand command, CancellationToken cancellationToken, bool throwExceptionIfResponseNotReceived = true)
            where TCommand : ICommand
        {
            if (command == null)
                throw new ArgumentNullException(nameof(command));

            var result = await SendCommandInternal(command, cancellationToken, throwExceptionIfResponseNotReceived);
            
            if (result == null)
                return null;

            if (!CommandResponseTypeMap.TryGetCommandResponseType<TCommand>(out Type commandResponseType))
                throw new InvalidOperationException($"Type {typeof(TCommand)} does not correspond to a known command response type.");

            return result.ToObject(commandResponseType) as ICommandResponse<TCommand>;
        }

        /// <summary>
        /// Sends the specified command and returns the associated command response.
        /// </summary>
        /// <typeparam name="TCommand"></typeparam>
        /// <param name="command"></param>
        /// <returns></returns>
        public async Task<TCommandResponse> SendCommand<TCommand, TCommandResponse>(TCommand command, bool throwExceptionIfResponseNotReceived = true)
            where TCommand : ICommand
            where TCommandResponse : ICommandResponse<TCommand>
        {
            return await SendCommand<TCommand, TCommandResponse>(command, CancellationToken.None, throwExceptionIfResponseNotReceived);
        }

        /// <summary>
        /// Sends the specified command and returns the associated command response.
        /// </summary>
        /// <typeparam name="TCommand"></typeparam
        /// <typeparam name="TCommandResponse"></typeparam>
        /// <param name="command"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<TCommandResponse> SendCommand<TCommand, TCommandResponse>(TCommand command, CancellationToken cancellationToken, bool throwExceptionIfResponseNotReceived = true)
            where TCommand : ICommand
            where TCommandResponse : ICommandResponse<TCommand>
        {
            if (command == null)
                throw new ArgumentNullException(nameof(command));

            var result = await SendCommandInternal(command, cancellationToken, throwExceptionIfResponseNotReceived);

            if (result == null)
                return default(TCommandResponse);

            return result.ToObject<TCommandResponse>();
        }

        private async Task<JToken> SendCommandInternal<TCommand>(TCommand command, CancellationToken cancellationToken, bool throwExceptionIfResponseNotReceived = true)
            where TCommand : ICommand
        {
            var contents = JsonConvert.SerializeObject(new
            {
                id = Interlocked.Increment(ref m_currentCommandId),
                method = command.CommandName,
                @params = command
            });

            await OpenSessionConnection();

            m_responseReceived.Reset();

            m_sessionSocket.Send(contents);

            var responseWasReceived = await Task.Run(() => m_responseReceived.Wait(CommandTimeout), cancellationToken);

            if (!responseWasReceived && throwExceptionIfResponseNotReceived)
                throw new InvalidOperationException($"A command response was not received: {command.CommandName}");

            return m_lastResponseResult;
        }

        /// <summary>
        /// Subscribes to the event associated with the given type.
        /// </summary>
        /// <typeparam name="TEvent">Event to subscribe to</typeparam>
        /// <param name="eventCallback"></param>
        public void Subscribe<TEvent>(Action<TEvent> eventCallback)
            where TEvent : IEvent
        {
            if (eventCallback == null)
                throw new ArgumentNullException(nameof(eventCallback));

            var eventName = m_eventTypeMap.GetOrAdd(
                typeof(TEvent),
                (type) =>
                {
                    if (!EventTypeMap.TryGetMethodNameForType<TEvent>(out string methodName))
                        throw new InvalidOperationException($"Type {typeof(TEvent)} does not correspond to a known event type.");

                    return methodName;
                });
            
            var callbackWrapper = new Action<object>(obj => eventCallback((TEvent)obj));
            m_eventHandlers.AddOrUpdate(eventName,
                (m) => new ConcurrentBag<Action<object>>(new[] { callbackWrapper }),
                (m, currentBag) =>
                {
                    currentBag.Add(callbackWrapper);
                    return currentBag;
                });
        }

        private async Task OpenSessionConnection()
        {
            if (m_sessionSocket.State != WebSocketState.Open)
            {
                m_sessionSocket.Open();

                await Task.Run(() => m_openEvent.Wait());
            }
        }

        private void RaiseEvent(string methodName, JToken eventData)
        {
            if (m_eventHandlers.TryGetValue(methodName, out ConcurrentBag<Action<Object>> bag))
            {
                if (!EventTypeMap.TryGetTypeForMethodName(methodName, out Type eventType))
                    throw new InvalidOperationException($"Unknown {methodName} does not correspond to a known event type.");

                var typedEventData = eventData.ToObject(eventType);
                foreach (var callback in bag)
                {
                    callback(typedEventData);
                }
            }
        }

        #region EventHandlers
        private void Ws_Opened(object sender, EventArgs e)
        {
            m_openEvent.Set();
        }

        private void Ws_Error(object sender, SuperSocket.ClientEngine.ErrorEventArgs e)
        {
            throw e.Exception;
        }

        private void Ws_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            var messageObject = JObject.Parse(e.Message);

            if (messageObject.TryGetValue("id", out JToken idProperty) && idProperty.Value<long>() == m_currentCommandId)
            {

                if (messageObject.TryGetValue("error", out JToken errorProperty ))
                {
                    var message = errorProperty.Value<string>("message");
                    var data = errorProperty.Value<string>("data");

                    var exceptionMessage = message;
                    if (!String.IsNullOrWhiteSpace(data))
                        exceptionMessage = $"{message} - {data}";

                    throw new CommandResponseException(exceptionMessage)
                    {
                        Code = errorProperty.Value<long>("code")
                    };
                }

                m_lastResponseResult = messageObject["result"];
                m_responseReceived.Set();
                return;
            }

            if (messageObject.TryGetValue("method", out JToken methodProperty))
            {
                var eventData = messageObject["params"];
                RaiseEvent(methodProperty.Value<string>(), eventData);
                return;
            }

        }
        #endregion

        #region IDisposable Support
        private bool m_isDisposed = false;

        private void Dispose(bool disposing)
        {
            if (!m_isDisposed)
            {
                if (disposing)
                {
                    if (m_sessionSocket != null)
                    {
                        m_sessionSocket.Dispose();
                        m_sessionSocket.Opened -= Ws_Opened;
                        m_sessionSocket.Error -= Ws_Error;
                        m_sessionSocket.MessageReceived -= Ws_MessageReceived;
                        m_sessionSocket = null;
                    }

                    if (m_openEvent != null)
                    {
                        m_openEvent.Dispose();
                        m_openEvent = null;
                    }

                    if (m_responseReceived != null)
                    {
                        m_responseReceived.Dispose();
                        m_responseReceived = null;
                    }
                }

                m_isDisposed = true;
            }
        }
        
        /// <summary>
        /// Disposes of the ChromeSession and frees all resources.
        ///</summary>
        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}