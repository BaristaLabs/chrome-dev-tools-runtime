namespace BaristaLabs.ChromeDevTools.Runtime.DOMSnapshot
{
    using Newtonsoft.Json;

    /// <summary>
    /// Details of an element in the DOM tree with a LayoutObject.
    /// </summary>
    public sealed class LayoutTreeSnapshot
    {
        /// <summary>
        /// The index of the related DOM node in the `domNodes` array returned by `getSnapshot`.
        ///</summary>
        [JsonProperty("nodeIndex")]
        public long[] NodeIndex
        {
            get;
            set;
        }
        /// <summary>
        /// Index into the `computedStyles` array returned by `captureSnapshot`.
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
    }
}