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
        /// Sets a list of content encodings that will be accepted. Empty list means no encoding is accepted.
        /// </summary>
        public async Task<SetAcceptedEncodingsCommandResponse> SetAcceptedEncodings(SetAcceptedEncodingsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetAcceptedEncodingsCommand, SetAcceptedEncodingsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Clears accepted encodings set by setAcceptedEncodings
        /// </summary>
        public async Task<ClearAcceptedEncodingsOverrideCommandResponse> ClearAcceptedEncodingsOverride(ClearAcceptedEncodingsOverrideCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ClearAcceptedEncodingsOverrideCommand, ClearAcceptedEncodingsOverrideCommandResponse>(command ?? new ClearAcceptedEncodingsOverrideCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Tells whether clearing browser cache is supported.
        /// </summary>
        public async Task<CanClearBrowserCacheCommandResponse> CanClearBrowserCache(CanClearBrowserCacheCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<CanClearBrowserCacheCommand, CanClearBrowserCacheCommandResponse>(command ?? new CanClearBrowserCacheCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Tells whether clearing browser cookies is supported.
        /// </summary>
        public async Task<CanClearBrowserCookiesCommandResponse> CanClearBrowserCookies(CanClearBrowserCookiesCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<CanClearBrowserCookiesCommand, CanClearBrowserCookiesCommandResponse>(command ?? new CanClearBrowserCookiesCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Tells whether emulation of network conditions is supported.
        /// </summary>
        public async Task<CanEmulateNetworkConditionsCommandResponse> CanEmulateNetworkConditions(CanEmulateNetworkConditionsCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<CanEmulateNetworkConditionsCommand, CanEmulateNetworkConditionsCommandResponse>(command ?? new CanEmulateNetworkConditionsCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Clears browser cache.
        /// </summary>
        public async Task<ClearBrowserCacheCommandResponse> ClearBrowserCache(ClearBrowserCacheCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ClearBrowserCacheCommand, ClearBrowserCacheCommandResponse>(command ?? new ClearBrowserCacheCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Clears browser cookies.
        /// </summary>
        public async Task<ClearBrowserCookiesCommandResponse> ClearBrowserCookies(ClearBrowserCookiesCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ClearBrowserCookiesCommand, ClearBrowserCookiesCommandResponse>(command ?? new ClearBrowserCookiesCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Response to Network.requestIntercepted which either modifies the request to continue with any
        /// modifications, or blocks it, or completes it with the provided response bytes. If a network
        /// fetch occurs as a result which encounters a redirect an additional Network.requestIntercepted
        /// event will be sent with the same InterceptionId.
        /// Deprecated, use Fetch.continueRequest, Fetch.fulfillRequest and Fetch.failRequest instead.
        /// </summary>
        public async Task<ContinueInterceptedRequestCommandResponse> ContinueInterceptedRequest(ContinueInterceptedRequestCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ContinueInterceptedRequestCommand, ContinueInterceptedRequestCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Deletes browser cookies with matching name and url or domain/path pair.
        /// </summary>
        public async Task<DeleteCookiesCommandResponse> DeleteCookies(DeleteCookiesCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DeleteCookiesCommand, DeleteCookiesCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Disables network tracking, prevents network events from being sent to the client.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command ?? new DisableCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Activates emulation of network conditions.
        /// </summary>
        public async Task<EmulateNetworkConditionsCommandResponse> EmulateNetworkConditions(EmulateNetworkConditionsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EmulateNetworkConditionsCommand, EmulateNetworkConditionsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Enables network tracking, network events will now be delivered to the client.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns all browser cookies. Depending on the backend support, will return detailed cookie
        /// information in the `cookies` field.
        /// </summary>
        public async Task<GetAllCookiesCommandResponse> GetAllCookies(GetAllCookiesCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetAllCookiesCommand, GetAllCookiesCommandResponse>(command ?? new GetAllCookiesCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns the DER-encoded certificate.
        /// </summary>
        public async Task<GetCertificateCommandResponse> GetCertificate(GetCertificateCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetCertificateCommand, GetCertificateCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns all browser cookies for the current URL. Depending on the backend support, will return
        /// detailed cookie information in the `cookies` field.
        /// </summary>
        public async Task<GetCookiesCommandResponse> GetCookies(GetCookiesCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetCookiesCommand, GetCookiesCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns content served for the given request.
        /// </summary>
        public async Task<GetResponseBodyCommandResponse> GetResponseBody(GetResponseBodyCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetResponseBodyCommand, GetResponseBodyCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns post data sent with the request. Returns an error when no data was sent with the request.
        /// </summary>
        public async Task<GetRequestPostDataCommandResponse> GetRequestPostData(GetRequestPostDataCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetRequestPostDataCommand, GetRequestPostDataCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns content served for the given currently intercepted request.
        /// </summary>
        public async Task<GetResponseBodyForInterceptionCommandResponse> GetResponseBodyForInterception(GetResponseBodyForInterceptionCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetResponseBodyForInterceptionCommand, GetResponseBodyForInterceptionCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns a handle to the stream representing the response body. Note that after this command,
        /// the intercepted request can't be continued as is -- you either need to cancel it or to provide
        /// the response body. The stream only supports sequential read, IO.read will fail if the position
        /// is specified.
        /// </summary>
        public async Task<TakeResponseBodyForInterceptionAsStreamCommandResponse> TakeResponseBodyForInterceptionAsStream(TakeResponseBodyForInterceptionAsStreamCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<TakeResponseBodyForInterceptionAsStreamCommand, TakeResponseBodyForInterceptionAsStreamCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// This method sends a new XMLHttpRequest which is identical to the original one. The following
        /// parameters should be identical: method, url, async, request body, extra headers, withCredentials
        /// attribute, user, password.
        /// </summary>
        public async Task<ReplayXHRCommandResponse> ReplayXHR(ReplayXHRCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ReplayXHRCommand, ReplayXHRCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Searches for given string in response content.
        /// </summary>
        public async Task<SearchInResponseBodyCommandResponse> SearchInResponseBody(SearchInResponseBodyCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SearchInResponseBodyCommand, SearchInResponseBodyCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Blocks URLs from loading.
        /// </summary>
        public async Task<SetBlockedURLsCommandResponse> SetBlockedURLs(SetBlockedURLsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetBlockedURLsCommand, SetBlockedURLsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Toggles ignoring of service worker for each request.
        /// </summary>
        public async Task<SetBypassServiceWorkerCommandResponse> SetBypassServiceWorker(SetBypassServiceWorkerCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetBypassServiceWorkerCommand, SetBypassServiceWorkerCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Toggles ignoring cache for each request. If `true`, cache will not be used.
        /// </summary>
        public async Task<SetCacheDisabledCommandResponse> SetCacheDisabled(SetCacheDisabledCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetCacheDisabledCommand, SetCacheDisabledCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Sets a cookie with the given cookie data; may overwrite equivalent cookies if they exist.
        /// </summary>
        public async Task<SetCookieCommandResponse> SetCookie(SetCookieCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetCookieCommand, SetCookieCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Sets given cookies.
        /// </summary>
        public async Task<SetCookiesCommandResponse> SetCookies(SetCookiesCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetCookiesCommand, SetCookiesCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Specifies whether to always send extra HTTP headers with the requests from this page.
        /// </summary>
        public async Task<SetExtraHTTPHeadersCommandResponse> SetExtraHTTPHeaders(SetExtraHTTPHeadersCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetExtraHTTPHeadersCommand, SetExtraHTTPHeadersCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Specifies whether to attach a page script stack id in requests
        /// </summary>
        public async Task<SetAttachDebugStackCommandResponse> SetAttachDebugStack(SetAttachDebugStackCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetAttachDebugStackCommand, SetAttachDebugStackCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Sets the requests to intercept that match the provided patterns and optionally resource types.
        /// Deprecated, please use Fetch.enable instead.
        /// </summary>
        public async Task<SetRequestInterceptionCommandResponse> SetRequestInterception(SetRequestInterceptionCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetRequestInterceptionCommand, SetRequestInterceptionCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Allows overriding user agent with the given string.
        /// </summary>
        public async Task<SetUserAgentOverrideCommandResponse> SetUserAgentOverride(SetUserAgentOverrideCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetUserAgentOverrideCommand, SetUserAgentOverrideCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns information about the COEP/COOP isolation status.
        /// </summary>
        public async Task<GetSecurityIsolationStatusCommandResponse> GetSecurityIsolationStatus(GetSecurityIsolationStatusCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetSecurityIsolationStatusCommand, GetSecurityIsolationStatusCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Enables tracking for the Reporting API, events generated by the Reporting API will now be delivered to the client.
        /// Enabling triggers 'reportingApiReportAdded' for all existing reports.
        /// </summary>
        public async Task<EnableReportingApiCommandResponse> EnableReportingApi(EnableReportingApiCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EnableReportingApiCommand, EnableReportingApiCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Fetches the resource and returns the content.
        /// </summary>
        public async Task<LoadNetworkResourceCommandResponse> LoadNetworkResource(LoadNetworkResourceCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<LoadNetworkResourceCommand, LoadNetworkResourceCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

        /// <summary>
        /// Fired when data chunk was received over the network.
        /// </summary>
        public void SubscribeToDataReceivedEvent(Action<DataReceivedEvent> eventCallback)
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
        /// <summary>
        /// Fired when HTTP request has failed to load.
        /// </summary>
        public void SubscribeToLoadingFailedEvent(Action<LoadingFailedEvent> eventCallback)
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
        /// Details of an intercepted HTTP request, which must be either allowed, blocked, modified or
        /// mocked.
        /// Deprecated, use Fetch.requestPaused instead.
        /// </summary>
        public void SubscribeToRequestInterceptedEvent(Action<RequestInterceptedEvent> eventCallback)
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
        /// Fired when page is about to send HTTP request.
        /// </summary>
        public void SubscribeToRequestWillBeSentEvent(Action<RequestWillBeSentEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired when resource loading priority is changed
        /// </summary>
        public void SubscribeToResourceChangedPriorityEvent(Action<ResourceChangedPriorityEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired when a signed exchange was received over the network
        /// </summary>
        public void SubscribeToSignedExchangeReceivedEvent(Action<SignedExchangeReceivedEvent> eventCallback)
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
        /// Fired when WebSocket is closed.
        /// </summary>
        public void SubscribeToWebSocketClosedEvent(Action<WebSocketClosedEvent> eventCallback)
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
        /// Fired when WebSocket message error occurs.
        /// </summary>
        public void SubscribeToWebSocketFrameErrorEvent(Action<WebSocketFrameErrorEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired when WebSocket message is received.
        /// </summary>
        public void SubscribeToWebSocketFrameReceivedEvent(Action<WebSocketFrameReceivedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired when WebSocket message is sent.
        /// </summary>
        public void SubscribeToWebSocketFrameSentEvent(Action<WebSocketFrameSentEvent> eventCallback)
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
        /// Fired when WebSocket is about to initiate handshake.
        /// </summary>
        public void SubscribeToWebSocketWillSendHandshakeRequestEvent(Action<WebSocketWillSendHandshakeRequestEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired upon WebTransport creation.
        /// </summary>
        public void SubscribeToWebTransportCreatedEvent(Action<WebTransportCreatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired when WebTransport handshake is finished.
        /// </summary>
        public void SubscribeToWebTransportConnectionEstablishedEvent(Action<WebTransportConnectionEstablishedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired when WebTransport is disposed.
        /// </summary>
        public void SubscribeToWebTransportClosedEvent(Action<WebTransportClosedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired when additional information about a requestWillBeSent event is available from the
        /// network stack. Not every requestWillBeSent event will have an additional
        /// requestWillBeSentExtraInfo fired for it, and there is no guarantee whether requestWillBeSent
        /// or requestWillBeSentExtraInfo will be fired first for the same request.
        /// </summary>
        public void SubscribeToRequestWillBeSentExtraInfoEvent(Action<RequestWillBeSentExtraInfoEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired when additional information about a responseReceived event is available from the network
        /// stack. Not every responseReceived event will have an additional responseReceivedExtraInfo for
        /// it, and responseReceivedExtraInfo may be fired before or after responseReceived.
        /// </summary>
        public void SubscribeToResponseReceivedExtraInfoEvent(Action<ResponseReceivedExtraInfoEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired exactly once for each Trust Token operation. Depending on
        /// the type of the operation and whether the operation succeeded or
        /// failed, the event is fired before the corresponding request was sent
        /// or after the response was received.
        /// </summary>
        public void SubscribeToTrustTokenOperationDoneEvent(Action<TrustTokenOperationDoneEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired once when parsing the .wbn file has succeeded.
        /// The event contains the information about the web bundle contents.
        /// </summary>
        public void SubscribeToSubresourceWebBundleMetadataReceivedEvent(Action<SubresourceWebBundleMetadataReceivedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired once when parsing the .wbn file has failed.
        /// </summary>
        public void SubscribeToSubresourceWebBundleMetadataErrorEvent(Action<SubresourceWebBundleMetadataErrorEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired when handling requests for resources within a .wbn file.
        /// Note: this will only be fired for resources that are requested by the webpage.
        /// </summary>
        public void SubscribeToSubresourceWebBundleInnerResponseParsedEvent(Action<SubresourceWebBundleInnerResponseParsedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired when request for resources within a .wbn file failed.
        /// </summary>
        public void SubscribeToSubresourceWebBundleInnerResponseErrorEvent(Action<SubresourceWebBundleInnerResponseErrorEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Is sent whenever a new report is added.
        /// And after 'enableReportingApi' for all existing reports.
        /// </summary>
        public void SubscribeToReportingApiReportAddedEvent(Action<ReportingApiReportAddedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// reportingApiReportUpdated
        /// </summary>
        public void SubscribeToReportingApiReportUpdatedEvent(Action<ReportingApiReportUpdatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// reportingApiEndpointsChangedForOrigin
        /// </summary>
        public void SubscribeToReportingApiEndpointsChangedForOriginEvent(Action<ReportingApiEndpointsChangedForOriginEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    }
}