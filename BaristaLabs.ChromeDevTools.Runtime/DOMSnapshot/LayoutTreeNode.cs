namespace BaristaLabs.ChromeDevTools.Runtime.DOMSnapshot
{
    using Newtonsoft.Json;

    /// <summary>
    /// Details of an element in the DOM tree with a LayoutObject.
    /// </summary>
    public sealed class LayoutTreeNode
    {
        /// <summary>
        /// The index of the related DOM node in the `domNodes` array returned by `getSnapshot`.
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
        public InlineTextBox[] InlineTextNodes
        {
            get;
            set;
        }
        /// <summary>
        /// Index into the `computedStyles` array returned by `getSnapshot`.
        ///</summary>
        [JsonProperty("styleIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? StyleIndex
        {
            get;
            set;
        }
        /// <summary>
        /// Global paint order index, which is determined by the stacking order of the nodes. Nodes
        /// that are painted together will have the same index. Only provided if includePaintOrder in
        /// getSnapshot was true.
        ///</summary>
        [JsonProperty("paintOrder", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? PaintOrder
        {
            get;
            set;
        }
        /// <summary>
        /// Set to true to indicate the element begins a new stacking context.
        ///</summary>
        [JsonProperty("isStackingContext", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? IsStackingContext
        {
            get;
            set;
        }
    }
}