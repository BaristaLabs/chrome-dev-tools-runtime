namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// Highlights the source order of the children of the DOM node with given id or with the given
    /// JavaScript object wrapper. Either nodeId or objectId must be specified.
    /// </summary>
    public sealed class HighlightSourceOrderCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Overlay.highlightSourceOrder";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// A descriptor for the appearance of the overlay drawing.
        /// </summary>
        [JsonProperty("sourceOrderConfig")]
        public SourceOrderConfig SourceOrderConfig
        {
            get;
            set;
        }
        /// <summary>
        /// Identifier of the node to highlight.
        /// </summary>
        [JsonProperty("nodeId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? NodeId
        {
            get;
            set;
        }
        /// <summary>
        /// Identifier of the backend node to highlight.
        /// </summary>
        [JsonProperty("backendNodeId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? BackendNodeId
        {
            get;
            set;
        }
        /// <summary>
        /// JavaScript object id of the node to be highlighted.
        /// </summary>
        [JsonProperty("objectId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ObjectId
        {
            get;
            set;
        }
    }

    public sealed class HighlightSourceOrderCommandResponse : ICommandResponse<HighlightSourceOrderCommand>
    {
    }
}