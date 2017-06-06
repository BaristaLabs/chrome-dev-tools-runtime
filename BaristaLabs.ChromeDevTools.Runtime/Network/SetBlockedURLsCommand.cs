namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Blocks URLs from loading.
    /// </summary>
    public sealed class SetBlockedURLsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Network.setBlockedURLs";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// URL patterns to block. Wildcards ('*') are allowed.
        /// </summary>
        
        [JsonProperty("urls")]
        public string[] Urls
        {
            get;
            set;
        }
    
    }

    public sealed class SetBlockedURLsCommandResponse : ICommandResponse<SetBlockedURLsCommand>
    {
    
    }
}