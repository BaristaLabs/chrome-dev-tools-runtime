namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Highlights given quad. Coordinates are absolute with respect to the main frame viewport.
    /// </summary>
    public sealed class HighlightQuadCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.highlightQuad";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Quad to highlight
        /// </summary>
        [JsonProperty("quad")]
        public double[] Quad
        {
            get;
            set;
        }
        /// <summary>
        /// The highlight fill color (default: transparent).
        /// </summary>
        [JsonProperty("color", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public RGBA Color
        {
            get;
            set;
        }
        /// <summary>
        /// The highlight outline color (default: transparent).
        /// </summary>
        [JsonProperty("outlineColor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public RGBA OutlineColor
        {
            get;
            set;
        }
    }

    public sealed class HighlightQuadCommandResponse : ICommandResponse<HighlightQuadCommand>
    {
    }
}