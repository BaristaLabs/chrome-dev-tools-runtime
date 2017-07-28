namespace BaristaLabs.ChromeDevTools.Runtime.IndexedDB
{
    using Newtonsoft.Json;

    /// <summary>
    /// Key path.
    /// </summary>
    public sealed class KeyPath
    {
        /// <summary>
        /// Key path type.
        ///</summary>
        [JsonProperty("type")]
        public string Type
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
        /// Array value.
        ///</summary>
        [JsonProperty("array", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string[] Array
        {
            get;
            set;
        }
    }
}