namespace BaristaLabs.ChromeDevTools.Runtime.CacheStorage
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Unique identifier of the Cache object.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CacheId
    {
    
    }
}