namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Unique object identifier.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RemoteObjectId
    {
    
    }
}