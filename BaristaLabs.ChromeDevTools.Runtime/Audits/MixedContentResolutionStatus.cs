namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// MixedContentResolutionStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MixedContentResolutionStatus
    {
        [EnumMember(Value = "MixedContentBlocked")]
        MixedContentBlocked,
        [EnumMember(Value = "MixedContentAutomaticallyUpgraded")]
        MixedContentAutomaticallyUpgraded,
        [EnumMember(Value = "MixedContentWarning")]
        MixedContentWarning,
    }
}