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
        /// Returns all browser cookies.
        /// </summary>
        public async Task<GetCookiesCommandResponse> GetCookies(GetCookiesCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetCookiesCommand, GetCookiesCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Sets given cookies.
        /// </summary>
        public async Task<SetCookiesCommandResponse> SetCookies(SetCookiesCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetCookiesCommand, SetCookiesCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Clears cookies.
        /// </summary>
        public async Task<ClearCookiesCommandResponse> ClearCookies(ClearCookiesCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ClearCookiesCommand, ClearCookiesCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns usage and quota in bytes.
        /// </summary>
        public async Task<GetUsageAndQuotaCommandResponse> GetUsageAndQuota(GetUsageAndQuotaCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetUsageAndQuotaCommand, GetUsageAndQuotaCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Override quota for the specified origin
        /// </summary>
        public async Task<OverrideQuotaForOriginCommandResponse> OverrideQuotaForOrigin(OverrideQuotaForOriginCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<OverrideQuotaForOriginCommand, OverrideQuotaForOriginCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Registers origin to be notified when an update occurs to its cache storage list.
        /// </summary>
        public async Task<TrackCacheStorageForOriginCommandResponse> TrackCacheStorageForOrigin(TrackCacheStorageForOriginCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<TrackCacheStorageForOriginCommand, TrackCacheStorageForOriginCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Registers origin to be notified when an update occurs to its IndexedDB.
        /// </summary>
        public async Task<TrackIndexedDBForOriginCommandResponse> TrackIndexedDBForOrigin(TrackIndexedDBForOriginCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<TrackIndexedDBForOriginCommand, TrackIndexedDBForOriginCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Unregisters origin from receiving notifications for cache storage.
        /// </summary>
        public async Task<UntrackCacheStorageForOriginCommandResponse> UntrackCacheStorageForOrigin(UntrackCacheStorageForOriginCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<UntrackCacheStorageForOriginCommand, UntrackCacheStorageForOriginCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Unregisters origin from receiving notifications for IndexedDB.
        /// </summary>
        public async Task<UntrackIndexedDBForOriginCommandResponse> UntrackIndexedDBForOrigin(UntrackIndexedDBForOriginCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<UntrackIndexedDBForOriginCommand, UntrackIndexedDBForOriginCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns the number of stored Trust Tokens per issuer for the
        /// current browsing context.
        /// </summary>
        public async Task<GetTrustTokensCommandResponse> GetTrustTokens(GetTrustTokensCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetTrustTokensCommand, GetTrustTokensCommandResponse>(command ?? new GetTrustTokensCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Removes all Trust Tokens issued by the provided issuerOrigin.
        /// Leaves other stored data, including the issuer's Redemption Records, intact.
        /// </summary>
        public async Task<ClearTrustTokensCommandResponse> ClearTrustTokens(ClearTrustTokensCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ClearTrustTokensCommand, ClearTrustTokensCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Gets details for a named interest group.
        /// </summary>
        public async Task<GetInterestGroupDetailsCommandResponse> GetInterestGroupDetails(GetInterestGroupDetailsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetInterestGroupDetailsCommand, GetInterestGroupDetailsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Enables/Disables issuing of interestGroupAccessed events.
        /// </summary>
        public async Task<SetInterestGroupTrackingCommandResponse> SetInterestGroupTracking(SetInterestGroupTrackingCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetInterestGroupTrackingCommand, SetInterestGroupTrackingCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

        /// <summary>
        /// A cache's contents have been modified.
        /// </summary>
        public void SubscribeToCacheStorageContentUpdatedEvent(Action<CacheStorageContentUpdatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// A cache has been added/deleted.
        /// </summary>
        public void SubscribeToCacheStorageListUpdatedEvent(Action<CacheStorageListUpdatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// The origin's IndexedDB object store has been modified.
        /// </summary>
        public void SubscribeToIndexedDBContentUpdatedEvent(Action<IndexedDBContentUpdatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// The origin's IndexedDB database list has been modified.
        /// </summary>
        public void SubscribeToIndexedDBListUpdatedEvent(Action<IndexedDBListUpdatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// One of the interest groups was accessed by the associated page.
        /// </summary>
        public void SubscribeToInterestGroupAccessedEvent(Action<InterestGroupAccessedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    }
}