namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Storage domain to simplify the command interface.
    /// </summary>
    public class StorageAdapter
    {
        private readonly ChromeSession m_session;
        
        public StorageAdapter(ChromeSession session)
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
        /// Clears storage for origin.
        /// </summary>
        public async Task<ClearDataForOriginCommandResponse> ClearDataForOrigin(ClearDataForOriginCommand command)
        {
            return await m_session.SendCommand<ClearDataForOriginCommand, ClearDataForOriginCommandResponse>(command);
        }
    

    
    }
}