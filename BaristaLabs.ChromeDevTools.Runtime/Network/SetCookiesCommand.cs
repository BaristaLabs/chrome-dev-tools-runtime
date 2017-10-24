namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sets given cookies.
    /// </summary>
    public sealed class SetCookiesCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Network.setCookies";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Cookies to be set.
        /// </summary>
        [JsonProperty("cookies")]
        public CookieParam[] Cookies
        {
            get;
            set;
        }
    }

    public sealed class SetCookiesCommandResponse : ICommandResponse<SetCookiesCommand>
    {
    }
}