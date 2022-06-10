namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// ScrollSnapContainerHighlightConfig
    /// </summary>
    public sealed class ScrollSnapContainerHighlightConfig
    {
        /// <summary>
        /// The style of the snapport border (default: transparent)
        ///</summary>
        [JsonProperty("snapportBorder", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public LineStyle SnapportBorder
        {
            get;
            set;
        }
        /// <summary>
        /// The style of the snap area border (default: transparent)
        ///</summary>
        [JsonProperty("snapAreaBorder", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public LineStyle SnapAreaBorder
        {
            get;
            set;
        }
        /// <summary>
        /// The margin highlight fill color (default: transparent).
        ///</summary>
        [JsonProperty("scrollMarginColor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DOM.RGBA ScrollMarginColor
        {
            get;
            set;
        }
        /// <summary>
        /// The padding highlight fill color (default: transparent).
        ///</summary>
        [JsonProperty("scrollPaddingColor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DOM.RGBA ScrollPaddingColor
        {
            get;
            set;
        }
    }
}