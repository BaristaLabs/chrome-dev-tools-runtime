namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns all browser contexts created with `Target.createBrowserContext` method.
    /// </summary>
    public sealed class GetBrowserContextsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Target.getBrowserContexts";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class GetBrowserContextsCommandResponse : ICommandResponse<GetBrowserContextsCommand>
    {
        /// <summary>
        /// An array of browser context ids.
        ///</summary>
        [JsonProperty("browserContextIds")]
        public string[] BrowserContextIds
        {
            get;
            set;
        }
    }
}