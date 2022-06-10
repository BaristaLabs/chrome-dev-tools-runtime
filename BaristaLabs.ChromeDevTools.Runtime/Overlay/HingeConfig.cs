namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// Configuration for dual screen hinge
    /// </summary>
    public sealed class HingeConfig
    {
        /// <summary>
        /// A rectangle represent hinge
        ///</summary>
        [JsonProperty("rect")]
        public DOM.Rect Rect
        {
            get;
            set;
        }
        /// <summary>
        /// The content box highlight fill color (default: a dark color).
        ///</summary>
        [JsonProperty("contentColor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DOM.RGBA ContentColor
        {
            get;
            set;
        }
        /// <summary>
        /// The content box highlight outline color (default: transparent).
        ///</summary>
        [JsonProperty("outlineColor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DOM.RGBA OutlineColor
        {
            get;
            set;
        }
    }
}