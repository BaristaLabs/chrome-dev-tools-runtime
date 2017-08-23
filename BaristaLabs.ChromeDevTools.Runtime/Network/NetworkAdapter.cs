namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Network domain to simplify the command interface.
    /// </summary>
    public class NetworkAdapter
    {
        private readonly ChromeSession m_session;
        
        public NetworkAdapter(ChromeSession session)
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
        /// Enables network tracking, network events will now be delivered to the client.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Disables network tracking, prevents network events from being sent to the client.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command ?? new DisableCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Allows overriding user agent with the given string.
        /// </summary>
        public async Task<SetUserAgentOverrideCommandResponse> SetUserAgentOverride(SetUserAgentOverrideCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetUserAgentOverrideCommand, SetUserAgentOverrideCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Specifies whether to always send extra HTTP headers with the requests from this page.
        /// </summary>
        public async Task<SetExtraHTTPHeadersCommandResponse> SetExtraHTTPHeaders(SetExtraHTTPHeadersCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetExtraHTTPHeadersCommand, SetExtraHTTPHeadersCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns content served for the given request.
        /// </summary>
        public async Task<GetResponseBodyCommandResponse> GetResponseBody(GetResponseBodyCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetResponseBodyCommand, GetResponseBodyCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Blocks URLs from loading.
        /// </summary>
        public async Task<SetBlockedURLsCommandResponse> SetBlockedURLs(SetBlockedURLsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetBlockedURLsCommand, SetBlockedURLsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// This method sends a new XMLHttpRequest which is identical to the original one. The following parameters should be identical: method, url, async, request body, extra headers, withCredentials attribute, user, password.
        /// </summary>
        public async Task<ReplayXHRCommandResponse> ReplayXHR(ReplayXHRCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ReplayXHRCommand, ReplayXHRCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Tells whether clearing browser cache is supported.
        /// </summary>
        public async Task<CanClearBrowserCacheCommandResponse> CanClearBrowserCache(CanClearBrowserCacheCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<CanClearBrowserCacheCommand, CanClearBrowserCacheCommandResponse>(command ?? new CanClearBrowserCacheCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Clears browser cache.
        /// </summary>
        public async Task<ClearBrowserCacheCommandResponse> ClearBrowserCache(ClearBrowserCacheCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ClearBrowserCacheCommand, ClearBrowserCacheCommandResponse>(command ?? new ClearBrowserCacheCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Tells whether clearing browser cookies is supported.
        /// </summary>
        public async Task<CanClearBrowserCookiesCommandResponse> CanClearBrowserCookies(CanClearBrowserCookiesCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<CanClearBrowserCookiesCommand, CanClearBrowserCookiesCommandResponse>(command ?? new CanClearBrowserCookiesCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Clears browser cookies.
        /// </summary>
        public async Task<ClearBrowserCookiesCommandResponse> ClearBrowserCookies(ClearBrowserCookiesCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ClearBrowserCookiesCommand, ClearBrowserCookiesCommandResponse>(command ?? new ClearBrowserCookiesCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns all browser cookies for the current URL. Depending on the backend support, will return detailed cookie information in the &lt;code&gt;cookies&lt;/code&gt; field.
        /// </summary>
        public async Task<GetCookiesCommandResponse> GetCookies(GetCookiesCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetCookiesCommand, GetCookiesCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns all browser cookies. Depending on the backend support, will return detailed cookie information in the &lt;code&gt;cookies&lt;/code&gt; field.
        /// </summary>
        public async Task<GetAllCookiesCommandResponse> GetAllCookies(GetAllCookiesCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetAllCookiesCommand, GetAllCookiesCommandResponse>(command ?? new GetAllCookiesCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Deletes browser cookie with given name, domain and path.
        /// </summary>
        public async Task<DeleteCookieCommandResponse> DeleteCookie(DeleteCookieCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DeleteCookieCommand, DeleteCookieCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Sets a cookie with the given cookie data; may overwrite equivalent cookies if they exist.
        /// </summary>
        public async Task<SetCookieCommandResponse> SetCookie(SetCookieCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetCookieCommand, SetCookieCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Tells whether emulation of network conditions is supported.
        /// </summary>
        public async Task<CanEmulateNetworkConditionsCommandResponse> CanEmulateNetworkConditions(CanEmulateNetworkConditionsCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<CanEmulateNetworkConditionsCommand, CanEmulateNetworkConditionsCommandResponse>(command ?? new CanEmulateNetworkConditionsCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Activates emulation of network conditions.
        /// </summary>
        public async Task<EmulateNetworkConditionsCommandResponse> EmulateNetworkConditions(EmulateNetworkConditionsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EmulateNetworkConditionsCommand, EmulateNetworkConditionsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Toggles ignoring cache for each request. If &lt;code&gt;true&lt;/code&gt;, cache will not be used.
        /// </summary>
        public async Task<SetCacheDisabledCommandResponse> SetCacheDisabled(SetCacheDisabledCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetCacheDisabledCommand, SetCacheDisabledCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Toggles ignoring of service worker for each request.
        /// </summary>
        public async Task<SetBypassServiceWorkerCommandResponse> SetBypassServiceWorker(SetBypassServiceWorkerCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetBypassServiceWorkerCommand, SetBypassServiceWorkerCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// For testing.
        /// </summary>
        public async Task<SetDataSizeLimitsForTestCommandResponse> SetDataSizeLimitsForTest(SetDataSizeLimitsForTestCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetDataSizeLimitsForTestCommand, SetDataSizeLimitsForTestCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns the DER-encoded certificate.
        /// </summary>
        public async Task<GetCertificateCommandResponse> GetCertificate(GetCertificateCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetCertificateCommand, GetCertificateCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

        /// <summary>
        /// Fired when resource loading priority is changed
        /// </summary>
        public void SubscribeToResourceChangedPriorityEvent(Action<ResourceChangedPriorityEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired when page is about to send HTTP request.
        /// </summary>
        public void SubscribeToRequestWillBeSentEvent(Action<RequestWillBeSentEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired if request ended up loading from cache.
        /// </summary>
        public void SubscribeToRequestServedFromCacheEvent(Action<RequestServedFromCacheEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired when HTTP response is available.
        /// </summary>
        public void SubscribeToResponseReceivedEvent(Action<ResponseReceivedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired when data chunk was received over the network.
        /// </summary>
        public void SubscribeToDataReceivedEvent(Action<DataReceivedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired when HTTP request has finished loading.
        /// </summary>
        public void SubscribeToLoadingFinishedEvent(Action<LoadingFinishedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired when HTTP request has failed to load.
        /// </summary>
        public void SubscribeToLoadingFailedEvent(Action<LoadingFailedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired when WebSocket is about to initiate handshake.
        /// </summary>
        public void SubscribeToWebSocketWillSendHandshakeRequestEvent(Action<WebSocketWillSendHandshakeRequestEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired when WebSocket handshake response becomes available.
        /// </summary>
        public void SubscribeToWebSocketHandshakeResponseReceivedEvent(Action<WebSocketHandshakeResponseReceivedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired upon WebSocket creation.
        /// </summary>
        public void SubscribeToWebSocketCreatedEvent(Action<WebSocketCreatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired when WebSocket is closed.
        /// </summary>
        public void SubscribeToWebSocketClosedEvent(Action<WebSocketClosedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired when WebSocket frame is received.
        /// </summary>
        public void SubscribeToWebSocketFrameReceivedEvent(Action<WebSocketFrameReceivedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired when WebSocket frame error occurs.
        /// </summary>
        public void SubscribeToWebSocketFrameErrorEvent(Action<WebSocketFrameErrorEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired when WebSocket frame is sent.
        /// </summary>
        public void SubscribeToWebSocketFrameSentEvent(Action<WebSocketFrameSentEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired when EventSource message is received.
        /// </summary>
        public void SubscribeToEventSourceMessageReceivedEvent(Action<EventSourceMessageReceivedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    }
}