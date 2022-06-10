namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Types of not restored reasons for back-forward cache.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BackForwardCacheNotRestoredReasonType
    {
        [EnumMember(Value = "SupportPending")]
        SupportPending,
        [EnumMember(Value = "PageSupportNeeded")]
        PageSupportNeeded,
        [EnumMember(Value = "Circumstantial")]
        Circumstantial,
    }
}