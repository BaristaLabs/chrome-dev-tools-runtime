namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    using Newtonsoft.Json;

    /// <summary>
    /// Query a DOM node's accessibility subtree for accessible name and role.
    /// This command computes the name and role for all nodes in the subtree, including those that are
    /// ignored for accessibility, and returns those that mactch the specified name and role. If no DOM
    /// node is specified, or the DOM node does not exist, the command returns an error. If neither
    /// `accessibleName` or `role` is specified, it returns all the accessibility nodes in the subtree.
    /// </summary>
    public sealed class QueryAXTreeCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Accessibility.queryAXTree";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Identifier of the node for the root to query.
        /// </summary>
        [JsonProperty("nodeId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? NodeId
        {
            get;
            set;
        }
        /// <summary>
        /// Identifier of the backend node for the root to query.
        /// </summary>
        [JsonProperty("backendNodeId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? BackendNodeId
        {
            get;
            set;
        }
        /// <summary>
        /// JavaScript object id of the node wrapper for the root to query.
        /// </summary>
        [JsonProperty("objectId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ObjectId
        {
            get;
            set;
        }
        /// <summary>
        /// Find nodes with this computed name.
        /// </summary>
        [JsonProperty("accessibleName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AccessibleName
        {
            get;
            set;
        }
        /// <summary>
        /// Find nodes with this computed role.
        /// </summary>
        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Role
        {
            get;
            set;
        }
    }

    public sealed class QueryAXTreeCommandResponse : ICommandResponse<QueryAXTreeCommand>
    {
        /// <summary>
        /// A list of `Accessibility.AXNode` matching the specified attributes,
        /// including nodes that are ignored for accessibility.
        ///</summary>
        [JsonProperty("nodes")]
        public AXNode[] Nodes
        {
            get;
            set;
        }
    }
}