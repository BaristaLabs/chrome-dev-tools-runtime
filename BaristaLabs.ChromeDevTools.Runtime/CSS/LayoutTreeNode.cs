namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Details of an element in the DOM tree with a LayoutObject.
    /// </summary>
    public sealed class LayoutTreeNode
    {
        /// <summary>
        /// The id of the related DOM node matching one from DOM.GetDocument.
        ///</summary>
        [JsonProperty("nodeId")]
        public long NodeId
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
        /// Contents of the LayoutText if any
        ///</summary>
        [JsonProperty("layoutText", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LayoutText
        {
            get;
            set;
        }
        /// <summary>
        /// The post layout inline text nodes, if any.
        ///</summary>
        [JsonProperty("inlineTextNodes", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InlineTextBox[] InlineTextNodes
        {
            get;
            set;
        }
        /// <summary>
        /// Index into the computedStyles array returned by getLayoutTreeAndStyles.
        ///</summary>
        [JsonProperty("styleIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? StyleIndex
        {
            get;
            set;
        }
    }
}