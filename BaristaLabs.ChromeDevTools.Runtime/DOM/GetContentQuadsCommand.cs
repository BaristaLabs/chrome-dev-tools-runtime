namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns quads that describe node position on the page. This method
    /// might return multiple quads for inline nodes.
    /// </summary>
    public sealed class GetContentQuadsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.getContentQuads";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Identifier of the node.
        /// </summary>
        [JsonProperty("nodeId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? NodeId
        {
            get;
            set;
        }
        /// <summary>
        /// Identifier of the backend node.
        /// </summary>
        [JsonProperty("backendNodeId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? BackendNodeId
        {
            get;
            set;
        }
        /// <summary>
        /// JavaScript object id of the node wrapper.
        /// </summary>
        [JsonProperty("objectId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ObjectId
        {
            get;
            set;
        }
    }

    public sealed class GetContentQuadsCommandResponse : ICommandResponse<GetContentQuadsCommand>
    {
        /// <summary>
        /// Quads that describe node layout relative to viewport.
        ///</summary>
        [JsonProperty("quads")]
        public double[][] Quads
        {
            get;
            set;
        }
    }
}