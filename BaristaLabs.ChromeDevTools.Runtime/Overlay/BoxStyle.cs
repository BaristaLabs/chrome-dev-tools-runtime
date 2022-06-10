namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// Style information for drawing a box.
    /// </summary>
    public sealed class BoxStyle
    {
        /// <summary>
        /// The background color for the box (default: transparent)
        ///</summary>
        [JsonProperty("fillColor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DOM.RGBA FillColor
        {
            get;
            set;
        }
        /// <summary>
        /// The hatching color for the box (default: transparent)
        ///</summary>
        [JsonProperty("hatchColor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DOM.RGBA HatchColor
        {
            get;
            set;
        }
    }
}