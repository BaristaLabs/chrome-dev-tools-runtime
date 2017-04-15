namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Unique request identifier.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RequestId
    {
    
    }
}