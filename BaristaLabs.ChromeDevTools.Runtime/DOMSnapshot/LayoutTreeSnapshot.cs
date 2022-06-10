namespace BaristaLabs.ChromeDevTools.Runtime.DOMSnapshot
{
    using Newtonsoft.Json;

    /// <summary>
    /// Table of details of an element in the DOM tree with a LayoutObject.
    /// </summary>
    public sealed class LayoutTreeSnapshot
    {
        /// <summary>
        /// Index of the corresponding node in the `NodeTreeSnapshot` array returned by `captureSnapshot`.
        ///</summary>
        [JsonProperty("nodeIndex")]
        public long[] NodeIndex
        {
            get;
            set;
        }
        /// <summary>
        /// Array of indexes specifying computed style strings, filtered according to the `computedStyles` parameter passed to `captureSnapshot`.
        ///</summary>
        [JsonProperty("styles")]
        public string[][] Styles
        {
            get;
            set;
        }
        /// <summary>
        /// The absolute position bounding box.
        ///</summary>
        [JsonProperty("bounds")]
        public double[][] Bounds
        {
            get;
            set;
        }
        /// <summary>
        /// Contents of the LayoutText, if any.
        ///</summary>
        [JsonProperty("text")]
        public long[] Text
        {
            get;
            set;
        }
        /// <summary>
        /// Stacking context information.
        ///</summary>
        [JsonProperty("stackingContexts")]
        public RareBooleanData StackingContexts
        {
            get;
            set;
        }
        /// <summary>
        /// Global paint order index, which is determined by the stacking order of the nodes. Nodes
        /// that are painted together will have the same index. Only provided if includePaintOrder in
        /// captureSnapshot was true.
        ///</summary>
        [JsonProperty("paintOrders", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long[] PaintOrders
        {
            get;
            set;
        }
        /// <summary>
        /// The offset rect of nodes. Only available when includeDOMRects is set to true
        ///</summary>
        [JsonProperty("offsetRects", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double[][] OffsetRects
        {
            get;
            set;
        }
        /// <summary>
        /// The scroll rect of nodes. Only available when includeDOMRects is set to true
        ///</summary>
        [JsonProperty("scrollRects", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double[][] ScrollRects
        {
            get;
            set;
        }
        /// <summary>
        /// The client rect of nodes. Only available when includeDOMRects is set to true
        ///</summary>
        [JsonProperty("clientRects", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double[][] ClientRects
        {
            get;
            set;
        }
        /// <summary>
        /// The list of background colors that are blended with colors of overlapping elements.
        ///</summary>
        [JsonProperty("blendedBackgroundColors", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long[] BlendedBackgroundColors
        {
            get;
            set;
        }
        /// <summary>
        /// The list of computed text opacities.
        ///</summary>
        [JsonProperty("textColorOpacities", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double[] TextColorOpacities
        {
            get;
            set;
        }
    }
}