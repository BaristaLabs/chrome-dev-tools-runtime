namespace BaristaLabs.ChromeDevTools.Runtime.IndexedDB
{
    using Newtonsoft.Json;

    /// <summary>
    /// Database with an array of object stores.
    /// </summary>
    public sealed class DatabaseWithObjectStores
    {
        /// <summary>
        /// Database name.
        ///</summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// Database version.
        ///</summary>
        [JsonProperty("version")]
        public long Version
        {
            get;
            set;
        }
        /// <summary>
        /// Object stores in this database.
        ///</summary>
        [JsonProperty("objectStores")]
        public ObjectStore[] ObjectStores
        {
            get;
            set;
        }
    }
}