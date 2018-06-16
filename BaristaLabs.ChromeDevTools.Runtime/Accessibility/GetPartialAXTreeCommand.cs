namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fetches the accessibility node and partial accessibility tree for this DOM node, if it exists.
    /// </summary>
    public sealed class GetPartialAXTreeCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Accessibility.getPartialAXTree";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Identifier of the node to get the partial accessibility tree for.
        /// </summary>
        [JsonProperty("nodeId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? NodeId
        {
            get;
            set;
        }
        /// <summary>
        /// Identifier of the backend node to get the partial accessibility tree for.
        /// </summary>
        [JsonProperty("backendNodeId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? BackendNodeId
        {
            get;
            set;
        }
        /// <summary>
        /// JavaScript object id of the node wrapper to get the partial accessibility tree for.
        /// </summary>
        [JsonProperty("objectId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ObjectId
        {
            get;
            set;
        }
        /// <summary>
        /// Whether to fetch this nodes ancestors, siblings and children. Defaults to true.
        /// </summary>
        [JsonProperty("fetchRelatives", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? FetchRelatives
        {
            get;
            set;
        }
    }

    public sealed class GetPartialAXTreeCommandResponse : ICommandResponse<GetPartialAXTreeCommand>
    {
        /// <summary>
        /// The `Accessibility.AXNode` for this DOM node, if it exists, plus its ancestors, siblings and
        /// children, if requested.
        ///</summary>
        [JsonProperty("nodes")]
        public AXNode[] Nodes
        {
            get;
            set;
        }
    }
}