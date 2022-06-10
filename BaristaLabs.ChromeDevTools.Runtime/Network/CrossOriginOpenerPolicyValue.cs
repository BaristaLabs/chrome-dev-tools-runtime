namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// CrossOriginOpenerPolicyValue
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CrossOriginOpenerPolicyValue
    {
        [EnumMember(Value = "SameOrigin")]
        SameOrigin,
        [EnumMember(Value = "SameOriginAllowPopups")]
        SameOriginAllowPopups,
        [EnumMember(Value = "UnsafeNone")]
        UnsafeNone,
        [EnumMember(Value = "SameOriginPlusCoep")]
        SameOriginPlusCoep,
        [EnumMember(Value = "SameOriginAllowPopupsPlusCoep")]
        SameOriginAllowPopupsPlusCoep,
    }
}