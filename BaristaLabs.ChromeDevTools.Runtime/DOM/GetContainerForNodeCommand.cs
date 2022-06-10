namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns the container of the given node based on container query conditions.
    /// If containerName is given, it will find the nearest container with a matching name;
    /// otherwise it will find the nearest container regardless of its container name.
    /// </summary>
    public sealed class GetContainerForNodeCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.getContainerForNode";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the nodeId
        /// </summary>
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the containerName
        /// </summary>
        [JsonProperty("containerName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ContainerName
        {
            get;
            set;
        }
    }

    public sealed class GetContainerForNodeCommandResponse : ICommandResponse<GetContainerForNodeCommand>
    {
        /// <summary>
        /// The container node for the given node, or null if not found.
        ///</summary>
        [JsonProperty("nodeId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? NodeId
        {
            get;
            set;
        }
    }
}