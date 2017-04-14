namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enables network tracking, network events will now be delivered to the client.
    /// </summary>
    public sealed class EnableCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Network.enable";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Buffer size in bytes to use when preserving network payloads (XHRs, etc).
        /// </summary>
        
        [JsonProperty("maxTotalBufferSize", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? MaxTotalBufferSize
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Per-resource buffer size in bytes to use when preserving network payloads (XHRs, etc).
        /// </summary>
        
        [JsonProperty("maxResourceBufferSize", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? MaxResourceBufferSize
        {
            get;
            set;
        }
    
    }

    public sealed class EnableCommandResponse : ICommandResponse<EnableCommand>
    {
    
    }
}