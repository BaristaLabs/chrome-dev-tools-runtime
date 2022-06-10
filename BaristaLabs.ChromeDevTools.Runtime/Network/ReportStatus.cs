namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// The status of a Reporting API report.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReportStatus
    {
        [EnumMember(Value = "Queued")]
        Queued,
        [EnumMember(Value = "Pending")]
        Pending,
        [EnumMember(Value = "MarkedForRemoval")]
        MarkedForRemoval,
        [EnumMember(Value = "Success")]
        Success,
    }
}