namespace BaristaLabs.ChromeDevTools.Runtime.IndexedDB
{
    using Newtonsoft.Json;

    /// <summary>
    /// Object store index.
    /// </summary>
    public sealed class ObjectStoreIndex
    {
        /// <summary>
        /// Index name.
        ///</summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// Index key path.
        ///</summary>
        [JsonProperty("keyPath")]
        public KeyPath KeyPath
        {
            get;
            set;
        }
        /// <summary>
        /// If true, index is unique.
        ///</summary>
        [JsonProperty("unique")]
        public bool Unique
        {
            get;
            set;
        }
        /// <summary>
        /// If true, index allows multiple entries for a key.
        ///</summary>
        [JsonProperty("multiEntry")]
        public bool MultiEntry
        {
            get;
            set;
        }
    }
}