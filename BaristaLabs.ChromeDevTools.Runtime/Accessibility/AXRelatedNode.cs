namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class AXRelatedNode
    {
        /// <summary>
        /// The BackendNodeId of the related DOM node.
        ///</summary>
        [JsonProperty("backendDOMNodeId")]
        public long BackendDOMNodeId
        {
            get;
            set;
        }
        /// <summary>
        /// The IDRef value provided, if any.
        ///</summary>
        [JsonProperty("idref", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Idref
        {
            get;
            set;
        }
        /// <summary>
        /// The text alternative of this node in the current context.
        ///</summary>
        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Text
        {
            get;
            set;
        }
    }
}