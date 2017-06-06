namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class PropertyPreview
    {
    
        /// <summary>
        /// Property name.
        ///</summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
    
        /// <summary>
        /// Object type. Accessor means that the property itself is an accessor property.
        ///</summary>
        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }
    
        /// <summary>
        /// User-friendly property value string.
        ///</summary>
        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Value
        {
            get;
            set;
        }
    
        /// <summary>
        /// Nested value preview.
        ///</summary>
        [JsonProperty("valuePreview", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ObjectPreview ValuePreview
        {
            get;
            set;
        }
    
        /// <summary>
        /// Object subtype hint. Specified for <code>object</code> type values only.
        ///</summary>
        [JsonProperty("subtype", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Subtype
        {
            get;
            set;
        }
    
    }
}