namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// ClientHintIssueReason
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ClientHintIssueReason
    {
        [EnumMember(Value = "MetaTagAllowListInvalidOrigin")]
        MetaTagAllowListInvalidOrigin,
        [EnumMember(Value = "MetaTagModifiedHTML")]
        MetaTagModifiedHTML,
    }
}