namespace BaristaLabs.ChromeDevTools.Runtime.Log
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Log domain to simplify the command interface.
    /// </summary>
    public class LogAdapter
    {
        private readonly ChromeSession m_session;
        
        public LogAdapter(ChromeSession session)
        {
            m_session = session ?? throw new ArgumentNullException(nameof(session));
        }

    
        /// <summary>
        /// Enables log domain, sends the entries collected so far to the client by means of the <code>entryAdded</code> notification.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command);
        }
    
        /// <summary>
        /// Disables log domain, prevents further log entries from being reported to the client.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command);
        }
    
        /// <summary>
        /// Clears the log.
        /// </summary>
        public async Task<ClearCommandResponse> Clear(ClearCommand command)
        {
            return await m_session.SendCommand<ClearCommand, ClearCommandResponse>(command);
        }
    
        /// <summary>
        /// start violation reporting.
        /// </summary>
        public async Task<StartViolationsReportCommandResponse> StartViolationsReport(StartViolationsReportCommand command)
        {
            return await m_session.SendCommand<StartViolationsReportCommand, StartViolationsReportCommandResponse>(command);
        }
    
        /// <summary>
        /// Stop violation reporting.
        /// </summary>
        public async Task<StopViolationsReportCommandResponse> StopViolationsReport(StopViolationsReportCommand command)
        {
            return await m_session.SendCommand<StopViolationsReportCommand, StopViolationsReportCommandResponse>(command);
        }
    

    
        /// <summary>
        /// Issued when new message was logged.
        /// </summary>
        public void SubscribeToEntryAddedEvent(Action<EntryAddedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
    }
}