namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// A cache has been added/deleted.
    /// </summary>
    public sealed class CacheStorageListUpdatedEvent : IEvent
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
    }
}