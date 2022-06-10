namespace BaristaLabs.ChromeDevTools.Runtime.WebAudio
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Enum of AudioContextState from the spec
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContextState
    {
        [EnumMember(Value = "suspended")]
        Suspended,
        [EnumMember(Value = "running")]
        Running,
        [EnumMember(Value = "closed")]
        Closed,
    }
}