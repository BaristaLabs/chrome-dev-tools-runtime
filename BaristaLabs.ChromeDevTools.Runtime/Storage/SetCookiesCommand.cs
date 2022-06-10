namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sets given cookies.
    /// </summary>
    public sealed class SetCookiesCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Storage.setCookies";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Cookies to be set.
        /// </summary>
        [JsonProperty("cookies")]
        public Network.CookieParam[] Cookies
        {
            get;
            set;
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

    public sealed class SetCookiesCommandResponse : ICommandResponse<SetCookiesCommand>
    {
    }
}