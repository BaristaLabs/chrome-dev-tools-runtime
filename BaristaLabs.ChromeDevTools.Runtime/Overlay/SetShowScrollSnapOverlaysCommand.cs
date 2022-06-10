namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// SetShowScrollSnapOverlays
    /// </summary>
    public sealed class SetShowScrollSnapOverlaysCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Overlay.setShowScrollSnapOverlays";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// An array of node identifiers and descriptors for the highlight appearance.
        /// </summary>
        [JsonProperty("scrollSnapHighlightConfigs")]
        public ScrollSnapHighlightConfig[] ScrollSnapHighlightConfigs
        {
            get;
            set;
        }
    }

    public sealed class SetShowScrollSnapOverlaysCommandResponse : ICommandResponse<SetShowScrollSnapOverlaysCommand>
    {
    }
}