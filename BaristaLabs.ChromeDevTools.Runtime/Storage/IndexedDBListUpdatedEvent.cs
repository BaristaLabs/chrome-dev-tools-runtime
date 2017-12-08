namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// The origin's IndexedDB database list has been modified.
    /// </summary>
    public sealed class IndexedDBListUpdatedEvent : IEvent
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