namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// OriginTrialUsageRestriction
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OriginTrialUsageRestriction
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Subset")]
        Subset,
    }
}