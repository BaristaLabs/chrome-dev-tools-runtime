namespace BaristaLabs.ChromeDevTools.Runtime.LayerTree
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Unique Layer identifier.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LayerId
    {
    
    }
}