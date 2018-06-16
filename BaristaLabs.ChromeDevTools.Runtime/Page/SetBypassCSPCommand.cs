namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enable page Content Security Policy by-passing.
    /// </summary>
    public sealed class SetBypassCSPCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.setBypassCSP";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Whether to bypass page CSP.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled
        {
            get;
            set;
        }
    }

    public sealed class SetBypassCSPCommandResponse : ICommandResponse<SetBypassCSPCommand>
    {
    }
}