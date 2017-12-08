namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sets the requests to intercept that match a the provided patterns and optionally resource types.
    /// </summary>
    public sealed class SetRequestInterceptionEnabledCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Network.setRequestInterceptionEnabled";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Whether requests should be intercepted. If patterns is not set, matches all and resets any previously set patterns. Other parameters are ignored if false.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled
        {
            get;
            set;
        }
        /// <summary>
        /// URLs matching any of these patterns will be forwarded and wait for the corresponding continueInterceptedRequest call. Wildcards ('*' -&gt; zero or more, '?' -&gt; exactly one) are allowed. Escape character is backslash. If omitted equivalent to ['*'] (intercept all).
        /// </summary>
        [JsonProperty("patterns", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string[] Patterns
        {
            get;
            set;
        }
        /// <summary>
        /// If set, only requests for matching resource types will be intercepted.
        /// </summary>
        [JsonProperty("resourceTypes", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Page.ResourceType[] ResourceTypes
        {
            get;
            set;
        }
    }

    public sealed class SetRequestInterceptionEnabledCommandResponse : ICommandResponse<SetRequestInterceptionEnabledCommand>
    {
    }
}