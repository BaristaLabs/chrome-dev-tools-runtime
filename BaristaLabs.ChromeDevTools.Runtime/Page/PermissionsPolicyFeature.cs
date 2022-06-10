namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// All Permissions Policy features. This enum should match the one defined
    /// in third_party/blink/renderer/core/permissions_policy/permissions_policy_features.json5.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PermissionsPolicyFeature
    {
        [EnumMember(Value = "accelerometer")]
        Accelerometer,
        [EnumMember(Value = "ambient-light-sensor")]
        AmbientLightSensor,
        [EnumMember(Value = "attribution-reporting")]
        AttributionReporting,
        [EnumMember(Value = "autoplay")]
        Autoplay,
        [EnumMember(Value = "browsing-topics")]
        BrowsingTopics,
        [EnumMember(Value = "camera")]
        Camera,
        [EnumMember(Value = "ch-dpr")]
        ChDpr,
        [EnumMember(Value = "ch-device-memory")]
        ChDeviceMemory,
        [EnumMember(Value = "ch-downlink")]
        ChDownlink,
        [EnumMember(Value = "ch-ect")]
        ChEct,
        [EnumMember(Value = "ch-partitioned-cookies")]
        ChPartitionedCookies,
        [EnumMember(Value = "ch-prefers-color-scheme")]
        ChPrefersColorScheme,
        [EnumMember(Value = "ch-rtt")]
        ChRtt,
        [EnumMember(Value = "ch-save-data")]
        ChSaveData,
        [EnumMember(Value = "ch-ua")]
        ChUa,
        [EnumMember(Value = "ch-ua-arch")]
        ChUaArch,
        [EnumMember(Value = "ch-ua-bitness")]
        ChUaBitness,
        [EnumMember(Value = "ch-ua-platform")]
        ChUaPlatform,
        [EnumMember(Value = "ch-ua-model")]
        ChUaModel,
        [EnumMember(Value = "ch-ua-mobile")]
        ChUaMobile,
        [EnumMember(Value = "ch-ua-full")]
        ChUaFull,
        [EnumMember(Value = "ch-ua-full-version")]
        ChUaFullVersion,
        [EnumMember(Value = "ch-ua-full-version-list")]
        ChUaFullVersionList,
        [EnumMember(Value = "ch-ua-platform-version")]
        ChUaPlatformVersion,
        [EnumMember(Value = "ch-ua-reduced")]
        ChUaReduced,
        [EnumMember(Value = "ch-ua-wow64")]
        ChUaWow64,
        [EnumMember(Value = "ch-viewport-height")]
        ChViewportHeight,
        [EnumMember(Value = "ch-viewport-width")]
        ChViewportWidth,
        [EnumMember(Value = "ch-width")]
        ChWidth,
        [EnumMember(Value = "clipboard-read")]
        ClipboardRead,
        [EnumMember(Value = "clipboard-write")]
        ClipboardWrite,
        [EnumMember(Value = "cross-origin-isolated")]
        CrossOriginIsolated,
        [EnumMember(Value = "direct-sockets")]
        DirectSockets,
        [EnumMember(Value = "display-capture")]
        DisplayCapture,
        [EnumMember(Value = "document-domain")]
        DocumentDomain,
        [EnumMember(Value = "encrypted-media")]
        EncryptedMedia,
        [EnumMember(Value = "execution-while-out-of-viewport")]
        ExecutionWhileOutOfViewport,
        [EnumMember(Value = "execution-while-not-rendered")]
        ExecutionWhileNotRendered,
        [EnumMember(Value = "focus-without-user-activation")]
        FocusWithoutUserActivation,
        [EnumMember(Value = "fullscreen")]
        Fullscreen,
        [EnumMember(Value = "frobulate")]
        Frobulate,
        [EnumMember(Value = "gamepad")]
        Gamepad,
        [EnumMember(Value = "geolocation")]
        Geolocation,
        [EnumMember(Value = "gyroscope")]
        Gyroscope,
        [EnumMember(Value = "hid")]
        Hid,
        [EnumMember(Value = "idle-detection")]
        IdleDetection,
        [EnumMember(Value = "interest-cohort")]
        InterestCohort,
        [EnumMember(Value = "join-ad-interest-group")]
        JoinAdInterestGroup,
        [EnumMember(Value = "keyboard-map")]
        KeyboardMap,
        [EnumMember(Value = "magnetometer")]
        Magnetometer,
        [EnumMember(Value = "microphone")]
        Microphone,
        [EnumMember(Value = "midi")]
        Midi,
        [EnumMember(Value = "otp-credentials")]
        OtpCredentials,
        [EnumMember(Value = "payment")]
        Payment,
        [EnumMember(Value = "picture-in-picture")]
        PictureInPicture,
        [EnumMember(Value = "publickey-credentials-get")]
        PublickeyCredentialsGet,
        [EnumMember(Value = "run-ad-auction")]
        RunAdAuction,
        [EnumMember(Value = "screen-wake-lock")]
        ScreenWakeLock,
        [EnumMember(Value = "serial")]
        Serial,
        [EnumMember(Value = "shared-autofill")]
        SharedAutofill,
        [EnumMember(Value = "storage-access-api")]
        StorageAccessApi,
        [EnumMember(Value = "sync-xhr")]
        SyncXhr,
        [EnumMember(Value = "trust-token-redemption")]
        TrustTokenRedemption,
        [EnumMember(Value = "usb")]
        Usb,
        [EnumMember(Value = "vertical-scroll")]
        VerticalScroll,
        [EnumMember(Value = "web-share")]
        WebShare,
        [EnumMember(Value = "window-placement")]
        WindowPlacement,
        [EnumMember(Value = "xr-spatial-tracking")]
        XrSpatialTracking,
    }
}