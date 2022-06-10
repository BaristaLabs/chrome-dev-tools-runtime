namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// The reason why request was blocked.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BlockedReason
    {
        [EnumMember(Value = "other")]
        Other,
        [EnumMember(Value = "csp")]
        Csp,
        [EnumMember(Value = "mixed-content")]
        MixedContent,
        [EnumMember(Value = "origin")]
        Origin,
        [EnumMember(Value = "inspector")]
        Inspector,
        [EnumMember(Value = "subresource-filter")]
        SubresourceFilter,
        [EnumMember(Value = "content-type")]
        ContentType,
        [EnumMember(Value = "coep-frame-resource-needs-coep-header")]
        CoepFrameResourceNeedsCoepHeader,
        [EnumMember(Value = "coop-sandboxed-iframe-cannot-navigate-to-coop-page")]
        CoopSandboxedIframeCannotNavigateToCoopPage,
        [EnumMember(Value = "corp-not-same-origin")]
        CorpNotSameOrigin,
        [EnumMember(Value = "corp-not-same-origin-after-defaulted-to-same-origin-by-coep")]
        CorpNotSameOriginAfterDefaultedToSameOriginByCoep,
        [EnumMember(Value = "corp-not-same-site")]
        CorpNotSameSite,
    }
}