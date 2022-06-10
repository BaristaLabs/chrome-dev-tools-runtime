namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// Highlights owner element of the frame with given id.
    /// Deprecated: Doesn't work reliablity and cannot be fixed due to process
    /// separatation (the owner node might be in a different process). Determine
    /// the owner node in the client and use highlightNode.
    /// </summary>
    public sealed class HighlightFrameCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Overlay.highlightFrame";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Identifier of the frame to highlight.
        /// </summary>
        [JsonProperty("frameId")]
        public string FrameId
        {
            get;
            set;
        }
        /// <summary>
        /// The content box highlight fill color (default: transparent).
        /// </summary>
        [JsonProperty("contentColor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DOM.RGBA ContentColor
        {
            get;
            set;
        }
        /// <summary>
        /// The content box highlight outline color (default: transparent).
        /// </summary>
        [JsonProperty("contentOutlineColor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DOM.RGBA ContentOutlineColor
        {
            get;
            set;
        }
    }

    public sealed class HighlightFrameCommandResponse : ICommandResponse<HighlightFrameCommand>
    {
    }
}