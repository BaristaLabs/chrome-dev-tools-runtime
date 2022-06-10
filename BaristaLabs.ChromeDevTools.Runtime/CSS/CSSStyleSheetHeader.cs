namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// CSS stylesheet metainformation.
    /// </summary>
    public sealed class CSSStyleSheetHeader
    {
        /// <summary>
        /// The stylesheet identifier.
        ///</summary>
        [JsonProperty("styleSheetId")]
        public string StyleSheetId
        {
            get;
            set;
        }
        /// <summary>
        /// Owner frame identifier.
        ///</summary>
        [JsonProperty("frameId")]
        public string FrameId
        {
            get;
            set;
        }
        /// <summary>
        /// Stylesheet resource URL. Empty if this is a constructed stylesheet created using
        /// new CSSStyleSheet() (but non-empty if this is a constructed sylesheet imported
        /// as a CSS module script).
        ///</summary>
        [JsonProperty("sourceURL")]
        public string SourceURL
        {
            get;
            set;
        }
        /// <summary>
        /// URL of source map associated with the stylesheet (if any).
        ///</summary>
        [JsonProperty("sourceMapURL", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string SourceMapURL
        {
            get;
            set;
        }
        /// <summary>
        /// Stylesheet origin.
        ///</summary>
        [JsonProperty("origin")]
        public StyleSheetOrigin Origin
        {
            get;
            set;
        }
        /// <summary>
        /// Stylesheet title.
        ///</summary>
        [JsonProperty("title")]
        public string Title
        {
            get;
            set;
        }
        /// <summary>
        /// The backend id for the owner node of the stylesheet.
        ///</summary>
        [JsonProperty("ownerNode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? OwnerNode
        {
            get;
            set;
        }
        /// <summary>
        /// Denotes whether the stylesheet is disabled.
        ///</summary>
        [JsonProperty("disabled")]
        public bool Disabled
        {
            get;
            set;
        }
        /// <summary>
        /// Whether the sourceURL field value comes from the sourceURL comment.
        ///</summary>
        [JsonProperty("hasSourceURL", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? HasSourceURL
        {
            get;
            set;
        }
        /// <summary>
        /// Whether this stylesheet is created for STYLE tag by parser. This flag is not set for
        /// document.written STYLE tags.
        ///</summary>
        [JsonProperty("isInline")]
        public bool IsInline
        {
            get;
            set;
        }
        /// <summary>
        /// Whether this stylesheet is mutable. Inline stylesheets become mutable
        /// after they have been modified via CSSOM API.
        /// <link> element's stylesheets become mutable only if DevTools modifies them.
        /// Constructed stylesheets (new CSSStyleSheet()) are mutable immediately after creation.
        ///</summary>
        [JsonProperty("isMutable")]
        public bool IsMutable
        {
            get;
            set;
        }
        /// <summary>
        /// True if this stylesheet is created through new CSSStyleSheet() or imported as a
        /// CSS module script.
        ///</summary>
        [JsonProperty("isConstructed")]
        public bool IsConstructed
        {
            get;
            set;
        }
        /// <summary>
        /// Line offset of the stylesheet within the resource (zero based).
        ///</summary>
        [JsonProperty("startLine")]
        public double StartLine
        {
            get;
            set;
        }
        /// <summary>
        /// Column offset of the stylesheet within the resource (zero based).
        ///</summary>
        [JsonProperty("startColumn")]
        public double StartColumn
        {
            get;
            set;
        }
        /// <summary>
        /// Size of the content (in characters).
        ///</summary>
        [JsonProperty("length")]
        public double Length
        {
            get;
            set;
        }
        /// <summary>
        /// Line offset of the end of the stylesheet within the resource (zero based).
        ///</summary>
        [JsonProperty("endLine")]
        public double EndLine
        {
            get;
            set;
        }
        /// <summary>
        /// Column offset of the end of the stylesheet within the resource (zero based).
        ///</summary>
        [JsonProperty("endColumn")]
        public double EndColumn
        {
            get;
            set;
        }
    }
}