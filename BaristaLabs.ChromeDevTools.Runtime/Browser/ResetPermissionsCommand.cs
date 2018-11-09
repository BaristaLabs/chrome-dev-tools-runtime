namespace BaristaLabs.ChromeDevTools.Runtime.Browser
{
    using Newtonsoft.Json;

    /// <summary>
    /// Reset all permission management for all origins.
    /// </summary>
    public sealed class ResetPermissionsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Browser.resetPermissions";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// BrowserContext to reset permissions. When omitted, default browser context is used.
        /// </summary>
        [JsonProperty("browserContextId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BrowserContextId
        {
            get;
            set;
        }
    }

    public sealed class ResetPermissionsCommandResponse : ICommandResponse<ResetPermissionsCommand>
    {
    }
}