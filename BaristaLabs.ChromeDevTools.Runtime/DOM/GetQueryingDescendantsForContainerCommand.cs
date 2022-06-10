namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns the descendants of a container query container that have
    /// container queries against this container.
    /// </summary>
    public sealed class GetQueryingDescendantsForContainerCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.getQueryingDescendantsForContainer";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Id of the container node to find querying descendants from.
        /// </summary>
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    }

    public sealed class GetQueryingDescendantsForContainerCommandResponse : ICommandResponse<GetQueryingDescendantsForContainerCommand>
    {
        /// <summary>
        /// Descendant nodes with container queries against the given container.
        ///</summary>
        [JsonProperty("nodeIds")]
        public long[] NodeIds
        {
            get;
            set;
        }
    }
}