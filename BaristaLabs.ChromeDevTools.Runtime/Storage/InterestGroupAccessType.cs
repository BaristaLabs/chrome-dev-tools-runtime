namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Enum of interest group access types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InterestGroupAccessType
    {
        [EnumMember(Value = "join")]
        Join,
        [EnumMember(Value = "leave")]
        Leave,
        [EnumMember(Value = "update")]
        Update,
        [EnumMember(Value = "bid")]
        Bid,
        [EnumMember(Value = "win")]
        Win,
    }
}