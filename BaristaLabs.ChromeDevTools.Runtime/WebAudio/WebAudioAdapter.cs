namespace BaristaLabs.ChromeDevTools.Runtime.WebAudio
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the WebAudio domain to simplify the command interface.
    /// </summary>
    public class WebAudioAdapter
    {
        private readonly ChromeSession m_session;
        
        public WebAudioAdapter(ChromeSession session)
        {
            m_session = session ?? throw new ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Gets the ChromeSession associated with the adapter.
        /// </summary>
        public ChromeSession Session
        {
            get { return m_session; }
        }

        /// <summary>
        /// Enables the WebAudio domain and starts sending context lifetime events.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command ?? new EnableCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Disables the WebAudio domain.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command ?? new DisableCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Fetch the realtime data from the registered contexts.
        /// </summary>
        public async Task<GetRealtimeDataCommandResponse> GetRealtimeData(GetRealtimeDataCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetRealtimeDataCommand, GetRealtimeDataCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

        /// <summary>
        /// Notifies that a new BaseAudioContext has been created.
        /// </summary>
        public void SubscribeToContextCreatedEvent(Action<ContextCreatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Notifies that an existing BaseAudioContext will be destroyed.
        /// </summary>
        public void SubscribeToContextWillBeDestroyedEvent(Action<ContextWillBeDestroyedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Notifies that existing BaseAudioContext has changed some properties (id stays the same)..
        /// </summary>
        public void SubscribeToContextChangedEvent(Action<ContextChangedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Notifies that the construction of an AudioListener has finished.
        /// </summary>
        public void SubscribeToAudioListenerCreatedEvent(Action<AudioListenerCreatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Notifies that a new AudioListener has been created.
        /// </summary>
        public void SubscribeToAudioListenerWillBeDestroyedEvent(Action<AudioListenerWillBeDestroyedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Notifies that a new AudioNode has been created.
        /// </summary>
        public void SubscribeToAudioNodeCreatedEvent(Action<AudioNodeCreatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Notifies that an existing AudioNode has been destroyed.
        /// </summary>
        public void SubscribeToAudioNodeWillBeDestroyedEvent(Action<AudioNodeWillBeDestroyedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Notifies that a new AudioParam has been created.
        /// </summary>
        public void SubscribeToAudioParamCreatedEvent(Action<AudioParamCreatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Notifies that an existing AudioParam has been destroyed.
        /// </summary>
        public void SubscribeToAudioParamWillBeDestroyedEvent(Action<AudioParamWillBeDestroyedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Notifies that two AudioNodes are connected.
        /// </summary>
        public void SubscribeToNodesConnectedEvent(Action<NodesConnectedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Notifies that AudioNodes are disconnected. The destination can be null, and it means all the outgoing connections from the source are disconnected.
        /// </summary>
        public void SubscribeToNodesDisconnectedEvent(Action<NodesDisconnectedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Notifies that an AudioNode is connected to an AudioParam.
        /// </summary>
        public void SubscribeToNodeParamConnectedEvent(Action<NodeParamConnectedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Notifies that an AudioNode is disconnected to an AudioParam.
        /// </summary>
        public void SubscribeToNodeParamDisconnectedEvent(Action<NodeParamDisconnectedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    }
}