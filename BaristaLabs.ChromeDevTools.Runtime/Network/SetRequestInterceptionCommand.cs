namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sets the requests to intercept that match the provided patterns and optionally resource types.
    /// Deprecated, please use Fetch.enable instead.
    /// </summary>
    public sealed class SetRequestInterceptionCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Network.setRequestInterception";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Requests matching any of these patterns will be forwarded and wait for the corresponding
        /// continueInterceptedRequest call.
        /// </summary>
        [JsonProperty("patterns")]
        public RequestPattern[] Patterns
        {
            get;
            set;
        }
    }

    public sealed class SetRequestInterceptionCommandResponse : ICommandResponse<SetRequestInterceptionCommand>
    {
    }
}