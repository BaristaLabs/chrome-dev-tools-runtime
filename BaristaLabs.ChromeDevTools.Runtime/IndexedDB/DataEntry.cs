namespace BaristaLabs.ChromeDevTools.Runtime.IndexedDB
{
    using Newtonsoft.Json;

    /// <summary>
    /// Data entry.
    /// </summary>
    public sealed class DataEntry
    {
    
        /// <summary>
        /// Key object.
        ///</summary>
        [JsonProperty("key")]
        public Runtime.RemoteObject Key
        {
            get;
            set;
        }
    
        /// <summary>
        /// Primary key object.
        ///</summary>
        [JsonProperty("primaryKey")]
        public Runtime.RemoteObject PrimaryKey
        {
            get;
            set;
        }
    
        /// <summary>
        /// Value object.
        ///</summary>
        [JsonProperty("value")]
        public Runtime.RemoteObject Value
        {
            get;
            set;
        }
    
    }
}