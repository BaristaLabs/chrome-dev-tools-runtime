namespace BaristaLabs.ChromeDevTools.Runtime.WebAudio
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Enum of AudioNode::ChannelCountMode from the spec
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ChannelCountMode
    {
        [EnumMember(Value = "clamped-max")]
        ClampedMax,
        [EnumMember(Value = "explicit")]
        Explicit,
        [EnumMember(Value = "max")]
        Max,
    }
}