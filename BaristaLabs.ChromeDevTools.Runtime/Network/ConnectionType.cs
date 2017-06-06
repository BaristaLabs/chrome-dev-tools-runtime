namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Loading priority of a resource request.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConnectionType
    {
    
        [EnumMember(Value = "none")]
        None,
    
        [EnumMember(Value = "cellular2g")]
        Cellular2g,
    
        [EnumMember(Value = "cellular3g")]
        Cellular3g,
    
        [EnumMember(Value = "cellular4g")]
        Cellular4g,
    
        [EnumMember(Value = "bluetooth")]
        Bluetooth,
    
        [EnumMember(Value = "ethernet")]
        Ethernet,
    
        [EnumMember(Value = "wifi")]
        Wifi,
    
        [EnumMember(Value = "wimax")]
        Wimax,
    
        [EnumMember(Value = "other")]
        Other,
    
    }
}