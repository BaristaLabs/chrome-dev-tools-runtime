namespace BaristaLabs.ChromeDevTools.Runtime.WebAudio
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Enum of BaseAudioContext types
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContextType
    {
        [EnumMember(Value = "realtime")]
        Realtime,
        [EnumMember(Value = "offline")]
        Offline,
    }
}