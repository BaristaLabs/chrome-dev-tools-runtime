namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// SetShowFlexOverlays
    /// </summary>
    public sealed class SetShowFlexOverlaysCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Overlay.setShowFlexOverlays";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// An array of node identifiers and descriptors for the highlight appearance.
        /// </summary>
        [JsonProperty("flexNodeHighlightConfigs")]
        public FlexNodeHighlightConfig[] FlexNodeHighlightConfigs
        {
            get;
            set;
        }
    }

    public sealed class SetShowFlexOverlaysCommandResponse : ICommandResponse<SetShowFlexOverlaysCommand>
    {
    }
}