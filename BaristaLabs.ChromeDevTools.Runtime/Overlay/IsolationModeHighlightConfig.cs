namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// IsolationModeHighlightConfig
    /// </summary>
    public sealed class IsolationModeHighlightConfig
    {
        /// <summary>
        /// The fill color of the resizers (default: transparent).
        ///</summary>
        [JsonProperty("resizerColor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DOM.RGBA ResizerColor
        {
            get;
            set;
        }
        /// <summary>
        /// The fill color for resizer handles (default: transparent).
        ///</summary>
        [JsonProperty("resizerHandleColor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DOM.RGBA ResizerHandleColor
        {
            get;
            set;
        }
        /// <summary>
        /// The fill color for the mask covering non-isolated elements (default: transparent).
        ///</summary>
        [JsonProperty("maskColor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DOM.RGBA MaskColor
        {
            get;
            set;
        }
    }
}