namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Clears cookies.
    /// </summary>
    public sealed class ClearCookiesCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Storage.clearCookies";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Browser context to use when called on the browser endpoint.
        /// </summary>
        [JsonProperty("browserContextId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BrowserContextId
        {
            get;
            set;
        }
    }

    public sealed class ClearCookiesCommandResponse : ICommandResponse<ClearCookiesCommand>
    {
    }
}