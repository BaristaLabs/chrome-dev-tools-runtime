namespace BaristaLabs.ChromeDevTools.Runtime.DOMSnapshot
{
    using Newtonsoft.Json;

    /// <summary>
    /// A Node in the DOM tree.
    /// </summary>
    public sealed class DOMNode
    {
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
        /// &lt;code&gt;Node&lt;/code&gt;'s nodeValue.
        ///</summary>
        [JsonProperty("nodeValue")]
        public string NodeValue
        {
            get;
            set;
        }
        /// <summary>
        /// Only set for textarea elements, contains the text value.
        ///</summary>
        [JsonProperty("textValue", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TextValue
        {
            get;
            set;
        }
        /// <summary>
        /// Only set for input elements, contains the input's associated text value.
        ///</summary>
        [JsonProperty("inputValue", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string InputValue
        {
            get;
            set;
        }
        /// <summary>
        /// Only set for radio and checkbox input elements, indicates if the element has been checked
        ///</summary>
        [JsonProperty("inputChecked", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? InputChecked
        {
            get;
            set;
        }
        /// <summary>
        /// Only set for option elements, indicates if the element has been selected
        ///</summary>
        [JsonProperty("optionSelected", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? OptionSelected
        {
            get;
            set;
        }
        /// <summary>
        /// &lt;code&gt;Node&lt;/code&gt;'s id, corresponds to DOM.Node.backendNodeId.
        ///</summary>
        [JsonProperty("backendNodeId")]
        public long BackendNodeId
        {
            get;
            set;
        }
        /// <summary>
        /// The indexes of the node's child nodes in the &lt;code&gt;domNodes&lt;/code&gt; array returned by &lt;code&gt;getSnapshot&lt;/code&gt;, if any.
        ///</summary>
        [JsonProperty("childNodeIndexes", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long[] ChildNodeIndexes
        {
            get;
            set;
        }
        /// <summary>
        /// Attributes of an &lt;code&gt;Element&lt;/code&gt; node.
        ///</summary>
        [JsonProperty("attributes", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public NameValue[] Attributes
        {
            get;
            set;
        }
        /// <summary>
        /// Indexes of pseudo elements associated with this node in the &lt;code&gt;domNodes&lt;/code&gt; array returned by &lt;code&gt;getSnapshot&lt;/code&gt;, if any.
        ///</summary>
        [JsonProperty("pseudoElementIndexes", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long[] PseudoElementIndexes
        {
            get;
            set;
        }
        /// <summary>
        /// The index of the node's related layout tree node in the &lt;code&gt;layoutTreeNodes&lt;/code&gt; array returned by &lt;code&gt;getSnapshot&lt;/code&gt;, if any.
        ///</summary>
        [JsonProperty("layoutNodeIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? LayoutNodeIndex
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
        /// Only set for documents, contains the document's content language.
        ///</summary>
        [JsonProperty("contentLanguage", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ContentLanguage
        {
            get;
            set;
        }
        /// <summary>
        /// Only set for documents, contains the document's character set encoding.
        ///</summary>
        [JsonProperty("documentEncoding", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string DocumentEncoding
        {
            get;
            set;
        }
        /// <summary>
        /// &lt;code&gt;DocumentType&lt;/code&gt; node's publicId.
        ///</summary>
        [JsonProperty("publicId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PublicId
        {
            get;
            set;
        }
        /// <summary>
        /// &lt;code&gt;DocumentType&lt;/code&gt; node's systemId.
        ///</summary>
        [JsonProperty("systemId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string SystemId
        {
            get;
            set;
        }
        /// <summary>
        /// Frame ID for frame owner elements and also for the document node.
        ///</summary>
        [JsonProperty("frameId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FrameId
        {
            get;
            set;
        }
        /// <summary>
        /// The index of a frame owner element's content document in the &lt;code&gt;domNodes&lt;/code&gt; array returned by &lt;code&gt;getSnapshot&lt;/code&gt;, if any.
        ///</summary>
        [JsonProperty("contentDocumentIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? ContentDocumentIndex
        {
            get;
            set;
        }
        /// <summary>
        /// Index of the imported document's node of a link element in the &lt;code&gt;domNodes&lt;/code&gt; array returned by &lt;code&gt;getSnapshot&lt;/code&gt;, if any.
        ///</summary>
        [JsonProperty("importedDocumentIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? ImportedDocumentIndex
        {
            get;
            set;
        }
        /// <summary>
        /// Index of the content node of a template element in the &lt;code&gt;domNodes&lt;/code&gt; array returned by &lt;code&gt;getSnapshot&lt;/code&gt;.
        ///</summary>
        [JsonProperty("templateContentIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? TemplateContentIndex
        {
            get;
            set;
        }
        /// <summary>
        /// Type of a pseudo element node.
        ///</summary>
        [JsonProperty("pseudoType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DOM.PseudoType PseudoType
        {
            get;
            set;
        }
        /// <summary>
        /// Whether this DOM node responds to mouse clicks. This includes nodes that have had click event listeners attached via JavaScript as well as anchor tags that naturally navigate when clicked.
        ///</summary>
        [JsonProperty("isClickable", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? IsClickable
        {
            get;
            set;
        }
    }
}