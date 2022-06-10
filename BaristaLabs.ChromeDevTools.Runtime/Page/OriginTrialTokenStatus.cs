namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Origin Trial(https://www.chromium.org/blink/origin-trials) support.
    /// Status for an Origin Trial token.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OriginTrialTokenStatus
    {
        [EnumMember(Value = "Success")]
        Success,
        [EnumMember(Value = "NotSupported")]
        NotSupported,
        [EnumMember(Value = "Insecure")]
        Insecure,
        [EnumMember(Value = "Expired")]
        Expired,
        [EnumMember(Value = "WrongOrigin")]
        WrongOrigin,
        [EnumMember(Value = "InvalidSignature")]
        InvalidSignature,
        [EnumMember(Value = "Malformed")]
        Malformed,
        [EnumMember(Value = "WrongVersion")]
        WrongVersion,
        [EnumMember(Value = "FeatureDisabled")]
        FeatureDisabled,
        [EnumMember(Value = "TokenDisabled")]
        TokenDisabled,
        [EnumMember(Value = "FeatureDisabledForUser")]
        FeatureDisabledForUser,
        [EnumMember(Value = "UnknownTrial")]
        UnknownTrial,
    }
}