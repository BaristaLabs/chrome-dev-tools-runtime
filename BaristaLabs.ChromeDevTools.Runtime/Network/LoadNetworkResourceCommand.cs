namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fetches the resource and returns the content.
    /// </summary>
    public sealed class LoadNetworkResourceCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Network.loadNetworkResource";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Frame id to get the resource for. Mandatory for frame targets, and
        /// should be omitted for worker targets.
        /// </summary>
        [JsonProperty("frameId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FrameId
        {
            get;
            set;
        }
        /// <summary>
        /// URL of the resource to get content for.
        /// </summary>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
        /// <summary>
        /// Options for the request.
        /// </summary>
        [JsonProperty("options")]
        public LoadNetworkResourceOptions Options
        {
            get;
            set;
        }
    }

    public sealed class LoadNetworkResourceCommandResponse : ICommandResponse<LoadNetworkResourceCommand>
    {
        /// <summary>
        /// Gets or sets the resource
        /// </summary>
        [JsonProperty("resource")]
        public LoadNetworkResourcePageResult Resource
        {
            get;
            set;
        }
    }
}