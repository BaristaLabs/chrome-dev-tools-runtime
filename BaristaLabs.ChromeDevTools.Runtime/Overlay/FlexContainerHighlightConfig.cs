namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// Configuration data for the highlighting of Flex container elements.
    /// </summary>
    public sealed class FlexContainerHighlightConfig
    {
        /// <summary>
        /// The style of the container border
        ///</summary>
        [JsonProperty("containerBorder", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public LineStyle ContainerBorder
        {
            get;
            set;
        }
        /// <summary>
        /// The style of the separator between lines
        ///</summary>
        [JsonProperty("lineSeparator", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public LineStyle LineSeparator
        {
            get;
            set;
        }
        /// <summary>
        /// The style of the separator between items
        ///</summary>
        [JsonProperty("itemSeparator", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public LineStyle ItemSeparator
        {
            get;
            set;
        }
        /// <summary>
        /// Style of content-distribution space on the main axis (justify-content).
        ///</summary>
        [JsonProperty("mainDistributedSpace", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public BoxStyle MainDistributedSpace
        {
            get;
            set;
        }
        /// <summary>
        /// Style of content-distribution space on the cross axis (align-content).
        ///</summary>
        [JsonProperty("crossDistributedSpace", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public BoxStyle CrossDistributedSpace
        {
            get;
            set;
        }
        /// <summary>
        /// Style of empty space caused by row gaps (gap/row-gap).
        ///</summary>
        [JsonProperty("rowGapSpace", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public BoxStyle RowGapSpace
        {
            get;
            set;
        }
        /// <summary>
        /// Style of empty space caused by columns gaps (gap/column-gap).
        ///</summary>
        [JsonProperty("columnGapSpace", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public BoxStyle ColumnGapSpace
        {
            get;
            set;
        }
        /// <summary>
        /// Style of the self-alignment line (align-items).
        ///</summary>
        [JsonProperty("crossAlignment", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public LineStyle CrossAlignment
        {
            get;
            set;
        }
    }
}