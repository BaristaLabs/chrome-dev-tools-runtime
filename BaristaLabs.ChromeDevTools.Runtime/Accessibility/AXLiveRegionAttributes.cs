namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Attributes which apply to nodes in live regions.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AXLiveRegionAttributes
    {
        [EnumMember(Value = "live")]
        Live,
        [EnumMember(Value = "atomic")]
        Atomic,
        [EnumMember(Value = "relevant")]
        Relevant,
        [EnumMember(Value = "busy")]
        Busy,
        [EnumMember(Value = "root")]
        Root,
    }
}