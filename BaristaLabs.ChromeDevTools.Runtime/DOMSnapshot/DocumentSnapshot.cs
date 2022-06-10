namespace BaristaLabs.ChromeDevTools.Runtime.DOMSnapshot
{
    using Newtonsoft.Json;

    /// <summary>
    /// Document snapshot.
    /// </summary>
    public sealed class DocumentSnapshot
    {
        /// <summary>
        /// Document URL that `Document` or `FrameOwner` node points to.
        ///</summary>
        [JsonProperty("documentURL")]
        public long DocumentURL
        {
            get;
            set;
        }
        /// <summary>
        /// Document title.
        ///</summary>
        [JsonProperty("title")]
        public long Title
        {
            get;
            set;
        }
        /// <summary>
        /// Base URL that `Document` or `FrameOwner` node uses for URL completion.
        ///</summary>
        [JsonProperty("baseURL")]
        public long BaseURL
        {
            get;
            set;
        }
        /// <summary>
        /// Contains the document's content language.
        ///</summary>
        [JsonProperty("contentLanguage")]
        public long ContentLanguage
        {
            get;
            set;
        }
        /// <summary>
        /// Contains the document's character set encoding.
        ///</summary>
        [JsonProperty("encodingName")]
        public long EncodingName
        {
            get;
            set;
        }
        /// <summary>
        /// `DocumentType` node's publicId.
        ///</summary>
        [JsonProperty("publicId")]
        public long PublicId
        {
            get;
            set;
        }
        /// <summary>
        /// `DocumentType` node's systemId.
        ///</summary>
        [JsonProperty("systemId")]
        public long SystemId
        {
            get;
            set;
        }
        /// <summary>
        /// Frame ID for frame owner elements and also for the document node.
        ///</summary>
        [JsonProperty("frameId")]
        public long FrameId
        {
            get;
            set;
        }
        /// <summary>
        /// A table with dom nodes.
        ///</summary>
        [JsonProperty("nodes")]
        public NodeTreeSnapshot Nodes
        {
            get;
            set;
        }
        /// <summary>
        /// The nodes in the layout tree.
        ///</summary>
        [JsonProperty("layout")]
        public LayoutTreeSnapshot Layout
        {
            get;
            set;
        }
        /// <summary>
        /// The post-layout inline text nodes.
        ///</summary>
        [JsonProperty("textBoxes")]
        public TextBoxSnapshot TextBoxes
        {
            get;
            set;
        }
        /// <summary>
        /// Horizontal scroll offset.
        ///</summary>
        [JsonProperty("scrollOffsetX", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? ScrollOffsetX
        {
            get;
            set;
        }
        /// <summary>
        /// Vertical scroll offset.
        ///</summary>
        [JsonProperty("scrollOffsetY", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? ScrollOffsetY
        {
            get;
            set;
        }
        /// <summary>
        /// Document content width.
        ///</summary>
        [JsonProperty("contentWidth", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? ContentWidth
        {
            get;
            set;
        }
        /// <summary>
        /// Document content height.
        ///</summary>
        [JsonProperty("contentHeight", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? ContentHeight
        {
            get;
            set;
        }
    }
}