namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// DOM interaction is implemented in terms of mirror objects that represent the actual DOM nodes. DOMNode is a base node mirror type.
    /// </summary>
    public sealed class Node
    {
        /// <summary>
        /// Node identifier that is passed into the rest of the DOM messages as the &lt;code&gt;nodeId&lt;/code&gt;. Backend will only push node with given &lt;code&gt;id&lt;/code&gt; once. It is aware of all requested nodes and will only fire DOM events for nodes known to the client.
        ///</summary>
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
        /// <summary>
        /// The id of the parent node if any.
        ///</summary>
        [JsonProperty("parentId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? ParentId
        {
            get;
            set;
        }
        /// <summary>
        /// The BackendNodeId for this node.
        ///</summary>
        [JsonProperty("backendNodeId")]
        public long BackendNodeId
        {
            get;
            set;
        }
        /// <summary>
        /// &lt;code&gt;Node&lt;/code&gt;'s nodeType.
        ///</summary>
        [JsonProperty("nodeType")]
        public long NodeType
        {
            get;
            set;
        }
        /// <summary>
        /// &lt;code&gt;Node&lt;/code&gt;'s nodeName.
        ///</summary>
        [JsonProperty("nodeName")]
        public string NodeName
        {
            get;
            set;
        }
        /// <summary>
        /// &lt;code&gt;Node&lt;/code&gt;'s localName.
        ///</summary>
        [JsonProperty("localName")]
        public string LocalName
        {
            get;
            set;
        }
        /// <summary>
        /// &lt;code&gt;Node&lt;/code&gt;'s nodeValue.
        ///</summary>
        [JsonProperty("nodeValue")]
        public string NodeValue
        {
            get;
            set;
        }
        /// <summary>
        /// Child count for &lt;code&gt;Container&lt;/code&gt; nodes.
        ///</summary>
        [JsonProperty("childNodeCount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? ChildNodeCount
        {
            get;
            set;
        }
        /// <summary>
        /// Child nodes of this node when requested with children.
        ///</summary>
        [JsonProperty("children", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Node[] Children
        {
            get;
            set;
        }
        /// <summary>
        /// Attributes of the &lt;code&gt;Element&lt;/code&gt; node in the form of flat array &lt;code&gt;[name1, value1, name2, value2]&lt;/code&gt;.
        ///</summary>
        [JsonProperty("attributes", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string[] Attributes
        {
            get;
            set;
        }
        /// <summary>
        /// Document URL that &lt;code&gt;Document&lt;/code&gt; or &lt;code&gt;FrameOwner&lt;/code&gt; node points to.
        ///</summary>
        [JsonProperty("documentURL", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string DocumentURL
        {
            get;
            set;
        }
        /// <summary>
        /// Base URL that &lt;code&gt;Document&lt;/code&gt; or &lt;code&gt;FrameOwner&lt;/code&gt; node uses for URL completion.
        ///</summary>
        [JsonProperty("baseURL", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BaseURL
        {
            get;
            set;
        }
        /// <summary>
        /// &lt;code&gt;DocumentType&lt;/code&gt;'s publicId.
        ///</summary>
        [JsonProperty("publicId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PublicId
        {
            get;
            set;
        }
        /// <summary>
        /// &lt;code&gt;DocumentType&lt;/code&gt;'s systemId.
        ///</summary>
        [JsonProperty("systemId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string SystemId
        {
            get;
            set;
        }
        /// <summary>
        /// &lt;code&gt;DocumentType&lt;/code&gt;'s internalSubset.
        ///</summary>
        [JsonProperty("internalSubset", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string InternalSubset
        {
            get;
            set;
        }
        /// <summary>
        /// &lt;code&gt;Document&lt;/code&gt;'s XML version in case of XML documents.
        ///</summary>
        [JsonProperty("xmlVersion", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string XmlVersion
        {
            get;
            set;
        }
        /// <summary>
        /// &lt;code&gt;Attr&lt;/code&gt;'s name.
        ///</summary>
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// &lt;code&gt;Attr&lt;/code&gt;'s value.
        ///</summary>
        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Value
        {
            get;
            set;
        }
        /// <summary>
        /// Pseudo element type for this node.
        ///</summary>
        [JsonProperty("pseudoType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PseudoType? PseudoType
        {
            get;
            set;
        }
        /// <summary>
        /// Shadow root type.
        ///</summary>
        [JsonProperty("shadowRootType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ShadowRootType? ShadowRootType
        {
            get;
            set;
        }
        /// <summary>
        /// Frame ID for frame owner elements.
        ///</summary>
        [JsonProperty("frameId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FrameId
        {
            get;
            set;
        }
        /// <summary>
        /// Content document for frame owner elements.
        ///</summary>
        [JsonProperty("contentDocument", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Node ContentDocument
        {
            get;
            set;
        }
        /// <summary>
        /// Shadow root list for given element host.
        ///</summary>
        [JsonProperty("shadowRoots", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Node[] ShadowRoots
        {
            get;
            set;
        }
        /// <summary>
        /// Content document fragment for template elements.
        ///</summary>
        [JsonProperty("templateContent", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Node TemplateContent
        {
            get;
            set;
        }
        /// <summary>
        /// Pseudo elements associated with this node.
        ///</summary>
        [JsonProperty("pseudoElements", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Node[] PseudoElements
        {
            get;
            set;
        }
        /// <summary>
        /// Import document for the HTMLImport links.
        ///</summary>
        [JsonProperty("importedDocument", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Node ImportedDocument
        {
            get;
            set;
        }
        /// <summary>
        /// Distributed nodes for given insertion point.
        ///</summary>
        [JsonProperty("distributedNodes", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public BackendNode[] DistributedNodes
        {
            get;
            set;
        }
        /// <summary>
        /// Whether the node is SVG.
        ///</summary>
        [JsonProperty("isSVG", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? IsSVG
        {
            get;
            set;
        }
    }
}