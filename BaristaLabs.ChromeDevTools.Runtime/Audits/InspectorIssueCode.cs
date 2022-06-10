namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// A unique identifier for the type of issue. Each type may use one of the
    /// optional fields in InspectorIssueDetails to convey more specific
    /// information about the kind of issue.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InspectorIssueCode
    {
        [EnumMember(Value = "CookieIssue")]
        CookieIssue,
        [EnumMember(Value = "MixedContentIssue")]
        MixedContentIssue,
        [EnumMember(Value = "BlockedByResponseIssue")]
        BlockedByResponseIssue,
        [EnumMember(Value = "HeavyAdIssue")]
        HeavyAdIssue,
        [EnumMember(Value = "ContentSecurityPolicyIssue")]
        ContentSecurityPolicyIssue,
        [EnumMember(Value = "SharedArrayBufferIssue")]
        SharedArrayBufferIssue,
        [EnumMember(Value = "TrustedWebActivityIssue")]
        TrustedWebActivityIssue,
        [EnumMember(Value = "LowTextContrastIssue")]
        LowTextContrastIssue,
        [EnumMember(Value = "CorsIssue")]
        CorsIssue,
        [EnumMember(Value = "AttributionReportingIssue")]
        AttributionReportingIssue,
        [EnumMember(Value = "QuirksModeIssue")]
        QuirksModeIssue,
        [EnumMember(Value = "NavigatorUserAgentIssue")]
        NavigatorUserAgentIssue,
        [EnumMember(Value = "GenericIssue")]
        GenericIssue,
        [EnumMember(Value = "DeprecationIssue")]
        DeprecationIssue,
        [EnumMember(Value = "ClientHintIssue")]
        ClientHintIssue,
        [EnumMember(Value = "FederatedAuthRequestIssue")]
        FederatedAuthRequestIssue,
    }
}