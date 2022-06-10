namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Source of serviceworker response.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ServiceWorkerResponseSource
    {
        [EnumMember(Value = "cache-storage")]
        CacheStorage,
        [EnumMember(Value = "http-cache")]
        HttpCache,
        [EnumMember(Value = "fallback-code")]
        FallbackCode,
        [EnumMember(Value = "network")]
        Network,
    }
}