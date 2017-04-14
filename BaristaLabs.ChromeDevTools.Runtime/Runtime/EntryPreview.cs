namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class EntryPreview
    {
    
        /// <summary>
        /// Preview of the key. Specified for map-like collection entries.
        ///</summary>
        [JsonProperty("key", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ObjectPreview Key
        {
            get;
            set;
        }
    
        /// <summary>
        /// Preview of the value.
        ///</summary>
        [JsonProperty("value")]
        public ObjectPreview Value
        {
            get;
            set;
        }
    
    }
}