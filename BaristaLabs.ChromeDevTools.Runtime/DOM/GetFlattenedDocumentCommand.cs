namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns the root DOM node (and optionally the subtree) to the caller.
    /// </summary>
    public sealed class GetFlattenedDocumentCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.getFlattenedDocument";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// The maximum depth at which children should be retrieved, defaults to 1. Use -1 for the entire subtree or provide an integer larger than 0.
        /// </summary>
        [JsonProperty("depth", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? Depth
        {
            get;
            set;
        }
        /// <summary>
        /// Whether or not iframes and shadow roots should be traversed when returning the subtree (default is false).
        /// </summary>
        [JsonProperty("pierce", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Pierce
        {
            get;
            set;
        }
    }

    public sealed class GetFlattenedDocumentCommandResponse : ICommandResponse<GetFlattenedDocumentCommand>
    {
        /// <summary>
        /// Resulting node.
        ///</summary>
        [JsonProperty("nodes")]
        public Node[] Nodes
        {
            get;
            set;
        }
    }
}