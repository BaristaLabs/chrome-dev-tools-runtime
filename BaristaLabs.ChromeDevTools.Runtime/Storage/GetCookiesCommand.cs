namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns all browser cookies.
    /// </summary>
    public sealed class GetCookiesCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Storage.getCookies";
        
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

    public sealed class GetCookiesCommandResponse : ICommandResponse<GetCookiesCommand>
    {
        /// <summary>
        /// Array of cookie objects.
        ///</summary>
        [JsonProperty("cookies")]
        public Network.Cookie[] Cookies
        {
            get;
            set;
        }
    }
}