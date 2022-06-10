namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Starts tracking the given computed styles for updates. The specified array of properties
    /// replaces the one previously specified. Pass empty array to disable tracking.
    /// Use takeComputedStyleUpdates to retrieve the list of nodes that had properties modified.
    /// The changes to computed style properties are only tracked for nodes pushed to the front-end
    /// by the DOM agent. If no changes to the tracked properties occur after the node has been pushed
    /// to the front-end, no updates will be issued for the node.
    /// </summary>
    public sealed class TrackComputedStyleUpdatesCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.trackComputedStyleUpdates";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the propertiesToTrack
        /// </summary>
        [JsonProperty("propertiesToTrack")]
        public CSSComputedStyleProperty[] PropertiesToTrack
        {
            get;
            set;
        }
    }

    public sealed class TrackComputedStyleUpdatesCommandResponse : ICommandResponse<TrackComputedStyleUpdatesCommand>
    {
    }
}