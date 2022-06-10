namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// MixedContentResourceType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MixedContentResourceType
    {
        [EnumMember(Value = "AttributionSrc")]
        AttributionSrc,
        [EnumMember(Value = "Audio")]
        Audio,
        [EnumMember(Value = "Beacon")]
        Beacon,
        [EnumMember(Value = "CSPReport")]
        CSPReport,
        [EnumMember(Value = "Download")]
        Download,
        [EnumMember(Value = "EventSource")]
        EventSource,
        [EnumMember(Value = "Favicon")]
        Favicon,
        [EnumMember(Value = "Font")]
        Font,
        [EnumMember(Value = "Form")]
        Form,
        [EnumMember(Value = "Frame")]
        Frame,
        [EnumMember(Value = "Image")]
        Image,
        [EnumMember(Value = "Import")]
        Import,
        [EnumMember(Value = "Manifest")]
        Manifest,
        [EnumMember(Value = "Ping")]
        Ping,
        [EnumMember(Value = "PluginData")]
        PluginData,
        [EnumMember(Value = "PluginResource")]
        PluginResource,
        [EnumMember(Value = "Prefetch")]
        Prefetch,
        [EnumMember(Value = "Resource")]
        Resource,
        [EnumMember(Value = "Script")]
        Script,
        [EnumMember(Value = "ServiceWorker")]
        ServiceWorker,
        [EnumMember(Value = "SharedWorker")]
        SharedWorker,
        [EnumMember(Value = "Stylesheet")]
        Stylesheet,
        [EnumMember(Value = "Track")]
        Track,
        [EnumMember(Value = "Video")]
        Video,
        [EnumMember(Value = "Worker")]
        Worker,
        [EnumMember(Value = "XMLHttpRequest")]
        XMLHttpRequest,
        [EnumMember(Value = "XSLT")]
        XSLT,
    }
}