namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    using Newtonsoft.Json;

    /// <summary>
    /// A single computed AX property.
    /// </summary>
    public sealed class AXValue
    {
        /// <summary>
        /// The type of this value.
        ///</summary>
        [JsonProperty("type")]
        public AXValueType Type
        {
            get;
            set;
        }
        /// <summary>
        /// The computed value of this property.
        ///</summary>
        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Value
        {
            get;
            set;
        }
        /// <summary>
        /// One or more related nodes, if applicable.
        ///</summary>
        [JsonProperty("relatedNodes", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AXRelatedNode[] RelatedNodes
        {
            get;
            set;
        }
        /// <summary>
        /// The sources which contributed to the computation of this property.
        ///</summary>
        [JsonProperty("sources", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AXValueSource[] Sources
        {
            get;
            set;
        }
    }
}