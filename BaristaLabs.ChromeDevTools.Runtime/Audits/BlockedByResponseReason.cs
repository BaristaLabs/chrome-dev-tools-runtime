namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Enum indicating the reason a response has been blocked. These reasons are
    /// refinements of the net error BLOCKED_BY_RESPONSE.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BlockedByResponseReason
    {
        [EnumMember(Value = "CoepFrameResourceNeedsCoepHeader")]
        CoepFrameResourceNeedsCoepHeader,
        [EnumMember(Value = "CoopSandboxedIFrameCannotNavigateToCoopPage")]
        CoopSandboxedIFrameCannotNavigateToCoopPage,
        [EnumMember(Value = "CorpNotSameOrigin")]
        CorpNotSameOrigin,
        [EnumMember(Value = "CorpNotSameOriginAfterDefaultedToSameOriginByCoep")]
        CorpNotSameOriginAfterDefaultedToSameOriginByCoep,
        [EnumMember(Value = "CorpNotSameSite")]
        CorpNotSameSite,
    }
}