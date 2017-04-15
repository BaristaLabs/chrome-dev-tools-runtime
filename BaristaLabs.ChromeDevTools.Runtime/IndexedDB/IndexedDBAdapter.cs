namespace BaristaLabs.ChromeDevTools.Runtime.IndexedDB
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the IndexedDB domain to simplify the command interface.
    /// </summary>
    public class IndexedDBAdapter
    {
        private readonly ChromeSession m_session;
        
        public IndexedDBAdapter(ChromeSession session)
        {
            m_session = session ?? throw new ArgumentNullException(nameof(session));
        }

    
        /// <summary>
        /// Enables events from backend.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command);
        }
    
        /// <summary>
        /// Disables events from backend.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command);
        }
    
        /// <summary>
        /// Requests database names for given security origin.
        /// </summary>
        public async Task<RequestDatabaseNamesCommandResponse> RequestDatabaseNames(RequestDatabaseNamesCommand command)
        {
            return await m_session.SendCommand<RequestDatabaseNamesCommand, RequestDatabaseNamesCommandResponse>(command);
        }
    
        /// <summary>
        /// Requests database with given name in given frame.
        /// </summary>
        public async Task<RequestDatabaseCommandResponse> RequestDatabase(RequestDatabaseCommand command)
        {
            return await m_session.SendCommand<RequestDatabaseCommand, RequestDatabaseCommandResponse>(command);
        }
    
        /// <summary>
        /// Requests data from object store or index.
        /// </summary>
        public async Task<RequestDataCommandResponse> RequestData(RequestDataCommand command)
        {
            return await m_session.SendCommand<RequestDataCommand, RequestDataCommandResponse>(command);
        }
    
        /// <summary>
        /// Clears all entries from an object store.
        /// </summary>
        public async Task<ClearObjectStoreCommandResponse> ClearObjectStore(ClearObjectStoreCommand command)
        {
            return await m_session.SendCommand<ClearObjectStoreCommand, ClearObjectStoreCommandResponse>(command);
        }
    

    
    }
}