namespace BaristaLabs.ChromeDevTools
{
    using Newtonsoft.Json;
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using WebSocket4Net;

    /// <summary>
    /// Represents a websocket connection to a running chrome instance that can be used to send commands and recieve events.
    ///</summary>
    public sealed class ChromeSession
    {
        private readonly string m_endpointAddress;
        private ManualResetEvent m_openEvent = new ManualResetEvent(false);
        private ManualResetEvent m_messageReceived = new ManualResetEvent(false);

        public ChromeSession(string endpointAddress)
        {
            if (String.IsNullOrWhiteSpace(endpointAddress))
                throw new ArgumentNullException(nameof(endpointAddress));
            
            m_endpointAddress = endpointAddress;
        }

        public async Task<TCommandResponse> SendCommand<TCommand, TCommandResponse>(TCommand command, CancellationToken cancellationToken)
            where TCommand : ICommand<TCommandResponse>
            where TCommandResponse : ICommandResponse
        {
            if (command == null)
                throw new ArgumentNullException(nameof(command));

            var ws = new WebSocket(m_endpointAddress);

            var contents = JsonConvert.SerializeObject(new
            {
                id = 0,
                method = command.CommandName,
                @params = command
            });
            
            ws.EnableAutoSendPing = false;
            ws.MessageReceived += Ws_MessageReceived;
            ws.DataReceived += Ws_DataReceived;
            ws.Error += Ws_Error;
            ws.Opened += Ws_Opened;

            ws.Open();

            m_openEvent.WaitOne();

            ws.Send(contents);

            m_messageReceived.WaitOne();

            return JsonConvert.DeserializeObject<TCommandResponse>("");
        }

        private void Ws_Opened(object sender, EventArgs e)
        {
            m_openEvent.Set();
        }

        private void Ws_DataReceived(object sender, DataReceivedEventArgs e)
        {
            
        }

        private void Ws_Error(object sender, SuperSocket.ClientEngine.ErrorEventArgs e)
        {
            
        }

        private void Ws_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            m_messageReceived.Set();
        }
    }
}