namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// TrustTokenOperationType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TrustTokenOperationType
    {
        [EnumMember(Value = "Issuance")]
        Issuance,
        [EnumMember(Value = "Redemption")]
        Redemption,
        [EnumMember(Value = "Signing")]
        Signing,
    }
}