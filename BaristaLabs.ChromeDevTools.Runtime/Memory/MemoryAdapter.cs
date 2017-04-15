namespace BaristaLabs.ChromeDevTools.Runtime.Memory
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Memory domain to simplify the command interface.
    /// </summary>
    public class MemoryAdapter
    {
        private readonly ChromeSession m_session;
        
        public MemoryAdapter(ChromeSession session)
        {
            m_session = session ?? throw new ArgumentNullException(nameof(session));
        }

    
        /// <summary>
        /// 
        /// </summary>
        public async Task<GetDOMCountersCommandResponse> GetDOMCounters(GetDOMCountersCommand command)
        {
            return await m_session.SendCommand<GetDOMCountersCommand, GetDOMCountersCommandResponse>(command);
        }
    
        /// <summary>
        /// Enable/disable suppressing memory pressure notifications in all processes.
        /// </summary>
        public async Task<SetPressureNotificationsSuppressedCommandResponse> SetPressureNotificationsSuppressed(SetPressureNotificationsSuppressedCommand command)
        {
            return await m_session.SendCommand<SetPressureNotificationsSuppressedCommand, SetPressureNotificationsSuppressedCommandResponse>(command);
        }
    
        /// <summary>
        /// Simulate a memory pressure notification in all processes.
        /// </summary>
        public async Task<SimulatePressureNotificationCommandResponse> SimulatePressureNotification(SimulatePressureNotificationCommand command)
        {
            return await m_session.SendCommand<SimulatePressureNotificationCommand, SimulatePressureNotificationCommandResponse>(command);
        }
    
    }
}