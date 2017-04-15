namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Page domain to simplify the command interface.
    /// </summary>
    public class PageAdapter
    {
        private readonly ChromeSession m_session;
        
        public PageAdapter(ChromeSession session)
        {
            m_session = session ?? throw new ArgumentNullException(nameof(session));
        }

    
        /// <summary>
        /// Enables page domain notifications.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command);
        }
    
        /// <summary>
        /// Disables page domain notifications.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<AddScriptToEvaluateOnLoadCommandResponse> AddScriptToEvaluateOnLoad(AddScriptToEvaluateOnLoadCommand command)
        {
            return await m_session.SendCommand<AddScriptToEvaluateOnLoadCommand, AddScriptToEvaluateOnLoadCommandResponse>(command);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<RemoveScriptToEvaluateOnLoadCommandResponse> RemoveScriptToEvaluateOnLoad(RemoveScriptToEvaluateOnLoadCommand command)
        {
            return await m_session.SendCommand<RemoveScriptToEvaluateOnLoadCommand, RemoveScriptToEvaluateOnLoadCommandResponse>(command);
        }
    
        /// <summary>
        /// Controls whether browser will open a new inspector window for connected pages.
        /// </summary>
        public async Task<SetAutoAttachToCreatedPagesCommandResponse> SetAutoAttachToCreatedPages(SetAutoAttachToCreatedPagesCommand command)
        {
            return await m_session.SendCommand<SetAutoAttachToCreatedPagesCommand, SetAutoAttachToCreatedPagesCommandResponse>(command);
        }
    
        /// <summary>
        /// Reloads given page optionally ignoring the cache.
        /// </summary>
        public async Task<ReloadCommandResponse> Reload(ReloadCommand command)
        {
            return await m_session.SendCommand<ReloadCommand, ReloadCommandResponse>(command);
        }
    
        /// <summary>
        /// Navigates current page to the given URL.
        /// </summary>
        public async Task<NavigateCommandResponse> Navigate(NavigateCommand command)
        {
            return await m_session.SendCommand<NavigateCommand, NavigateCommandResponse>(command);
        }
    
        /// <summary>
        /// Force the page stop all navigations and pending resource fetches.
        /// </summary>
        public async Task<StopLoadingCommandResponse> StopLoading(StopLoadingCommand command)
        {
            return await m_session.SendCommand<StopLoadingCommand, StopLoadingCommandResponse>(command);
        }
    
        /// <summary>
        /// Returns navigation history for the current page.
        /// </summary>
        public async Task<GetNavigationHistoryCommandResponse> GetNavigationHistory(GetNavigationHistoryCommand command)
        {
            return await m_session.SendCommand<GetNavigationHistoryCommand, GetNavigationHistoryCommandResponse>(command);
        }
    
        /// <summary>
        /// Navigates current page to the given history entry.
        /// </summary>
        public async Task<NavigateToHistoryEntryCommandResponse> NavigateToHistoryEntry(NavigateToHistoryEntryCommand command)
        {
            return await m_session.SendCommand<NavigateToHistoryEntryCommand, NavigateToHistoryEntryCommandResponse>(command);
        }
    
        /// <summary>
        /// Returns all browser cookies. Depending on the backend support, will return detailed cookie information in the <code>cookies</code> field.
        /// </summary>
        public async Task<GetCookiesCommandResponse> GetCookies(GetCookiesCommand command)
        {
            return await m_session.SendCommand<GetCookiesCommand, GetCookiesCommandResponse>(command);
        }
    
        /// <summary>
        /// Deletes browser cookie with given name, domain and path.
        /// </summary>
        public async Task<DeleteCookieCommandResponse> DeleteCookie(DeleteCookieCommand command)
        {
            return await m_session.SendCommand<DeleteCookieCommand, DeleteCookieCommandResponse>(command);
        }
    
        /// <summary>
        /// Returns present frame / resource tree structure.
        /// </summary>
        public async Task<GetResourceTreeCommandResponse> GetResourceTree(GetResourceTreeCommand command)
        {
            return await m_session.SendCommand<GetResourceTreeCommand, GetResourceTreeCommandResponse>(command);
        }
    
        /// <summary>
        /// Returns content of the given resource.
        /// </summary>
        public async Task<GetResourceContentCommandResponse> GetResourceContent(GetResourceContentCommand command)
        {
            return await m_session.SendCommand<GetResourceContentCommand, GetResourceContentCommandResponse>(command);
        }
    
        /// <summary>
        /// Searches for given string in resource content.
        /// </summary>
        public async Task<SearchInResourceCommandResponse> SearchInResource(SearchInResourceCommand command)
        {
            return await m_session.SendCommand<SearchInResourceCommand, SearchInResourceCommandResponse>(command);
        }
    
        /// <summary>
        /// Sets given markup as the document's HTML.
        /// </summary>
        public async Task<SetDocumentContentCommandResponse> SetDocumentContent(SetDocumentContentCommand command)
        {
            return await m_session.SendCommand<SetDocumentContentCommand, SetDocumentContentCommandResponse>(command);
        }
    
        /// <summary>
        /// Overrides the values of device screen dimensions (window.screen.width, window.screen.height, window.innerWidth, window.innerHeight, and "device-width"/"device-height"-related CSS media query results).
        /// </summary>
        public async Task<SetDeviceMetricsOverrideCommandResponse> SetDeviceMetricsOverride(SetDeviceMetricsOverrideCommand command)
        {
            return await m_session.SendCommand<SetDeviceMetricsOverrideCommand, SetDeviceMetricsOverrideCommandResponse>(command);
        }
    
        /// <summary>
        /// Clears the overriden device metrics.
        /// </summary>
        public async Task<ClearDeviceMetricsOverrideCommandResponse> ClearDeviceMetricsOverride(ClearDeviceMetricsOverrideCommand command)
        {
            return await m_session.SendCommand<ClearDeviceMetricsOverrideCommand, ClearDeviceMetricsOverrideCommandResponse>(command);
        }
    
        /// <summary>
        /// Overrides the Geolocation Position or Error. Omitting any of the parameters emulates position unavailable.
        /// </summary>
        public async Task<SetGeolocationOverrideCommandResponse> SetGeolocationOverride(SetGeolocationOverrideCommand command)
        {
            return await m_session.SendCommand<SetGeolocationOverrideCommand, SetGeolocationOverrideCommandResponse>(command);
        }
    
        /// <summary>
        /// Clears the overriden Geolocation Position and Error.
        /// </summary>
        public async Task<ClearGeolocationOverrideCommandResponse> ClearGeolocationOverride(ClearGeolocationOverrideCommand command)
        {
            return await m_session.SendCommand<ClearGeolocationOverrideCommand, ClearGeolocationOverrideCommandResponse>(command);
        }
    
        /// <summary>
        /// Overrides the Device Orientation.
        /// </summary>
        public async Task<SetDeviceOrientationOverrideCommandResponse> SetDeviceOrientationOverride(SetDeviceOrientationOverrideCommand command)
        {
            return await m_session.SendCommand<SetDeviceOrientationOverrideCommand, SetDeviceOrientationOverrideCommandResponse>(command);
        }
    
        /// <summary>
        /// Clears the overridden Device Orientation.
        /// </summary>
        public async Task<ClearDeviceOrientationOverrideCommandResponse> ClearDeviceOrientationOverride(ClearDeviceOrientationOverrideCommand command)
        {
            return await m_session.SendCommand<ClearDeviceOrientationOverrideCommand, ClearDeviceOrientationOverrideCommandResponse>(command);
        }
    
        /// <summary>
        /// Toggles mouse event-based touch event emulation.
        /// </summary>
        public async Task<SetTouchEmulationEnabledCommandResponse> SetTouchEmulationEnabled(SetTouchEmulationEnabledCommand command)
        {
            return await m_session.SendCommand<SetTouchEmulationEnabledCommand, SetTouchEmulationEnabledCommandResponse>(command);
        }
    
        /// <summary>
        /// Capture page screenshot.
        /// </summary>
        public async Task<CaptureScreenshotCommandResponse> CaptureScreenshot(CaptureScreenshotCommand command)
        {
            return await m_session.SendCommand<CaptureScreenshotCommand, CaptureScreenshotCommandResponse>(command);
        }
    
        /// <summary>
        /// Starts sending each frame using the <code>screencastFrame</code> event.
        /// </summary>
        public async Task<StartScreencastCommandResponse> StartScreencast(StartScreencastCommand command)
        {
            return await m_session.SendCommand<StartScreencastCommand, StartScreencastCommandResponse>(command);
        }
    
        /// <summary>
        /// Stops sending each frame in the <code>screencastFrame</code>.
        /// </summary>
        public async Task<StopScreencastCommandResponse> StopScreencast(StopScreencastCommand command)
        {
            return await m_session.SendCommand<StopScreencastCommand, StopScreencastCommandResponse>(command);
        }
    
        /// <summary>
        /// Acknowledges that a screencast frame has been received by the frontend.
        /// </summary>
        public async Task<ScreencastFrameAckCommandResponse> ScreencastFrameAck(ScreencastFrameAckCommand command)
        {
            return await m_session.SendCommand<ScreencastFrameAckCommand, ScreencastFrameAckCommandResponse>(command);
        }
    
        /// <summary>
        /// Accepts or dismisses a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload).
        /// </summary>
        public async Task<HandleJavaScriptDialogCommandResponse> HandleJavaScriptDialog(HandleJavaScriptDialogCommand command)
        {
            return await m_session.SendCommand<HandleJavaScriptDialogCommand, HandleJavaScriptDialogCommandResponse>(command);
        }
    
        /// <summary>
        /// Shows / hides color picker
        /// </summary>
        public async Task<SetColorPickerEnabledCommandResponse> SetColorPickerEnabled(SetColorPickerEnabledCommand command)
        {
            return await m_session.SendCommand<SetColorPickerEnabledCommand, SetColorPickerEnabledCommandResponse>(command);
        }
    
        /// <summary>
        /// Configures overlay.
        /// </summary>
        public async Task<ConfigureOverlayCommandResponse> ConfigureOverlay(ConfigureOverlayCommand command)
        {
            return await m_session.SendCommand<ConfigureOverlayCommand, ConfigureOverlayCommandResponse>(command);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<GetAppManifestCommandResponse> GetAppManifest(GetAppManifestCommand command)
        {
            return await m_session.SendCommand<GetAppManifestCommand, GetAppManifestCommandResponse>(command);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<RequestAppBannerCommandResponse> RequestAppBanner(RequestAppBannerCommand command)
        {
            return await m_session.SendCommand<RequestAppBannerCommand, RequestAppBannerCommandResponse>(command);
        }
    
        /// <summary>
        /// Toggles navigation throttling which allows programatic control over navigation and redirect response.
        /// </summary>
        public async Task<SetControlNavigationsCommandResponse> SetControlNavigations(SetControlNavigationsCommand command)
        {
            return await m_session.SendCommand<SetControlNavigationsCommand, SetControlNavigationsCommandResponse>(command);
        }
    
        /// <summary>
        /// Should be sent in response to a navigationRequested or a redirectRequested event, telling the browser how to handle the navigation.
        /// </summary>
        public async Task<ProcessNavigationCommandResponse> ProcessNavigation(ProcessNavigationCommand command)
        {
            return await m_session.SendCommand<ProcessNavigationCommand, ProcessNavigationCommandResponse>(command);
        }
    
        /// <summary>
        /// Returns metrics relating to the layouting of the page, such as viewport bounds/scale.
        /// </summary>
        public async Task<GetLayoutMetricsCommandResponse> GetLayoutMetrics(GetLayoutMetricsCommand command)
        {
            return await m_session.SendCommand<GetLayoutMetricsCommand, GetLayoutMetricsCommandResponse>(command);
        }
    
    }
}