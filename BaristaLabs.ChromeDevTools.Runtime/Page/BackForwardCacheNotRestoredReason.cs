namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// List of not restored reasons for back-forward cache.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BackForwardCacheNotRestoredReason
    {
        [EnumMember(Value = "NotPrimaryMainFrame")]
        NotPrimaryMainFrame,
        [EnumMember(Value = "BackForwardCacheDisabled")]
        BackForwardCacheDisabled,
        [EnumMember(Value = "RelatedActiveContentsExist")]
        RelatedActiveContentsExist,
        [EnumMember(Value = "HTTPStatusNotOK")]
        HTTPStatusNotOK,
        [EnumMember(Value = "SchemeNotHTTPOrHTTPS")]
        SchemeNotHTTPOrHTTPS,
        [EnumMember(Value = "Loading")]
        Loading,
        [EnumMember(Value = "WasGrantedMediaAccess")]
        WasGrantedMediaAccess,
        [EnumMember(Value = "DisableForRenderFrameHostCalled")]
        DisableForRenderFrameHostCalled,
        [EnumMember(Value = "DomainNotAllowed")]
        DomainNotAllowed,
        [EnumMember(Value = "HTTPMethodNotGET")]
        HTTPMethodNotGET,
        [EnumMember(Value = "SubframeIsNavigating")]
        SubframeIsNavigating,
        [EnumMember(Value = "Timeout")]
        Timeout,
        [EnumMember(Value = "CacheLimit")]
        CacheLimit,
        [EnumMember(Value = "JavaScriptExecution")]
        JavaScriptExecution,
        [EnumMember(Value = "RendererProcessKilled")]
        RendererProcessKilled,
        [EnumMember(Value = "RendererProcessCrashed")]
        RendererProcessCrashed,
        [EnumMember(Value = "GrantedMediaStreamAccess")]
        GrantedMediaStreamAccess,
        [EnumMember(Value = "SchedulerTrackedFeatureUsed")]
        SchedulerTrackedFeatureUsed,
        [EnumMember(Value = "ConflictingBrowsingInstance")]
        ConflictingBrowsingInstance,
        [EnumMember(Value = "CacheFlushed")]
        CacheFlushed,
        [EnumMember(Value = "ServiceWorkerVersionActivation")]
        ServiceWorkerVersionActivation,
        [EnumMember(Value = "SessionRestored")]
        SessionRestored,
        [EnumMember(Value = "ServiceWorkerPostMessage")]
        ServiceWorkerPostMessage,
        [EnumMember(Value = "EnteredBackForwardCacheBeforeServiceWorkerHostAdded")]
        EnteredBackForwardCacheBeforeServiceWorkerHostAdded,
        [EnumMember(Value = "RenderFrameHostReused_SameSite")]
        RenderframehostreusedSamesite,
        [EnumMember(Value = "RenderFrameHostReused_CrossSite")]
        RenderframehostreusedCrosssite,
        [EnumMember(Value = "ServiceWorkerClaim")]
        ServiceWorkerClaim,
        [EnumMember(Value = "IgnoreEventAndEvict")]
        IgnoreEventAndEvict,
        [EnumMember(Value = "HaveInnerContents")]
        HaveInnerContents,
        [EnumMember(Value = "TimeoutPuttingInCache")]
        TimeoutPuttingInCache,
        [EnumMember(Value = "BackForwardCacheDisabledByLowMemory")]
        BackForwardCacheDisabledByLowMemory,
        [EnumMember(Value = "BackForwardCacheDisabledByCommandLine")]
        BackForwardCacheDisabledByCommandLine,
        [EnumMember(Value = "NetworkRequestDatapipeDrainedAsBytesConsumer")]
        NetworkRequestDatapipeDrainedAsBytesConsumer,
        [EnumMember(Value = "NetworkRequestRedirected")]
        NetworkRequestRedirected,
        [EnumMember(Value = "NetworkRequestTimeout")]
        NetworkRequestTimeout,
        [EnumMember(Value = "NetworkExceedsBufferLimit")]
        NetworkExceedsBufferLimit,
        [EnumMember(Value = "NavigationCancelledWhileRestoring")]
        NavigationCancelledWhileRestoring,
        [EnumMember(Value = "NotMostRecentNavigationEntry")]
        NotMostRecentNavigationEntry,
        [EnumMember(Value = "BackForwardCacheDisabledForPrerender")]
        BackForwardCacheDisabledForPrerender,
        [EnumMember(Value = "UserAgentOverrideDiffers")]
        UserAgentOverrideDiffers,
        [EnumMember(Value = "ForegroundCacheLimit")]
        ForegroundCacheLimit,
        [EnumMember(Value = "BrowsingInstanceNotSwapped")]
        BrowsingInstanceNotSwapped,
        [EnumMember(Value = "BackForwardCacheDisabledForDelegate")]
        BackForwardCacheDisabledForDelegate,
        [EnumMember(Value = "OptInUnloadHeaderNotPresent")]
        OptInUnloadHeaderNotPresent,
        [EnumMember(Value = "UnloadHandlerExistsInMainFrame")]
        UnloadHandlerExistsInMainFrame,
        [EnumMember(Value = "UnloadHandlerExistsInSubFrame")]
        UnloadHandlerExistsInSubFrame,
        [EnumMember(Value = "ServiceWorkerUnregistration")]
        ServiceWorkerUnregistration,
        [EnumMember(Value = "CacheControlNoStore")]
        CacheControlNoStore,
        [EnumMember(Value = "CacheControlNoStoreCookieModified")]
        CacheControlNoStoreCookieModified,
        [EnumMember(Value = "CacheControlNoStoreHTTPOnlyCookieModified")]
        CacheControlNoStoreHTTPOnlyCookieModified,
        [EnumMember(Value = "NoResponseHead")]
        NoResponseHead,
        [EnumMember(Value = "Unknown")]
        Unknown,
        [EnumMember(Value = "ActivationNavigationsDisallowedForBug1234857")]
        ActivationNavigationsDisallowedForBug1234857,
        [EnumMember(Value = "ErrorDocument")]
        ErrorDocument,
        [EnumMember(Value = "FencedFramesEmbedder")]
        FencedFramesEmbedder,
        [EnumMember(Value = "WebSocket")]
        WebSocket,
        [EnumMember(Value = "WebTransport")]
        WebTransport,
        [EnumMember(Value = "WebRTC")]
        WebRTC,
        [EnumMember(Value = "MainResourceHasCacheControlNoStore")]
        MainResourceHasCacheControlNoStore,
        [EnumMember(Value = "MainResourceHasCacheControlNoCache")]
        MainResourceHasCacheControlNoCache,
        [EnumMember(Value = "SubresourceHasCacheControlNoStore")]
        SubresourceHasCacheControlNoStore,
        [EnumMember(Value = "SubresourceHasCacheControlNoCache")]
        SubresourceHasCacheControlNoCache,
        [EnumMember(Value = "ContainsPlugins")]
        ContainsPlugins,
        [EnumMember(Value = "DocumentLoaded")]
        DocumentLoaded,
        [EnumMember(Value = "DedicatedWorkerOrWorklet")]
        DedicatedWorkerOrWorklet,
        [EnumMember(Value = "OutstandingNetworkRequestOthers")]
        OutstandingNetworkRequestOthers,
        [EnumMember(Value = "OutstandingIndexedDBTransaction")]
        OutstandingIndexedDBTransaction,
        [EnumMember(Value = "RequestedNotificationsPermission")]
        RequestedNotificationsPermission,
        [EnumMember(Value = "RequestedMIDIPermission")]
        RequestedMIDIPermission,
        [EnumMember(Value = "RequestedAudioCapturePermission")]
        RequestedAudioCapturePermission,
        [EnumMember(Value = "RequestedVideoCapturePermission")]
        RequestedVideoCapturePermission,
        [EnumMember(Value = "RequestedBackForwardCacheBlockedSensors")]
        RequestedBackForwardCacheBlockedSensors,
        [EnumMember(Value = "RequestedBackgroundWorkPermission")]
        RequestedBackgroundWorkPermission,
        [EnumMember(Value = "BroadcastChannel")]
        BroadcastChannel,
        [EnumMember(Value = "IndexedDBConnection")]
        IndexedDBConnection,
        [EnumMember(Value = "WebXR")]
        WebXR,
        [EnumMember(Value = "SharedWorker")]
        SharedWorker,
        [EnumMember(Value = "WebLocks")]
        WebLocks,
        [EnumMember(Value = "WebHID")]
        WebHID,
        [EnumMember(Value = "WebShare")]
        WebShare,
        [EnumMember(Value = "RequestedStorageAccessGrant")]
        RequestedStorageAccessGrant,
        [EnumMember(Value = "WebNfc")]
        WebNfc,
        [EnumMember(Value = "OutstandingNetworkRequestFetch")]
        OutstandingNetworkRequestFetch,
        [EnumMember(Value = "OutstandingNetworkRequestXHR")]
        OutstandingNetworkRequestXHR,
        [EnumMember(Value = "AppBanner")]
        AppBanner,
        [EnumMember(Value = "Printing")]
        Printing,
        [EnumMember(Value = "WebDatabase")]
        WebDatabase,
        [EnumMember(Value = "PictureInPicture")]
        PictureInPicture,
        [EnumMember(Value = "Portal")]
        Portal,
        [EnumMember(Value = "SpeechRecognizer")]
        SpeechRecognizer,
        [EnumMember(Value = "IdleManager")]
        IdleManager,
        [EnumMember(Value = "PaymentManager")]
        PaymentManager,
        [EnumMember(Value = "SpeechSynthesis")]
        SpeechSynthesis,
        [EnumMember(Value = "KeyboardLock")]
        KeyboardLock,
        [EnumMember(Value = "WebOTPService")]
        WebOTPService,
        [EnumMember(Value = "OutstandingNetworkRequestDirectSocket")]
        OutstandingNetworkRequestDirectSocket,
        [EnumMember(Value = "InjectedJavascript")]
        InjectedJavascript,
        [EnumMember(Value = "InjectedStyleSheet")]
        InjectedStyleSheet,
        [EnumMember(Value = "Dummy")]
        Dummy,
        [EnumMember(Value = "ContentSecurityHandler")]
        ContentSecurityHandler,
        [EnumMember(Value = "ContentWebAuthenticationAPI")]
        ContentWebAuthenticationAPI,
        [EnumMember(Value = "ContentFileChooser")]
        ContentFileChooser,
        [EnumMember(Value = "ContentSerial")]
        ContentSerial,
        [EnumMember(Value = "ContentFileSystemAccess")]
        ContentFileSystemAccess,
        [EnumMember(Value = "ContentMediaDevicesDispatcherHost")]
        ContentMediaDevicesDispatcherHost,
        [EnumMember(Value = "ContentWebBluetooth")]
        ContentWebBluetooth,
        [EnumMember(Value = "ContentWebUSB")]
        ContentWebUSB,
        [EnumMember(Value = "ContentMediaSession")]
        ContentMediaSession,
        [EnumMember(Value = "ContentMediaSessionService")]
        ContentMediaSessionService,
        [EnumMember(Value = "ContentScreenReader")]
        ContentScreenReader,
        [EnumMember(Value = "EmbedderPopupBlockerTabHelper")]
        EmbedderPopupBlockerTabHelper,
        [EnumMember(Value = "EmbedderSafeBrowsingTriggeredPopupBlocker")]
        EmbedderSafeBrowsingTriggeredPopupBlocker,
        [EnumMember(Value = "EmbedderSafeBrowsingThreatDetails")]
        EmbedderSafeBrowsingThreatDetails,
        [EnumMember(Value = "EmbedderAppBannerManager")]
        EmbedderAppBannerManager,
        [EnumMember(Value = "EmbedderDomDistillerViewerSource")]
        EmbedderDomDistillerViewerSource,
        [EnumMember(Value = "EmbedderDomDistillerSelfDeletingRequestDelegate")]
        EmbedderDomDistillerSelfDeletingRequestDelegate,
        [EnumMember(Value = "EmbedderOomInterventionTabHelper")]
        EmbedderOomInterventionTabHelper,
        [EnumMember(Value = "EmbedderOfflinePage")]
        EmbedderOfflinePage,
        [EnumMember(Value = "EmbedderChromePasswordManagerClientBindCredentialManager")]
        EmbedderChromePasswordManagerClientBindCredentialManager,
        [EnumMember(Value = "EmbedderPermissionRequestManager")]
        EmbedderPermissionRequestManager,
        [EnumMember(Value = "EmbedderModalDialog")]
        EmbedderModalDialog,
        [EnumMember(Value = "EmbedderExtensions")]
        EmbedderExtensions,
        [EnumMember(Value = "EmbedderExtensionMessaging")]
        EmbedderExtensionMessaging,
        [EnumMember(Value = "EmbedderExtensionMessagingForOpenPort")]
        EmbedderExtensionMessagingForOpenPort,
        [EnumMember(Value = "EmbedderExtensionSentMessageToCachedFrame")]
        EmbedderExtensionSentMessageToCachedFrame,
    }
}