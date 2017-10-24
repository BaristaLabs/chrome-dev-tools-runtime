namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using System;
    using System.Threading;
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
        public async Task<EnableCommandResponse> Enable(EnableCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command ?? new EnableCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Disables page domain notifications.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command ?? new DisableCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Deprecated, please use addScriptToEvaluateOnNewDocument instead.
        /// </summary>
        public async Task<AddScriptToEvaluateOnLoadCommandResponse> AddScriptToEvaluateOnLoad(AddScriptToEvaluateOnLoadCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<AddScriptToEvaluateOnLoadCommand, AddScriptToEvaluateOnLoadCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Deprecated, please use removeScriptToEvaluateOnNewDocument instead.
        /// </summary>
        public async Task<RemoveScriptToEvaluateOnLoadCommandResponse> RemoveScriptToEvaluateOnLoad(RemoveScriptToEvaluateOnLoadCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<RemoveScriptToEvaluateOnLoadCommand, RemoveScriptToEvaluateOnLoadCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Evaluates given script in every frame upon creation (before loading frame's scripts).
        /// </summary>
        public async Task<AddScriptToEvaluateOnNewDocumentCommandResponse> AddScriptToEvaluateOnNewDocument(AddScriptToEvaluateOnNewDocumentCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<AddScriptToEvaluateOnNewDocumentCommand, AddScriptToEvaluateOnNewDocumentCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Removes given script from the list.
        /// </summary>
        public async Task<RemoveScriptToEvaluateOnNewDocumentCommandResponse> RemoveScriptToEvaluateOnNewDocument(RemoveScriptToEvaluateOnNewDocumentCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<RemoveScriptToEvaluateOnNewDocumentCommand, RemoveScriptToEvaluateOnNewDocumentCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Controls whether browser will open a new inspector window for connected pages.
        /// </summary>
        public async Task<SetAutoAttachToCreatedPagesCommandResponse> SetAutoAttachToCreatedPages(SetAutoAttachToCreatedPagesCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetAutoAttachToCreatedPagesCommand, SetAutoAttachToCreatedPagesCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Reloads given page optionally ignoring the cache.
        /// </summary>
        public async Task<ReloadCommandResponse> Reload(ReloadCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ReloadCommand, ReloadCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Enable Chrome's experimental ad filter on all sites.
        /// </summary>
        public async Task<SetAdBlockingEnabledCommandResponse> SetAdBlockingEnabled(SetAdBlockingEnabledCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetAdBlockingEnabledCommand, SetAdBlockingEnabledCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Navigates current page to the given URL.
        /// </summary>
        public async Task<NavigateCommandResponse> Navigate(NavigateCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<NavigateCommand, NavigateCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Force the page stop all navigations and pending resource fetches.
        /// </summary>
        public async Task<StopLoadingCommandResponse> StopLoading(StopLoadingCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<StopLoadingCommand, StopLoadingCommandResponse>(command ?? new StopLoadingCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns navigation history for the current page.
        /// </summary>
        public async Task<GetNavigationHistoryCommandResponse> GetNavigationHistory(GetNavigationHistoryCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetNavigationHistoryCommand, GetNavigationHistoryCommandResponse>(command ?? new GetNavigationHistoryCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Navigates current page to the given history entry.
        /// </summary>
        public async Task<NavigateToHistoryEntryCommandResponse> NavigateToHistoryEntry(NavigateToHistoryEntryCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<NavigateToHistoryEntryCommand, NavigateToHistoryEntryCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns all browser cookies. Depending on the backend support, will return detailed cookie information in the &lt;code&gt;cookies&lt;/code&gt; field.
        /// </summary>
        public async Task<GetCookiesCommandResponse> GetCookies(GetCookiesCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetCookiesCommand, GetCookiesCommandResponse>(command ?? new GetCookiesCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Deletes browser cookie with given name, domain and path.
        /// </summary>
        public async Task<DeleteCookieCommandResponse> DeleteCookie(DeleteCookieCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DeleteCookieCommand, DeleteCookieCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns present frame / resource tree structure.
        /// </summary>
        public async Task<GetResourceTreeCommandResponse> GetResourceTree(GetResourceTreeCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetResourceTreeCommand, GetResourceTreeCommandResponse>(command ?? new GetResourceTreeCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns content of the given resource.
        /// </summary>
        public async Task<GetResourceContentCommandResponse> GetResourceContent(GetResourceContentCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetResourceContentCommand, GetResourceContentCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Searches for given string in resource content.
        /// </summary>
        public async Task<SearchInResourceCommandResponse> SearchInResource(SearchInResourceCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SearchInResourceCommand, SearchInResourceCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Sets given markup as the document's HTML.
        /// </summary>
        public async Task<SetDocumentContentCommandResponse> SetDocumentContent(SetDocumentContentCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetDocumentContentCommand, SetDocumentContentCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Overrides the values of device screen dimensions (window.screen.width, window.screen.height, window.innerWidth, window.innerHeight, and &quot;device-width&quot;/&quot;device-height&quot;-related CSS media query results).
        /// </summary>
        public async Task<SetDeviceMetricsOverrideCommandResponse> SetDeviceMetricsOverride(SetDeviceMetricsOverrideCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetDeviceMetricsOverrideCommand, SetDeviceMetricsOverrideCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Clears the overriden device metrics.
        /// </summary>
        public async Task<ClearDeviceMetricsOverrideCommandResponse> ClearDeviceMetricsOverride(ClearDeviceMetricsOverrideCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ClearDeviceMetricsOverrideCommand, ClearDeviceMetricsOverrideCommandResponse>(command ?? new ClearDeviceMetricsOverrideCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Overrides the Geolocation Position or Error. Omitting any of the parameters emulates position unavailable.
        /// </summary>
        public async Task<SetGeolocationOverrideCommandResponse> SetGeolocationOverride(SetGeolocationOverrideCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetGeolocationOverrideCommand, SetGeolocationOverrideCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Clears the overriden Geolocation Position and Error.
        /// </summary>
        public async Task<ClearGeolocationOverrideCommandResponse> ClearGeolocationOverride(ClearGeolocationOverrideCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ClearGeolocationOverrideCommand, ClearGeolocationOverrideCommandResponse>(command ?? new ClearGeolocationOverrideCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Overrides the Device Orientation.
        /// </summary>
        public async Task<SetDeviceOrientationOverrideCommandResponse> SetDeviceOrientationOverride(SetDeviceOrientationOverrideCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetDeviceOrientationOverrideCommand, SetDeviceOrientationOverrideCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Clears the overridden Device Orientation.
        /// </summary>
        public async Task<ClearDeviceOrientationOverrideCommandResponse> ClearDeviceOrientationOverride(ClearDeviceOrientationOverrideCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ClearDeviceOrientationOverrideCommand, ClearDeviceOrientationOverrideCommandResponse>(command ?? new ClearDeviceOrientationOverrideCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Toggles mouse event-based touch event emulation.
        /// </summary>
        public async Task<SetTouchEmulationEnabledCommandResponse> SetTouchEmulationEnabled(SetTouchEmulationEnabledCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetTouchEmulationEnabledCommand, SetTouchEmulationEnabledCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Capture page screenshot.
        /// </summary>
        public async Task<CaptureScreenshotCommandResponse> CaptureScreenshot(CaptureScreenshotCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<CaptureScreenshotCommand, CaptureScreenshotCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Print page as PDF.
        /// </summary>
        public async Task<PrintToPDFCommandResponse> PrintToPDF(PrintToPDFCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<PrintToPDFCommand, PrintToPDFCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Starts sending each frame using the &lt;code&gt;screencastFrame&lt;/code&gt; event.
        /// </summary>
        public async Task<StartScreencastCommandResponse> StartScreencast(StartScreencastCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<StartScreencastCommand, StartScreencastCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Stops sending each frame in the &lt;code&gt;screencastFrame&lt;/code&gt;.
        /// </summary>
        public async Task<StopScreencastCommandResponse> StopScreencast(StopScreencastCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<StopScreencastCommand, StopScreencastCommandResponse>(command ?? new StopScreencastCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Acknowledges that a screencast frame has been received by the frontend.
        /// </summary>
        public async Task<ScreencastFrameAckCommandResponse> ScreencastFrameAck(ScreencastFrameAckCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ScreencastFrameAckCommand, ScreencastFrameAckCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Accepts or dismisses a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload).
        /// </summary>
        public async Task<HandleJavaScriptDialogCommandResponse> HandleJavaScriptDialog(HandleJavaScriptDialogCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<HandleJavaScriptDialogCommand, HandleJavaScriptDialogCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// 
        /// </summary>
        public async Task<GetAppManifestCommandResponse> GetAppManifest(GetAppManifestCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetAppManifestCommand, GetAppManifestCommandResponse>(command ?? new GetAppManifestCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// 
        /// </summary>
        public async Task<RequestAppBannerCommandResponse> RequestAppBanner(RequestAppBannerCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<RequestAppBannerCommand, RequestAppBannerCommandResponse>(command ?? new RequestAppBannerCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns metrics relating to the layouting of the page, such as viewport bounds/scale.
        /// </summary>
        public async Task<GetLayoutMetricsCommandResponse> GetLayoutMetrics(GetLayoutMetricsCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetLayoutMetricsCommand, GetLayoutMetricsCommandResponse>(command ?? new GetLayoutMetricsCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Creates an isolated world for the given frame.
        /// </summary>
        public async Task<CreateIsolatedWorldCommandResponse> CreateIsolatedWorld(CreateIsolatedWorldCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<CreateIsolatedWorldCommand, CreateIsolatedWorldCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Brings page to front (activates tab).
        /// </summary>
        public async Task<BringToFrontCommandResponse> BringToFront(BringToFrontCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<BringToFrontCommand, BringToFrontCommandResponse>(command ?? new BringToFrontCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Set the behavior when downloading a file.
        /// </summary>
        public async Task<SetDownloadBehaviorCommandResponse> SetDownloadBehavior(SetDownloadBehaviorCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetDownloadBehaviorCommand, SetDownloadBehaviorCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
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
        /// Fired for top level page lifecycle events such as navigation, load, paint, etc.
        /// </summary>
        public void SubscribeToLifecycleEventEvent(Action<LifecycleEventEvent> eventCallback)
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
        /// Compressed image data requested by the &lt;code&gt;startScreencast&lt;/code&gt;.
        /// </summary>
        public void SubscribeToScreencastFrameEvent(Action<ScreencastFrameEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired when the page with currently enabled screencast was shown or hidden &lt;/code&gt;.
        /// </summary>
        public void SubscribeToScreencastVisibilityChangedEvent(Action<ScreencastVisibilityChangedEvent> eventCallback)
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
    }
}