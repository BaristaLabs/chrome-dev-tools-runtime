namespace BaristaLabs.ChromeDevTools.Runtime.Database
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Database domain to simplify the command interface.
    /// </summary>
    public class DatabaseAdapter
    {
        private readonly ChromeSession m_session;
        
        public DatabaseAdapter(ChromeSession session)
        {
            m_session = session ?? throw new ArgumentNullException(nameof(session));
        }

    
        /// <summary>
        /// Enables database tracking, database events will now be delivered to the client.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command);
        }
    
        /// <summary>
        /// Disables database tracking, prevents database events from being sent to the client.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<GetDatabaseTableNamesCommandResponse> GetDatabaseTableNames(GetDatabaseTableNamesCommand command)
        {
            return await m_session.SendCommand<GetDatabaseTableNamesCommand, GetDatabaseTableNamesCommandResponse>(command);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<ExecuteSQLCommandResponse> ExecuteSQL(ExecuteSQLCommand command)
        {
            return await m_session.SendCommand<ExecuteSQLCommand, ExecuteSQLCommandResponse>(command);
        }
    
    }
}