namespace BaristaLabs.ChromeDevTools.Runtime.WebAudio
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Enum of AudioNode::ChannelInterpretation from the spec
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ChannelInterpretation
    {
        [EnumMember(Value = "discrete")]
        Discrete,
        [EnumMember(Value = "speakers")]
        Speakers,
    }
}