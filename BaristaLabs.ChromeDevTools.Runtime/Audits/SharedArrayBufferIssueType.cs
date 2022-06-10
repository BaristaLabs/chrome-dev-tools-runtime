namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// SharedArrayBufferIssueType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SharedArrayBufferIssueType
    {
        [EnumMember(Value = "TransferIssue")]
        TransferIssue,
        [EnumMember(Value = "CreationIssue")]
        CreationIssue,
    }
}