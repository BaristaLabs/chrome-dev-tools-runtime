namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Highlights DOM node with given id or with the given JavaScript object wrapper. Either nodeId or objectId must be specified.
    /// </summary>
    public sealed class HighlightNodeCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.highlightNode";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// A descriptor for the highlight appearance.
        /// </summary>
        
        [JsonProperty("highlightConfig")]
        public HighlightConfig HighlightConfig
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

    public sealed class HighlightNodeCommandResponse : ICommandResponse<HighlightNodeCommand>
    {
    
    }
}