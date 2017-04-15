namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    using Newtonsoft.Json;

    /// <summary>
    /// A single source for a computed AX property.
    /// </summary>
    public sealed class AXValueSource
    {
    
        /// <summary>
        /// What type of source this is.
        ///</summary>
        [JsonProperty("type")]
        public AXValueSourceType Type
        {
            get;
            set;
        }
    
        /// <summary>
        /// The value of this property source.
        ///</summary>
        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AXValue Value
        {
            get;
            set;
        }
    
        /// <summary>
        /// The name of the relevant attribute, if any.
        ///</summary>
        [JsonProperty("attribute", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Attribute
        {
            get;
            set;
        }
    
        /// <summary>
        /// The value of the relevant attribute, if any.
        ///</summary>
        [JsonProperty("attributeValue", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AXValue AttributeValue
        {
            get;
            set;
        }
    
        /// <summary>
        /// Whether this source is superseded by a higher priority source.
        ///</summary>
        [JsonProperty("superseded", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Superseded
        {
            get;
            set;
        }
    
        /// <summary>
        /// The native markup source for this value, e.g. a <label> element.
        ///</summary>
        [JsonProperty("nativeSource", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AXValueNativeSourceType? NativeSource
        {
            get;
            set;
        }
    
        /// <summary>
        /// The value, such as a node or node list, of the native source.
        ///</summary>
        [JsonProperty("nativeSourceValue", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AXValue NativeSourceValue
        {
            get;
            set;
        }
    
        /// <summary>
        /// Whether the value for this property is invalid.
        ///</summary>
        [JsonProperty("invalid", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Invalid
        {
            get;
            set;
        }
    
        /// <summary>
        /// Reason for the value being invalid, if it is.
        ///</summary>
        [JsonProperty("invalidReason", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string InvalidReason
        {
            get;
            set;
        }
    
    }
}