namespace BaristaLabs.ChromeDevTools.Runtime.IndexedDB
{
    using Newtonsoft.Json;

    /// <summary>
    /// Key.
    /// </summary>
    public sealed class Key
    {
    
        /// <summary>
        /// Key type.
        ///</summary>
        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }
    
        /// <summary>
        /// Number value.
        ///</summary>
        [JsonProperty("number", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? Number
        {
            get;
            set;
        }
    
        /// <summary>
        /// String value.
        ///</summary>
        [JsonProperty("string", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string String
        {
            get;
            set;
        }
    
        /// <summary>
        /// Date value.
        ///</summary>
        [JsonProperty("date", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? Date
        {
            get;
            set;
        }
    
        /// <summary>
        /// Array value.
        ///</summary>
        [JsonProperty("array", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Key[] Array
        {
            get;
            set;
        }
    
    }
}