namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Navigates current page to the given URL.
    /// </summary>
    public sealed class NavigateCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.navigate";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// URL to navigate the page to.
        /// </summary>
        
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Referrer URL.
        /// </summary>
        
        [JsonProperty("referrer", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Referrer
        {
            get;
            set;
        }
    
    }

    public sealed class NavigateCommandResponse : ICommandResponse<NavigateCommand>
    {
    
        
        /// <summary>
        /// Frame id that will be navigated.
        ///</summary>
        
        [JsonProperty("frameId")]
        public string FrameId
        {
            get;
            set;
        }
    
    }
}