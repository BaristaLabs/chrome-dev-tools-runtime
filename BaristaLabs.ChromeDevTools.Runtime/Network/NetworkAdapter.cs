namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using System;
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
        /// Enables network tracking, network events will now be delivered to the client.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command);
        }
    
        /// <summary>
        /// Disables network tracking, prevents network events from being sent to the client.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command);
        }
    
        /// <summary>
        /// Allows overriding user agent with the given string.
        /// </summary>
        public async Task<SetUserAgentOverrideCommandResponse> SetUserAgentOverride(SetUserAgentOverrideCommand command)
        {
            return await m_session.SendCommand<SetUserAgentOverrideCommand, SetUserAgentOverrideCommandResponse>(command);
        }
    
        /// <summary>
        /// Specifies whether to always send extra HTTP headers with the requests from this page.
        /// </summary>
        public async Task<SetExtraHTTPHeadersCommandResponse> SetExtraHTTPHeaders(SetExtraHTTPHeadersCommand command)
        {
            return await m_session.SendCommand<SetExtraHTTPHeadersCommand, SetExtraHTTPHeadersCommandResponse>(command);
        }
    
        /// <summary>
        /// Returns content served for the given request.
        /// </summary>
        public async Task<GetResponseBodyCommandResponse> GetResponseBody(GetResponseBodyCommand command)
        {
            return await m_session.SendCommand<GetResponseBodyCommand, GetResponseBodyCommandResponse>(command);
        }
    
        /// <summary>
        /// Blocks specific URL from loading.
        /// </summary>
        public async Task<AddBlockedURLCommandResponse> AddBlockedURL(AddBlockedURLCommand command)
        {
            return await m_session.SendCommand<AddBlockedURLCommand, AddBlockedURLCommandResponse>(command);
        }
    
        /// <summary>
        /// Cancels blocking of a specific URL from loading.
        /// </summary>
        public async Task<RemoveBlockedURLCommandResponse> RemoveBlockedURL(RemoveBlockedURLCommand command)
        {
            return await m_session.SendCommand<RemoveBlockedURLCommand, RemoveBlockedURLCommandResponse>(command);
        }
    
        /// <summary>
        /// This method sends a new XMLHttpRequest which is identical to the original one. The following parameters should be identical: method, url, async, request body, extra headers, withCredentials attribute, user, password.
        /// </summary>
        public async Task<ReplayXHRCommandResponse> ReplayXHR(ReplayXHRCommand command)
        {
            return await m_session.SendCommand<ReplayXHRCommand, ReplayXHRCommandResponse>(command);
        }
    
        /// <summary>
        /// Toggles monitoring of XMLHttpRequest. If <code>true</code>, console will receive messages upon each XHR issued.
        /// </summary>
        public async Task<SetMonitoringXHREnabledCommandResponse> SetMonitoringXHREnabled(SetMonitoringXHREnabledCommand command)
        {
            return await m_session.SendCommand<SetMonitoringXHREnabledCommand, SetMonitoringXHREnabledCommandResponse>(command);
        }
    
        /// <summary>
        /// Tells whether clearing browser cache is supported.
        /// </summary>
        public async Task<CanClearBrowserCacheCommandResponse> CanClearBrowserCache(CanClearBrowserCacheCommand command)
        {
            return await m_session.SendCommand<CanClearBrowserCacheCommand, CanClearBrowserCacheCommandResponse>(command);
        }
    
        /// <summary>
        /// Clears browser cache.
        /// </summary>
        public async Task<ClearBrowserCacheCommandResponse> ClearBrowserCache(ClearBrowserCacheCommand command)
        {
            return await m_session.SendCommand<ClearBrowserCacheCommand, ClearBrowserCacheCommandResponse>(command);
        }
    
        /// <summary>
        /// Tells whether clearing browser cookies is supported.
        /// </summary>
        public async Task<CanClearBrowserCookiesCommandResponse> CanClearBrowserCookies(CanClearBrowserCookiesCommand command)
        {
            return await m_session.SendCommand<CanClearBrowserCookiesCommand, CanClearBrowserCookiesCommandResponse>(command);
        }
    
        /// <summary>
        /// Clears browser cookies.
        /// </summary>
        public async Task<ClearBrowserCookiesCommandResponse> ClearBrowserCookies(ClearBrowserCookiesCommand command)
        {
            return await m_session.SendCommand<ClearBrowserCookiesCommand, ClearBrowserCookiesCommandResponse>(command);
        }
    
        /// <summary>
        /// Returns all browser cookies for the current URL. Depending on the backend support, will return detailed cookie information in the <code>cookies</code> field.
        /// </summary>
        public async Task<GetCookiesCommandResponse> GetCookies(GetCookiesCommand command)
        {
            return await m_session.SendCommand<GetCookiesCommand, GetCookiesCommandResponse>(command);
        }
    
        /// <summary>
        /// Returns all browser cookies. Depending on the backend support, will return detailed cookie information in the <code>cookies</code> field.
        /// </summary>
        public async Task<GetAllCookiesCommandResponse> GetAllCookies(GetAllCookiesCommand command)
        {
            return await m_session.SendCommand<GetAllCookiesCommand, GetAllCookiesCommandResponse>(command);
        }
    
        /// <summary>
        /// Deletes browser cookie with given name, domain and path.
        /// </summary>
        public async Task<DeleteCookieCommandResponse> DeleteCookie(DeleteCookieCommand command)
        {
            return await m_session.SendCommand<DeleteCookieCommand, DeleteCookieCommandResponse>(command);
        }
    
        /// <summary>
        /// Sets a cookie with the given cookie data; may overwrite equivalent cookies if they exist.
        /// </summary>
        public async Task<SetCookieCommandResponse> SetCookie(SetCookieCommand command)
        {
            return await m_session.SendCommand<SetCookieCommand, SetCookieCommandResponse>(command);
        }
    
        /// <summary>
        /// Tells whether emulation of network conditions is supported.
        /// </summary>
        public async Task<CanEmulateNetworkConditionsCommandResponse> CanEmulateNetworkConditions(CanEmulateNetworkConditionsCommand command)
        {
            return await m_session.SendCommand<CanEmulateNetworkConditionsCommand, CanEmulateNetworkConditionsCommandResponse>(command);
        }
    
        /// <summary>
        /// Activates emulation of network conditions.
        /// </summary>
        public async Task<EmulateNetworkConditionsCommandResponse> EmulateNetworkConditions(EmulateNetworkConditionsCommand command)
        {
            return await m_session.SendCommand<EmulateNetworkConditionsCommand, EmulateNetworkConditionsCommandResponse>(command);
        }
    
        /// <summary>
        /// Toggles ignoring cache for each request. If <code>true</code>, cache will not be used.
        /// </summary>
        public async Task<SetCacheDisabledCommandResponse> SetCacheDisabled(SetCacheDisabledCommand command)
        {
            return await m_session.SendCommand<SetCacheDisabledCommand, SetCacheDisabledCommandResponse>(command);
        }
    
        /// <summary>
        /// Toggles ignoring of service worker for each request.
        /// </summary>
        public async Task<SetBypassServiceWorkerCommandResponse> SetBypassServiceWorker(SetBypassServiceWorkerCommand command)
        {
            return await m_session.SendCommand<SetBypassServiceWorkerCommand, SetBypassServiceWorkerCommandResponse>(command);
        }
    
        /// <summary>
        /// For testing.
        /// </summary>
        public async Task<SetDataSizeLimitsForTestCommandResponse> SetDataSizeLimitsForTest(SetDataSizeLimitsForTestCommand command)
        {
            return await m_session.SendCommand<SetDataSizeLimitsForTestCommand, SetDataSizeLimitsForTestCommandResponse>(command);
        }
    
        /// <summary>
        /// Returns the DER-encoded certificate.
        /// </summary>
        public async Task<GetCertificateCommandResponse> GetCertificate(GetCertificateCommand command)
        {
            return await m_session.SendCommand<GetCertificateCommand, GetCertificateCommandResponse>(command);
        }
    
    }
}