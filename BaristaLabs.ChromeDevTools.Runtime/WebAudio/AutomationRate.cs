namespace BaristaLabs.ChromeDevTools.Runtime.WebAudio
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Enum of AudioParam::AutomationRate from the spec
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AutomationRate
    {
        [EnumMember(Value = "a-rate")]
        ARate,
        [EnumMember(Value = "k-rate")]
        KRate,
    }
}