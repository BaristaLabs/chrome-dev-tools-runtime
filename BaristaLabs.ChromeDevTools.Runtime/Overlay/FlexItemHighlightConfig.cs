namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// Configuration data for the highlighting of Flex item elements.
    /// </summary>
    public sealed class FlexItemHighlightConfig
    {
        /// <summary>
        /// Style of the box representing the item's base size
        ///</summary>
        [JsonProperty("baseSizeBox", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public BoxStyle BaseSizeBox
        {
            get;
            set;
        }
        /// <summary>
        /// Style of the border around the box representing the item's base size
        ///</summary>
        [JsonProperty("baseSizeBorder", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public LineStyle BaseSizeBorder
        {
            get;
            set;
        }
        /// <summary>
        /// Style of the arrow representing if the item grew or shrank
        ///</summary>
        [JsonProperty("flexibilityArrow", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public LineStyle FlexibilityArrow
        {
            get;
            set;
        }
    }
}