namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    using Newtonsoft.Json;

    /// <summary>
    /// A node in the accessibility tree.
    /// </summary>
    public sealed class AXNode
    {
        /// <summary>
        /// Unique identifier for this node.
        ///</summary>
        [JsonProperty("nodeId")]
        public string NodeId
        {
            get;
            set;
        }
        /// <summary>
        /// Whether this node is ignored for accessibility
        ///</summary>
        [JsonProperty("ignored")]
        public bool Ignored
        {
            get;
            set;
        }
        /// <summary>
        /// Collection of reasons why this node is hidden.
        ///</summary>
        [JsonProperty("ignoredReasons", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AXProperty[] IgnoredReasons
        {
            get;
            set;
        }
        /// <summary>
        /// This `Node`'s role, whether explicit or implicit.
        ///</summary>
        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AXValue Role
        {
            get;
            set;
        }
        /// <summary>
        /// The accessible name for this `Node`.
        ///</summary>
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AXValue Name
        {
            get;
            set;
        }
        /// <summary>
        /// The accessible description for this `Node`.
        ///</summary>
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AXValue Description
        {
            get;
            set;
        }
        /// <summary>
        /// The value for this `Node`.
        ///</summary>
        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AXValue Value
        {
            get;
            set;
        }
        /// <summary>
        /// All other properties
        ///</summary>
        [JsonProperty("properties", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AXProperty[] Properties
        {
            get;
            set;
        }
        /// <summary>
        /// ID for this node's parent.
        ///</summary>
        [JsonProperty("parentId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ParentId
        {
            get;
            set;
        }
        /// <summary>
        /// IDs for each of this node's child nodes.
        ///</summary>
        [JsonProperty("childIds", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string[] ChildIds
        {
            get;
            set;
        }
        /// <summary>
        /// The backend ID for the associated DOM node, if any.
        ///</summary>
        [JsonProperty("backendDOMNodeId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? BackendDOMNodeId
        {
            get;
            set;
        }
        /// <summary>
        /// The frame ID for the frame associated with this nodes document.
        ///</summary>
        [JsonProperty("frameId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FrameId
        {
            get;
            set;
        }
    }
}