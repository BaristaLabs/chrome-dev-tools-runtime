namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// TwaQualityEnforcementViolationType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TwaQualityEnforcementViolationType
    {
        [EnumMember(Value = "kHttpError")]
        KHttpError,
        [EnumMember(Value = "kUnavailableOffline")]
        KUnavailableOffline,
        [EnumMember(Value = "kDigitalAssetLinks")]
        KDigitalAssetLinks,
    }
}