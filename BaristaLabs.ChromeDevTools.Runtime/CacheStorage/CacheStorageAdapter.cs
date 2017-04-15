namespace BaristaLabs.ChromeDevTools.Runtime.CacheStorage
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the CacheStorage domain to simplify the command interface.
    /// </summary>
    public class CacheStorageAdapter
    {
        private readonly ChromeSession m_session;
        
        public CacheStorageAdapter(ChromeSession session)
        {
            m_session = session ?? throw new ArgumentNullException(nameof(session));
        }

    
        /// <summary>
        /// Requests cache names.
        /// </summary>
        public async Task<RequestCacheNamesCommandResponse> RequestCacheNames(RequestCacheNamesCommand command)
        {
            return await m_session.SendCommand<RequestCacheNamesCommand, RequestCacheNamesCommandResponse>(command);
        }
    
        /// <summary>
        /// Requests data from cache.
        /// </summary>
        public async Task<RequestEntriesCommandResponse> RequestEntries(RequestEntriesCommand command)
        {
            return await m_session.SendCommand<RequestEntriesCommand, RequestEntriesCommandResponse>(command);
        }
    
        /// <summary>
        /// Deletes a cache.
        /// </summary>
        public async Task<DeleteCacheCommandResponse> DeleteCache(DeleteCacheCommand command)
        {
            return await m_session.SendCommand<DeleteCacheCommand, DeleteCacheCommandResponse>(command);
        }
    
        /// <summary>
        /// Deletes a cache entry.
        /// </summary>
        public async Task<DeleteEntryCommandResponse> DeleteEntry(DeleteEntryCommand command)
        {
            return await m_session.SendCommand<DeleteEntryCommand, DeleteEntryCommandResponse>(command);
        }
    
    }
}