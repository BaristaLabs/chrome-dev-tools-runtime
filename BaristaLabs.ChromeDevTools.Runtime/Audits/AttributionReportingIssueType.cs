namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// AttributionReportingIssueType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AttributionReportingIssueType
    {
        [EnumMember(Value = "PermissionPolicyDisabled")]
        PermissionPolicyDisabled,
        [EnumMember(Value = "InvalidAttributionSourceEventId")]
        InvalidAttributionSourceEventId,
        [EnumMember(Value = "AttributionSourceUntrustworthyOrigin")]
        AttributionSourceUntrustworthyOrigin,
        [EnumMember(Value = "AttributionUntrustworthyOrigin")]
        AttributionUntrustworthyOrigin,
        [EnumMember(Value = "InvalidAttributionSourceExpiry")]
        InvalidAttributionSourceExpiry,
        [EnumMember(Value = "InvalidAttributionSourcePriority")]
        InvalidAttributionSourcePriority,
    }
}