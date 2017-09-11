namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
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
        /// Whether or not HTTP requests should be intercepted and Network.requestIntercepted events sent.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled
        {
            get;
            set;
        }
    }

    public sealed class SetRequestInterceptionEnabledCommandResponse : ICommandResponse<SetRequestInterceptionEnabledCommand>
    {
    }
}