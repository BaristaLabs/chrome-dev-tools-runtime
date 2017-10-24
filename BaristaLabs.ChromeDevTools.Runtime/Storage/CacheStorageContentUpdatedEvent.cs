namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// A cache's contents have been modified.
    /// </summary>
    public sealed class CacheStorageContentUpdatedEvent : IEvent
    {
        /// <summary>
        /// Origin to update.
        /// </summary>
        [JsonProperty("origin")]
        public string Origin
        {
            get;
            set;
        }
        /// <summary>
        /// Name of cache in origin.
        /// </summary>
        [JsonProperty("cacheName")]
        public string CacheName
        {
            get;
            set;
        }
    }
}