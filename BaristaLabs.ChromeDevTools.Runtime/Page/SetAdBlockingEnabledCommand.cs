namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enable Chrome's experimental ad filter on all sites.
    /// </summary>
    public sealed class SetAdBlockingEnabledCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.setAdBlockingEnabled";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Whether to block ads.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled
        {
            get;
            set;
        }
    }

    public sealed class SetAdBlockingEnabledCommandResponse : ICommandResponse<SetAdBlockingEnabledCommand>
    {
    }
}