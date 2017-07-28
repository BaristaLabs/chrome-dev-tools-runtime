namespace BaristaLabs.ChromeDevTools.Runtime.IndexedDB
{
    using Newtonsoft.Json;

    /// <summary>
    /// Object store.
    /// </summary>
    public sealed class ObjectStore
    {
        /// <summary>
        /// Object store name.
        ///</summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// Object store key path.
        ///</summary>
        [JsonProperty("keyPath")]
        public KeyPath KeyPath
        {
            get;
            set;
        }
        /// <summary>
        /// If true, object store has auto increment flag set.
        ///</summary>
        [JsonProperty("autoIncrement")]
        public bool AutoIncrement
        {
            get;
            set;
        }
        /// <summary>
        /// Indexes in this object store.
        ///</summary>
        [JsonProperty("indexes")]
        public ObjectStoreIndex[] Indexes
        {
            get;
            set;
        }
    }
}