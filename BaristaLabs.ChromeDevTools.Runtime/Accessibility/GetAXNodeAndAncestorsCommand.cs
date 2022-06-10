namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fetches a node and all ancestors up to and including the root.
    /// Requires `enable()` to have been called previously.
    /// </summary>
    public sealed class GetAXNodeAndAncestorsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Accessibility.getAXNodeAndAncestors";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Identifier of the node to get.
        /// </summary>
        [JsonProperty("nodeId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? NodeId
        {
            get;
            set;
        }
        /// <summary>
        /// Identifier of the backend node to get.
        /// </summary>
        [JsonProperty("backendNodeId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? BackendNodeId
        {
            get;
            set;
        }
        /// <summary>
        /// JavaScript object id of the node wrapper to get.
        /// </summary>
        [JsonProperty("objectId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ObjectId
        {
            get;
            set;
        }
    }

    public sealed class GetAXNodeAndAncestorsCommandResponse : ICommandResponse<GetAXNodeAndAncestorsCommand>
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