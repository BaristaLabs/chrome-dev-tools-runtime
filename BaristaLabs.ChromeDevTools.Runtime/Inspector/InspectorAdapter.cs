namespace BaristaLabs.ChromeDevTools.Runtime.Inspector
{
    using System;
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
        /// Enables inspector domain notifications.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command);
        }
    
        /// <summary>
        /// Disables inspector domain notifications.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command);
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