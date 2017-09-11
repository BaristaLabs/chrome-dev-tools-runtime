namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Viewport for capturing screenshot.
    /// </summary>
    public sealed class Viewport
    {
        /// <summary>
        /// X offset in CSS pixels.
        ///</summary>
        [JsonProperty("x")]
        public double X
        {
            get;
            set;
        }
        /// <summary>
        /// Y offset in CSS pixels
        ///</summary>
        [JsonProperty("y")]
        public double Y
        {
            get;
            set;
        }
        /// <summary>
        /// Rectangle width in CSS pixels
        ///</summary>
        [JsonProperty("width")]
        public double Width
        {
            get;
            set;
        }
        /// <summary>
        /// Rectangle height in CSS pixels
        ///</summary>
        [JsonProperty("height")]
        public double Height
        {
            get;
            set;
        }
        /// <summary>
        /// Page scale factor.
        ///</summary>
        [JsonProperty("scale")]
        public double Scale
        {
            get;
            set;
        }
    }
}