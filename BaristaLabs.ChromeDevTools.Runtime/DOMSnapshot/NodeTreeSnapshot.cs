namespace BaristaLabs.ChromeDevTools.Runtime.DOMSnapshot
{
    using Newtonsoft.Json;

    /// <summary>
    /// Table containing nodes.
    /// </summary>
    public sealed class NodeTreeSnapshot
    {
        /// <summary>
        /// Parent node index.
        ///</summary>
        [JsonProperty("parentIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long[] ParentIndex
        {
            get;
            set;
        }
        /// <summary>
        /// `Node`'s nodeType.
        ///</summary>
        [JsonProperty("nodeType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long[] NodeType
        {
            get;
            set;
        }
        /// <summary>
        /// Type of the shadow root the `Node` is in. String values are equal to the `ShadowRootType` enum.
        ///</summary>
        [JsonProperty("shadowRootType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public RareStringData ShadowRootType
        {
            get;
            set;
        }
        /// <summary>
        /// `Node`'s nodeName.
        ///</summary>
        [JsonProperty("nodeName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long[] NodeName
        {
            get;
            set;
        }
        /// <summary>
        /// `Node`'s nodeValue.
        ///</summary>
        [JsonProperty("nodeValue", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long[] NodeValue
        {
            get;
            set;
        }
        /// <summary>
        /// `Node`'s id, corresponds to DOM.Node.backendNodeId.
        ///</summary>
        [JsonProperty("backendNodeId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long[] BackendNodeId
        {
            get;
            set;
        }
        /// <summary>
        /// Attributes of an `Element` node. Flatten name, value pairs.
        ///</summary>
        [JsonProperty("attributes", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string[][] Attributes
        {
            get;
            set;
        }
        /// <summary>
        /// Only set for textarea elements, contains the text value.
        ///</summary>
        [JsonProperty("textValue", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public RareStringData TextValue
        {
            get;
            set;
        }
        /// <summary>
        /// Only set for input elements, contains the input's associated text value.
        ///</summary>
        [JsonProperty("inputValue", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public RareStringData InputValue
        {
            get;
            set;
        }
        /// <summary>
        /// Only set for radio and checkbox input elements, indicates if the element has been checked
        ///</summary>
        [JsonProperty("inputChecked", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public RareBooleanData InputChecked
        {
            get;
            set;
        }
        /// <summary>
        /// Only set for option elements, indicates if the element has been selected
        ///</summary>
        [JsonProperty("optionSelected", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public RareBooleanData OptionSelected
        {
            get;
            set;
        }
        /// <summary>
        /// The index of the document in the list of the snapshot documents.
        ///</summary>
        [JsonProperty("contentDocumentIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public RareIntegerData ContentDocumentIndex
        {
            get;
            set;
        }
        /// <summary>
        /// Type of a pseudo element node.
        ///</summary>
        [JsonProperty("pseudoType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public RareStringData PseudoType
        {
            get;
            set;
        }
        /// <summary>
        /// Whether this DOM node responds to mouse clicks. This includes nodes that have had click
        /// event listeners attached via JavaScript as well as anchor tags that naturally navigate when
        /// clicked.
        ///</summary>
        [JsonProperty("isClickable", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public RareBooleanData IsClickable
        {
            get;
            set;
        }
        /// <summary>
        /// The selected url for nodes with a srcset attribute.
        ///</summary>
        [JsonProperty("currentSourceURL", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public RareStringData CurrentSourceURL
        {
            get;
            set;
        }
        /// <summary>
        /// The url of the script (if any) that generates this node.
        ///</summary>
        [JsonProperty("originURL", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public RareStringData OriginURL
        {
            get;
            set;
        }
    }
}