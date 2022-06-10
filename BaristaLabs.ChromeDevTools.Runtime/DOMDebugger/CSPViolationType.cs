namespace BaristaLabs.ChromeDevTools.Runtime.DOMDebugger
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// CSP Violation type.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CSPViolationType
    {
        [EnumMember(Value = "trustedtype-sink-violation")]
        TrustedtypeSinkViolation,
        [EnumMember(Value = "trustedtype-policy-violation")]
        TrustedtypePolicyViolation,
    }
}