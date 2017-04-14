namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class GetAppManifestCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.getAppManifest";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class GetAppManifestCommandResponse : ICommandResponse<GetAppManifestCommand>
    {
    
        
        /// <summary>
        /// Manifest location.
        ///</summary>
        
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the errors
        /// </summary>
        
        [JsonProperty("errors")]
        public AppManifestError[] Errors
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Manifest content.
        ///</summary>
        
        [JsonProperty("data, DefaultValueHandling = DefaultValueHandling.Ignore")]
        public string Data
        {
            get;
            set;
        }
    
    }
}