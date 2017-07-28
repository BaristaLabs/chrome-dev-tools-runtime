namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// Highlights given rectangle. Coordinates are absolute with respect to the main frame viewport.
    /// </summary>
    public sealed class HighlightRectCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Overlay.highlightRect";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// X coordinate
        /// </summary>
        [JsonProperty("x")]
        public long X
        {
            get;
            set;
        }
        /// <summary>
        /// Y coordinate
        /// </summary>
        [JsonProperty("y")]
        public long Y
        {
            get;
            set;
        }
        /// <summary>
        /// Rectangle width
        /// </summary>
        [JsonProperty("width")]
        public long Width
        {
            get;
            set;
        }
        /// <summary>
        /// Rectangle height
        /// </summary>
        [JsonProperty("height")]
        public long Height
        {
            get;
            set;
        }
        /// <summary>
        /// The highlight fill color (default: transparent).
        /// </summary>
        [JsonProperty("color", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DOM.RGBA Color
        {
            get;
            set;
        }
        /// <summary>
        /// The highlight outline color (default: transparent).
        /// </summary>
        [JsonProperty("outlineColor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DOM.RGBA OutlineColor
        {
            get;
            set;
        }
    }

    public sealed class HighlightRectCommandResponse : ICommandResponse<HighlightRectCommand>
    {
    }
}