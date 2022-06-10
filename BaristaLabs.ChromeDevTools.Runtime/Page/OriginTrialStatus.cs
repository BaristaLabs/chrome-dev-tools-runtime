namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Status for an Origin Trial.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OriginTrialStatus
    {
        [EnumMember(Value = "Enabled")]
        Enabled,
        [EnumMember(Value = "ValidTokenNotProvided")]
        ValidTokenNotProvided,
        [EnumMember(Value = "OSNotSupported")]
        OSNotSupported,
        [EnumMember(Value = "TrialNotAllowed")]
        TrialNotAllowed,
    }
}