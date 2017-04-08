namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns the root DOM node (and optionally the subtree) to the caller.
    /// </summary>
    public sealed class GetDocumentCommand : ICommand<GetDocumentCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.getDocument";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// The maximum depth at which children should be retrieved, defaults to 1. Use -1 for the entire subtree or provide an integer larger than 0.
        /// </summary>
        
        [JsonProperty("depth")]
        public long Depth
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Whether or not iframes and shadow roots should be traversed when returning the subtree (default is false).
        /// </summary>
        
        [JsonProperty("pierce")]
        public bool Pierce
        {
            get;
            set;
        }
    
    }

    public sealed class GetDocumentCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Resulting node.
        ///</summary>
        
        [JsonProperty("root")]
        public Node Root
        {
            get;
            set;
        }
    
    }
}