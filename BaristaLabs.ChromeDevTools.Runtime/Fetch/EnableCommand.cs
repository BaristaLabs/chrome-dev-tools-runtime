namespace BaristaLabs.ChromeDevTools.Runtime.Fetch
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enables issuing of requestPaused events. A request will be paused until client
    /// calls one of failRequest, fulfillRequest or continueRequest/continueWithAuth.
    /// </summary>
    public sealed class EnableCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Fetch.enable";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// If specified, only requests matching any of these patterns will produce
        /// fetchRequested event and will be paused until clients response. If not set,
        /// all requests will be affected.
        /// </summary>
        [JsonProperty("patterns", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public RequestPattern[] Patterns
        {
            get;
            set;
        }
        /// <summary>
        /// If true, authRequired events will be issued and requests will be paused
        /// expecting a call to continueWithAuth.
        /// </summary>
        [JsonProperty("handleAuthRequests", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? HandleAuthRequests
        {
            get;
            set;
        }
    }

    public sealed class EnableCommandResponse : ICommandResponse<EnableCommand>
    {
    }
}