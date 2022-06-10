namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// SetShowContainerQueryOverlays
    /// </summary>
    public sealed class SetShowContainerQueryOverlaysCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Overlay.setShowContainerQueryOverlays";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// An array of node identifiers and descriptors for the highlight appearance.
        /// </summary>
        [JsonProperty("containerQueryHighlightConfigs")]
        public ContainerQueryHighlightConfig[] ContainerQueryHighlightConfigs
        {
            get;
            set;
        }
    }

    public sealed class SetShowContainerQueryOverlaysCommandResponse : ICommandResponse<SetShowContainerQueryOverlaysCommand>
    {
    }
}