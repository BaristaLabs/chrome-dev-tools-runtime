namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// Style information for drawing a line.
    /// </summary>
    public sealed class LineStyle
    {
        /// <summary>
        /// The color of the line (default: transparent)
        ///</summary>
        [JsonProperty("color", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DOM.RGBA Color
        {
            get;
            set;
        }
        /// <summary>
        /// The line pattern (default: solid)
        ///</summary>
        [JsonProperty("pattern", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Pattern
        {
            get;
            set;
        }
    }
}