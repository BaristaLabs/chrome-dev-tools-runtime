namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fetches a particular accessibility node by AXNodeId.
    /// Requires `enable()` to have been called previously.
    /// </summary>
    public sealed class GetChildAXNodesCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Accessibility.getChildAXNodes";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the id
        /// </summary>
        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }
        /// <summary>
        /// The frame in whose document the node resides.
        /// If omitted, the root frame is used.
        /// </summary>
        [JsonProperty("frameId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FrameId
        {
            get;
            set;
        }
    }

    public sealed class GetChildAXNodesCommandResponse : ICommandResponse<GetChildAXNodesCommand>
    {
        /// <summary>
        /// Gets or sets the nodes
        /// </summary>
        [JsonProperty("nodes")]
        public AXNode[] Nodes
        {
            get;
            set;
        }
    }
}