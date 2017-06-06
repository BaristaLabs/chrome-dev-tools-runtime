namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns node id at given location.
    /// </summary>
    public sealed class GetNodeForLocationCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.getNodeForLocation";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// X coordinate.
        /// </summary>
        
        [JsonProperty("x")]
        public long X
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Y coordinate.
        /// </summary>
        
        [JsonProperty("y")]
        public long Y
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// False to skip to the nearest non-UA shadow root ancestor (default: false).
        /// </summary>
        
        [JsonProperty("includeUserAgentShadowDOM", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? IncludeUserAgentShadowDOM
        {
            get;
            set;
        }
    
    }

    public sealed class GetNodeForLocationCommandResponse : ICommandResponse<GetNodeForLocationCommand>
    {
    
        
        /// <summary>
        /// Id of the node at given coordinates.
        ///</summary>
        
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    
    }
}