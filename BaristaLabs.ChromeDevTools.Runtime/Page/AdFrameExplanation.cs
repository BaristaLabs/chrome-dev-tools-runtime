namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// AdFrameExplanation
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AdFrameExplanation
    {
        [EnumMember(Value = "ParentIsAd")]
        ParentIsAd,
        [EnumMember(Value = "CreatedByAdScript")]
        CreatedByAdScript,
        [EnumMember(Value = "MatchedBlockingRule")]
        MatchedBlockingRule,
    }
}