namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Executes &lt;code&gt;querySelectorAll&lt;/code&gt; on a given node.
    /// </summary>
    public sealed class QuerySelectorAllCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.querySelectorAll";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Id of the node to query upon.
        /// </summary>
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
        /// <summary>
        /// Selector string.
        /// </summary>
        [JsonProperty("selector")]
        public string Selector
        {
            get;
            set;
        }
    }

    public sealed class QuerySelectorAllCommandResponse : ICommandResponse<QuerySelectorAllCommand>
    {
        /// <summary>
        /// Query selector result.
        ///</summary>
        [JsonProperty("nodeIds")]
        public long[] NodeIds
        {
            get;
            set;
        }
    }
}