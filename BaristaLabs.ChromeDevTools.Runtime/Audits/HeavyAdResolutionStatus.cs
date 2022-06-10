namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// HeavyAdResolutionStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HeavyAdResolutionStatus
    {
        [EnumMember(Value = "HeavyAdBlocked")]
        HeavyAdBlocked,
        [EnumMember(Value = "HeavyAdWarning")]
        HeavyAdWarning,
    }
}