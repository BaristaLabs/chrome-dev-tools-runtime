namespace BaristaLabs.ChromeDevTools.Runtime.CacheStorage
{
    using System;
    using System.Threading;
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
        /// Gets the ChromeSession associated with the adapter.
        /// </summary>
        public ChromeSession Session
        {
            get { return m_session; }
        }

    
        /// <summary>
        /// Requests cache names.
        /// </summary>
        public async Task<RequestCacheNamesCommandResponse> RequestCacheNames(RequestCacheNamesCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<RequestCacheNamesCommand, RequestCacheNamesCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Requests data from cache.
        /// </summary>
        public async Task<RequestEntriesCommandResponse> RequestEntries(RequestEntriesCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<RequestEntriesCommand, RequestEntriesCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Deletes a cache.
        /// </summary>
        public async Task<DeleteCacheCommandResponse> DeleteCache(DeleteCacheCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DeleteCacheCommand, DeleteCacheCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Deletes a cache entry.
        /// </summary>
        public async Task<DeleteEntryCommandResponse> DeleteEntry(DeleteEntryCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DeleteEntryCommand, DeleteEntryCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    

    
    }
}