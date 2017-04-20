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
        /// Gets the ChromeSession associated with the adapter.
        /// </summary>
        public ChromeSession Session
        {
            get { return m_session; }
        }

    
        /// <summary>
        /// Enables page domain notifications.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Disables page domain notifications.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<AddScriptToEvaluateOnLoadCommandResponse> AddScriptToEvaluateOnLoad(AddScriptToEvaluateOnLoadCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<AddScriptToEvaluateOnLoadCommand, AddScriptToEvaluateOnLoadCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<RemoveScriptToEvaluateOnLoadCommandResponse> RemoveScriptToEvaluateOnLoad(RemoveScriptToEvaluateOnLoadCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<RemoveScriptToEvaluateOnLoadCommand, RemoveScriptToEvaluateOnLoadCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Controls whether browser will open a new inspector window for connected pages.
        /// </summary>
        public async Task<SetAutoAttachToCreatedPagesCommandResponse> SetAutoAttachToCreatedPages(SetAutoAttachToCreatedPagesCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetAutoAttachToCreatedPagesCommand, SetAutoAttachToCreatedPagesCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Reloads given page optionally ignoring the cache.
        /// </summary>
        public async Task<ReloadCommandResponse> Reload(ReloadCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ReloadCommand, ReloadCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Navigates current page to the given URL.
        /// </summary>
        public async Task<NavigateCommandResponse> Navigate(NavigateCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<NavigateCommand, NavigateCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Force the page stop all navigations and pending resource fetches.
        /// </summary>
        public async Task<StopLoadingCommandResponse> StopLoading(StopLoadingCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<StopLoadingCommand, StopLoadingCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Returns navigation history for the current page.
        /// </summary>
        public async Task<GetNavigationHistoryCommandResponse> GetNavigationHistory(GetNavigationHistoryCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetNavigationHistoryCommand, GetNavigationHistoryCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Navigates current page to the given history entry.
        /// </summary>
        public async Task<NavigateToHistoryEntryCommandResponse> NavigateToHistoryEntry(NavigateToHistoryEntryCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<NavigateToHistoryEntryCommand, NavigateToHistoryEntryCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Returns all browser cookies. Depending on the backend support, will return detailed cookie information in the <code>cookies</code> field.
        /// </summary>
        public async Task<GetCookiesCommandResponse> GetCookies(GetCookiesCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetCookiesCommand, GetCookiesCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Deletes browser cookie with given name, domain and path.
        /// </summary>
        public async Task<DeleteCookieCommandResponse> DeleteCookie(DeleteCookieCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DeleteCookieCommand, DeleteCookieCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Returns present frame / resource tree structure.
        /// </summary>
        public async Task<GetResourceTreeCommandResponse> GetResourceTree(GetResourceTreeCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetResourceTreeCommand, GetResourceTreeCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Returns content of the given resource.
        /// </summary>
        public async Task<GetResourceContentCommandResponse> GetResourceContent(GetResourceContentCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetResourceContentCommand, GetResourceContentCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Searches for given string in resource content.
        /// </summary>
        public async Task<SearchInResourceCommandResponse> SearchInResource(SearchInResourceCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SearchInResourceCommand, SearchInResourceCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Sets given markup as the document's HTML.
        /// </summary>
        public async Task<SetDocumentContentCommandResponse> SetDocumentContent(SetDocumentContentCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetDocumentContentCommand, SetDocumentContentCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Overrides the values of device screen dimensions (window.screen.width, window.screen.height, window.innerWidth, window.innerHeight, and "device-width"/"device-height"-related CSS media query results).
        /// </summary>
        public async Task<SetDeviceMetricsOverrideCommandResponse> SetDeviceMetricsOverride(SetDeviceMetricsOverrideCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetDeviceMetricsOverrideCommand, SetDeviceMetricsOverrideCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Clears the overriden device metrics.
        /// </summary>
        public async Task<ClearDeviceMetricsOverrideCommandResponse> ClearDeviceMetricsOverride(ClearDeviceMetricsOverrideCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ClearDeviceMetricsOverrideCommand, ClearDeviceMetricsOverrideCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Overrides the Geolocation Position or Error. Omitting any of the parameters emulates position unavailable.
        /// </summary>
        public async Task<SetGeolocationOverrideCommandResponse> SetGeolocationOverride(SetGeolocationOverrideCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetGeolocationOverrideCommand, SetGeolocationOverrideCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Clears the overriden Geolocation Position and Error.
        /// </summary>
        public async Task<ClearGeolocationOverrideCommandResponse> ClearGeolocationOverride(ClearGeolocationOverrideCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ClearGeolocationOverrideCommand, ClearGeolocationOverrideCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Overrides the Device Orientation.
        /// </summary>
        public async Task<SetDeviceOrientationOverrideCommandResponse> SetDeviceOrientationOverride(SetDeviceOrientationOverrideCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetDeviceOrientationOverrideCommand, SetDeviceOrientationOverrideCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Clears the overridden Device Orientation.
        /// </summary>
        public async Task<ClearDeviceOrientationOverrideCommandResponse> ClearDeviceOrientationOverride(ClearDeviceOrientationOverrideCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ClearDeviceOrientationOverrideCommand, ClearDeviceOrientationOverrideCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Toggles mouse event-based touch event emulation.
        /// </summary>
        public async Task<SetTouchEmulationEnabledCommandResponse> SetTouchEmulationEnabled(SetTouchEmulationEnabledCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetTouchEmulationEnabledCommand, SetTouchEmulationEnabledCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Capture page screenshot.
        /// </summary>
        public async Task<CaptureScreenshotCommandResponse> CaptureScreenshot(CaptureScreenshotCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<CaptureScreenshotCommand, CaptureScreenshotCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Print page as pdf.
        /// </summary>
        public async Task<PrintToPDFCommandResponse> PrintToPDF(PrintToPDFCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<PrintToPDFCommand, PrintToPDFCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Starts sending each frame using the <code>screencastFrame</code> event.
        /// </summary>
        public async Task<StartScreencastCommandResponse> StartScreencast(StartScreencastCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<StartScreencastCommand, StartScreencastCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Stops sending each frame in the <code>screencastFrame</code>.
        /// </summary>
        public async Task<StopScreencastCommandResponse> StopScreencast(StopScreencastCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<StopScreencastCommand, StopScreencastCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Acknowledges that a screencast frame has been received by the frontend.
        /// </summary>
        public async Task<ScreencastFrameAckCommandResponse> ScreencastFrameAck(ScreencastFrameAckCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ScreencastFrameAckCommand, ScreencastFrameAckCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Accepts or dismisses a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload).
        /// </summary>
        public async Task<HandleJavaScriptDialogCommandResponse> HandleJavaScriptDialog(HandleJavaScriptDialogCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<HandleJavaScriptDialogCommand, HandleJavaScriptDialogCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Shows / hides color picker
        /// </summary>
        public async Task<SetColorPickerEnabledCommandResponse> SetColorPickerEnabled(SetColorPickerEnabledCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetColorPickerEnabledCommand, SetColorPickerEnabledCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Configures overlay.
        /// </summary>
        public async Task<ConfigureOverlayCommandResponse> ConfigureOverlay(ConfigureOverlayCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ConfigureOverlayCommand, ConfigureOverlayCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<GetAppManifestCommandResponse> GetAppManifest(GetAppManifestCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetAppManifestCommand, GetAppManifestCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<RequestAppBannerCommandResponse> RequestAppBanner(RequestAppBannerCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<RequestAppBannerCommand, RequestAppBannerCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Toggles navigation throttling which allows programatic control over navigation and redirect response.
        /// </summary>
        public async Task<SetControlNavigationsCommandResponse> SetControlNavigations(SetControlNavigationsCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetControlNavigationsCommand, SetControlNavigationsCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Should be sent in response to a navigationRequested or a redirectRequested event, telling the browser how to handle the navigation.
        /// </summary>
        public async Task<ProcessNavigationCommandResponse> ProcessNavigation(ProcessNavigationCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ProcessNavigationCommand, ProcessNavigationCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Returns metrics relating to the layouting of the page, such as viewport bounds/scale.
        /// </summary>
        public async Task<GetLayoutMetricsCommandResponse> GetLayoutMetrics(GetLayoutMetricsCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetLayoutMetricsCommand, GetLayoutMetricsCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    

    
        /// <summary>
        /// 
        /// </summary>
        public void SubscribeToDomContentEventFiredEvent(Action<DomContentEventFiredEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public void SubscribeToLoadEventFiredEvent(Action<LoadEventFiredEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Fired when frame has been attached to its parent.
        /// </summary>
        public void SubscribeToFrameAttachedEvent(Action<FrameAttachedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Fired once navigation of the frame has completed. Frame is now associated with the new loader.
        /// </summary>
        public void SubscribeToFrameNavigatedEvent(Action<FrameNavigatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Fired when frame has been detached from its parent.
        /// </summary>
        public void SubscribeToFrameDetachedEvent(Action<FrameDetachedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Fired when frame has started loading.
        /// </summary>
        public void SubscribeToFrameStartedLoadingEvent(Action<FrameStartedLoadingEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Fired when frame has stopped loading.
        /// </summary>
        public void SubscribeToFrameStoppedLoadingEvent(Action<FrameStoppedLoadingEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Fired when frame schedules a potential navigation.
        /// </summary>
        public void SubscribeToFrameScheduledNavigationEvent(Action<FrameScheduledNavigationEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Fired when frame no longer has a scheduled navigation.
        /// </summary>
        public void SubscribeToFrameClearedScheduledNavigationEvent(Action<FrameClearedScheduledNavigationEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public void SubscribeToFrameResizedEvent(Action<FrameResizedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Fired when a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload) is about to open.
        /// </summary>
        public void SubscribeToJavascriptDialogOpeningEvent(Action<JavascriptDialogOpeningEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Fired when a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload) has been closed.
        /// </summary>
        public void SubscribeToJavascriptDialogClosedEvent(Action<JavascriptDialogClosedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Compressed image data requested by the <code>startScreencast</code>.
        /// </summary>
        public void SubscribeToScreencastFrameEvent(Action<ScreencastFrameEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Fired when the page with currently enabled screencast was shown or hidden </code>.
        /// </summary>
        public void SubscribeToScreencastVisibilityChangedEvent(Action<ScreencastVisibilityChangedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Fired when a color has been picked.
        /// </summary>
        public void SubscribeToColorPickedEvent(Action<ColorPickedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Fired when interstitial page was shown
        /// </summary>
        public void SubscribeToInterstitialShownEvent(Action<InterstitialShownEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Fired when interstitial page was hidden
        /// </summary>
        public void SubscribeToInterstitialHiddenEvent(Action<InterstitialHiddenEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Fired when a navigation is started if navigation throttles are enabled.  The navigation will be deferred until processNavigation is called.
        /// </summary>
        public void SubscribeToNavigationRequestedEvent(Action<NavigationRequestedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
    }
}