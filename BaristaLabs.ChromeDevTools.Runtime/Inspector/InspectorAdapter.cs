namespace BaristaLabs.ChromeDevTools.Runtime.Inspector
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Inspector domain to simplify the command interface.
    /// </summary>
    public class InspectorAdapter
    {
        private readonly ChromeSession m_session;
        
        public InspectorAdapter(ChromeSession session)
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
        /// Enables inspector domain notifications.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Disables inspector domain notifications.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    

    
        /// <summary>
        /// Fired when remote debugging connection is about to be terminated. Contains detach reason.
        /// </summary>
        public void SubscribeToDetachedEvent(Action<DetachedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Fired when debugging target has crashed
        /// </summary>
        public void SubscribeToTargetCrashedEvent(Action<TargetCrashedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
    }
}