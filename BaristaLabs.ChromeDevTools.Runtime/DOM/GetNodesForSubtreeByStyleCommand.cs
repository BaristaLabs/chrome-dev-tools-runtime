namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Finds nodes with a given computed style in a subtree.
    /// </summary>
    public sealed class GetNodesForSubtreeByStyleCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.getNodesForSubtreeByStyle";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Node ID pointing to the root of a subtree.
        /// </summary>
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
        /// <summary>
        /// The style to filter nodes by (includes nodes if any of properties matches).
        /// </summary>
        [JsonProperty("computedStyles")]
        public CSSComputedStyleProperty[] ComputedStyles
        {
            get;
            set;
        }
        /// <summary>
        /// Whether or not iframes and shadow roots in the same target should be traversed when returning the
        /// results (default is false).
        /// </summary>
        [JsonProperty("pierce", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Pierce
        {
            get;
            set;
        }
    }

    public sealed class GetNodesForSubtreeByStyleCommandResponse : ICommandResponse<GetNodesForSubtreeByStyleCommand>
    {
        /// <summary>
        /// Resulting nodes.
        ///</summary>
        [JsonProperty("nodeIds")]
        public long[] NodeIds
        {
            get;
            set;
        }
    }
}