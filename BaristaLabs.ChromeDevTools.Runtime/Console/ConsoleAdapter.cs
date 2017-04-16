namespace BaristaLabs.ChromeDevTools.Runtime.Console
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Console domain to simplify the command interface.
    /// </summary>
    public class ConsoleAdapter
    {
        private readonly ChromeSession m_session;
        
        public ConsoleAdapter(ChromeSession session)
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
        /// Enables console domain, sends the messages collected so far to the client by means of the <code>messageAdded</code> notification.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command);
        }
    
        /// <summary>
        /// Disables console domain, prevents further console messages from being reported to the client.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command);
        }
    
        /// <summary>
        /// Does nothing.
        /// </summary>
        public async Task<ClearMessagesCommandResponse> ClearMessages(ClearMessagesCommand command)
        {
            return await m_session.SendCommand<ClearMessagesCommand, ClearMessagesCommandResponse>(command);
        }
    

    
        /// <summary>
        /// Issued when new console message is added.
        /// </summary>
        public void SubscribeToMessageAddedEvent(Action<MessageAddedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
    }
}