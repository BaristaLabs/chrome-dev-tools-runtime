namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// Highlight multiple elements with the CSS Grid overlay.
    /// </summary>
    public sealed class SetShowGridOverlaysCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Overlay.setShowGridOverlays";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// An array of node identifiers and descriptors for the highlight appearance.
        /// </summary>
        [JsonProperty("gridNodeHighlightConfigs")]
        public GridNodeHighlightConfig[] GridNodeHighlightConfigs
        {
            get;
            set;
        }
    }

    public sealed class SetShowGridOverlaysCommandResponse : ICommandResponse<SetShowGridOverlaysCommand>
    {
    }
}