namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// Configuration data for drawing the source order of an elements children.
    /// </summary>
    public sealed class SourceOrderConfig
    {
        /// <summary>
        /// the color to outline the givent element in.
        ///</summary>
        [JsonProperty("parentOutlineColor")]
        public DOM.RGBA ParentOutlineColor
        {
            get;
            set;
        }
        /// <summary>
        /// the color to outline the child elements in.
        ///</summary>
        [JsonProperty("childOutlineColor")]
        public DOM.RGBA ChildOutlineColor
        {
            get;
            set;
        }
    }
}