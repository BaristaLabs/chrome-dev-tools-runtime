namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// IPAddressSpace
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IPAddressSpace
    {
        [EnumMember(Value = "Local")]
        Local,
        [EnumMember(Value = "Private")]
        Private,
        [EnumMember(Value = "Public")]
        Public,
        [EnumMember(Value = "Unknown")]
        Unknown,
    }
}