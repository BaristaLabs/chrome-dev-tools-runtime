namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using System;
    using System.Threading;
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
        public async Task<ClearDataForOriginCommandResponse> ClearDataForOrigin(ClearDataForOriginCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ClearDataForOriginCommand, ClearDataForOriginCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns usage and quota in bytes.
        /// </summary>
        public async Task<GetUsageAndQuotaCommandResponse> GetUsageAndQuota(GetUsageAndQuotaCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetUsageAndQuotaCommand, GetUsageAndQuotaCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Registers origin to be notified when an update occurs to its cache storage list.
        /// </summary>
        public async Task<TrackCacheStorageForOriginCommandResponse> TrackCacheStorageForOrigin(TrackCacheStorageForOriginCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<TrackCacheStorageForOriginCommand, TrackCacheStorageForOriginCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Unregisters origin from receiving notifications for cache storage.
        /// </summary>
        public async Task<UntrackCacheStorageForOriginCommandResponse> UntrackCacheStorageForOrigin(UntrackCacheStorageForOriginCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<UntrackCacheStorageForOriginCommand, UntrackCacheStorageForOriginCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

        /// <summary>
        /// A cache has been added/deleted.
        /// </summary>
        public void SubscribeToCacheStorageListUpdatedEvent(Action<CacheStorageListUpdatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// A cache's contents have been modified.
        /// </summary>
        public void SubscribeToCacheStorageContentUpdatedEvent(Action<CacheStorageContentUpdatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    }
}