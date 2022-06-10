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
        /// Database version (type is not 'integer', as the standard
        /// requires the version number to be 'unsigned long long')
        ///</summary>
        [JsonProperty("version")]
        public double Version
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