namespace BaristaLabs.ChromeDevTools.Runtime.Security
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// SafetyTipStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SafetyTipStatus
    {
        [EnumMember(Value = "badReputation")]
        BadReputation,
        [EnumMember(Value = "lookalike")]
        Lookalike,
    }
}