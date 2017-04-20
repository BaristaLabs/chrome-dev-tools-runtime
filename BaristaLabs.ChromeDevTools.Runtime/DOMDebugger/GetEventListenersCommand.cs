namespace BaristaLabs.ChromeDevTools.Runtime.DOMDebugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns event listeners of the given object.
    /// </summary>
    public sealed class GetEventListenersCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "DOMDebugger.getEventListeners";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Identifier of the object to return listeners for.
        /// </summary>
        
        [JsonProperty("objectId")]
        public string ObjectId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// The maximum depth at which Node children should be retrieved, defaults to 1. Use -1 for the entire subtree or provide an integer larger than 0.
        /// </summary>
        
        [JsonProperty("depth", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? Depth
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Whether or not iframes and shadow roots should be traversed when returning the subtree (default is false). Reports listeners for all contexts if pierce is enabled.
        /// </summary>
        
        [JsonProperty("pierce", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Pierce
        {
            get;
            set;
        }
    
    }

    public sealed class GetEventListenersCommandResponse : ICommandResponse<GetEventListenersCommand>
    {
    
        
        /// <summary>
        /// Array of relevant listeners.
        ///</summary>
        
        [JsonProperty("listeners")]
        public EventListener[] Listeners
        {
            get;
            set;
        }
    
    }
}