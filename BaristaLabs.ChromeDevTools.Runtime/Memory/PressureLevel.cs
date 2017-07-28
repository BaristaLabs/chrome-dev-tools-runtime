namespace BaristaLabs.ChromeDevTools.Runtime.Memory
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Memory pressure level.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PressureLevel
    {
        [EnumMember(Value = "moderate")]
        Moderate,
        [EnumMember(Value = "critical")]
        Critical,
    }
}