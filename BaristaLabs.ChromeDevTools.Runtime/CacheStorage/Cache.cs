namespace BaristaLabs.ChromeDevTools.Runtime.CacheStorage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Cache identifier.
    /// </summary>
    public sealed class Cache
    {
        /// <summary>
        /// An opaque unique id of the cache.
        ///</summary>
        [JsonProperty("cacheId")]
        public string CacheId
        {
            get;
            set;
        }
        /// <summary>
        /// Security origin of the cache.
        ///</summary>
        [JsonProperty("securityOrigin")]
        public string SecurityOrigin
        {
            get;
            set;
        }
        /// <summary>
        /// The name of the cache.
        ///</summary>
        [JsonProperty("cacheName")]
        public string CacheName
        {
            get;
            set;
        }
    }
}