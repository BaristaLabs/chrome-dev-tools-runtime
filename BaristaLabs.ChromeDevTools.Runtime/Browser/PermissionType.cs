namespace BaristaLabs.ChromeDevTools.Runtime.Browser
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// PermissionType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PermissionType
    {
        [EnumMember(Value = "accessibilityEvents")]
        AccessibilityEvents,
        [EnumMember(Value = "audioCapture")]
        AudioCapture,
        [EnumMember(Value = "backgroundSync")]
        BackgroundSync,
        [EnumMember(Value = "backgroundFetch")]
        BackgroundFetch,
        [EnumMember(Value = "clipboardReadWrite")]
        ClipboardReadWrite,
        [EnumMember(Value = "clipboardSanitizedWrite")]
        ClipboardSanitizedWrite,
        [EnumMember(Value = "displayCapture")]
        DisplayCapture,
        [EnumMember(Value = "durableStorage")]
        DurableStorage,
        [EnumMember(Value = "flash")]
        Flash,
        [EnumMember(Value = "geolocation")]
        Geolocation,
        [EnumMember(Value = "midi")]
        Midi,
        [EnumMember(Value = "midiSysex")]
        MidiSysex,
        [EnumMember(Value = "nfc")]
        Nfc,
        [EnumMember(Value = "notifications")]
        Notifications,
        [EnumMember(Value = "paymentHandler")]
        PaymentHandler,
        [EnumMember(Value = "periodicBackgroundSync")]
        PeriodicBackgroundSync,
        [EnumMember(Value = "protectedMediaIdentifier")]
        ProtectedMediaIdentifier,
        [EnumMember(Value = "sensors")]
        Sensors,
        [EnumMember(Value = "videoCapture")]
        VideoCapture,
        [EnumMember(Value = "videoCapturePanTiltZoom")]
        VideoCapturePanTiltZoom,
        [EnumMember(Value = "idleDetection")]
        IdleDetection,
        [EnumMember(Value = "wakeLockScreen")]
        WakeLockScreen,
        [EnumMember(Value = "wakeLockSystem")]
        WakeLockSystem,
    }
}