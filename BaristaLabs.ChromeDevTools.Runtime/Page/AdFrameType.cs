namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Indicates whether a frame has been identified as an ad.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AdFrameType
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "child")]
        Child,
        [EnumMember(Value = "root")]
        Root,
    }
}