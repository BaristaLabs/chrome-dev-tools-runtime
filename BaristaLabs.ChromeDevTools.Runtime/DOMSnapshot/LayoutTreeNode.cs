namespace BaristaLabs.ChromeDevTools.Runtime.DOMSnapshot
{
    using Newtonsoft.Json;

    /// <summary>
    /// Details of an element in the DOM tree with a LayoutObject.
    /// </summary>
    public sealed class LayoutTreeNode
    {
        /// <summary>
        /// The index of the related DOM node in the &lt;code&gt;domNodes&lt;/code&gt; array returned by &lt;code&gt;getSnapshot&lt;/code&gt;.
        ///</summary>
        [JsonProperty("domNodeIndex")]
        public long DomNodeIndex
        {
            get;
            set;
        }
        /// <summary>
        /// The absolute position bounding box.
        ///</summary>
        [JsonProperty("boundingBox")]
        public DOM.Rect BoundingBox
        {
            get;
            set;
        }
        /// <summary>
        /// Contents of the LayoutText, if any.
        ///</summary>
        [JsonProperty("layoutText", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LayoutText
        {
            get;
            set;
        }
        /// <summary>
        /// The post-layout inline text nodes, if any.
        ///</summary>
        [JsonProperty("inlineTextNodes", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CSS.InlineTextBox[] InlineTextNodes
        {
            get;
            set;
        }
        /// <summary>
        /// Index into the &lt;code&gt;computedStyles&lt;/code&gt; array returned by &lt;code&gt;getSnapshot&lt;/code&gt;.
        ///</summary>
        [JsonProperty("styleIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? StyleIndex
        {
            get;
            set;
        }
    }
}