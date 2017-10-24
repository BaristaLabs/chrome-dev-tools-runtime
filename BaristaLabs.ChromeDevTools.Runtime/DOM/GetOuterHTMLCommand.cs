namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns node's HTML markup.
    /// </summary>
    public sealed class GetOuterHTMLCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.getOuterHTML";
        
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

    public sealed class GetOuterHTMLCommandResponse : ICommandResponse<GetOuterHTMLCommand>
    {
        /// <summary>
        /// Outer HTML markup.
        ///</summary>
        [JsonProperty("outerHTML")]
        public string OuterHTML
        {
            get;
            set;
        }
    }
}