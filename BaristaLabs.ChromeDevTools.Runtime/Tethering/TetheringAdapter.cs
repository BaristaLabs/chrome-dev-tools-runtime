namespace BaristaLabs.ChromeDevTools.Runtime.Tethering
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Tethering domain to simplify the command interface.
    /// </summary>
    public class TetheringAdapter
    {
        private readonly ChromeSession m_session;
        
        public TetheringAdapter(ChromeSession session)
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
        /// Request browser port binding.
        /// </summary>
        public async Task<BindCommandResponse> Bind(BindCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<BindCommand, BindCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Request browser port unbinding.
        /// </summary>
        public async Task<UnbindCommandResponse> Unbind(UnbindCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<UnbindCommand, UnbindCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    

    
        /// <summary>
        /// Informs that port was successfully bound and got a specified connection id.
        /// </summary>
        public void SubscribeToAcceptedEvent(Action<AcceptedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
    }
}