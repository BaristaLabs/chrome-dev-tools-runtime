namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// The origin's IndexedDB object store has been modified.
    /// </summary>
    public sealed class IndexedDBContentUpdatedEvent : IEvent
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
        /// Database to update.
        /// </summary>
        [JsonProperty("databaseName")]
        public string DatabaseName
        {
            get;
            set;
        }
        /// <summary>
        /// ObjectStore to update.
        /// </summary>
        [JsonProperty("objectStoreName")]
        public string ObjectStoreName
        {
            get;
            set;
        }
    }
}