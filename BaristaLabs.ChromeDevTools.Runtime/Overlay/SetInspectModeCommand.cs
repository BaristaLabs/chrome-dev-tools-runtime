namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enters the 'inspect' mode. In this mode, elements that user is hovering over are highlighted.
    /// Backend then generates 'inspectNodeRequested' event upon element selection.
    /// </summary>
    public sealed class SetInspectModeCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Overlay.setInspectMode";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Set an inspection mode.
        /// </summary>
        [JsonProperty("mode")]
        public InspectMode Mode
        {
            get;
            set;
        }
        /// <summary>
        /// A descriptor for the highlight appearance of hovered-over nodes. May be omitted if `enabled
        /// == false`.
        /// </summary>
        [JsonProperty("highlightConfig", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public HighlightConfig HighlightConfig
        {
            get;
            set;
        }
    }

    public sealed class SetInspectModeCommandResponse : ICommandResponse<SetInspectModeCommand>
    {
    }
}