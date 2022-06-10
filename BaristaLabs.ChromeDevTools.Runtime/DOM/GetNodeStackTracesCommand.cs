namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Gets stack traces associated with a Node. As of now, only provides stack trace for Node creation.
    /// </summary>
    public sealed class GetNodeStackTracesCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.getNodeStackTraces";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Id of the node to get stack traces for.
        /// </summary>
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    }

    public sealed class GetNodeStackTracesCommandResponse : ICommandResponse<GetNodeStackTracesCommand>
    {
        /// <summary>
        /// Creation stack trace, if available.
        ///</summary>
        [JsonProperty("creation", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Runtime.StackTrace Creation
        {
            get;
            set;
        }
    }
}