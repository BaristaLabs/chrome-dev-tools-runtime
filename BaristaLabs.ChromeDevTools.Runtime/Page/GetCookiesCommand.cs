namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns all browser cookies. Depending on the backend support, will return detailed cookie information in the <code>cookies</code> field.
    /// </summary>
    public sealed class GetCookiesCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.getCookies";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
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