namespace BaristaLabs.ChromeDevTools.Runtime.Browser
{
    using Newtonsoft.Json;

    /// <summary>
    /// Set the behavior when downloading a file.
    /// </summary>
    public sealed class SetDownloadBehaviorCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Browser.setDownloadBehavior";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Whether to allow all or deny all download requests, or use default Chrome behavior if
        /// available (otherwise deny). |allowAndName| allows download and names files according to
        /// their dowmload guids.
        /// </summary>
        [JsonProperty("behavior")]
        public string Behavior
        {
            get;
            set;
        }
        /// <summary>
        /// BrowserContext to set download behavior. When omitted, default browser context is used.
        /// </summary>
        [JsonProperty("browserContextId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BrowserContextId
        {
            get;
            set;
        }
        /// <summary>
        /// The default path to save downloaded files to. This is required if behavior is set to 'allow'
        /// or 'allowAndName'.
        /// </summary>
        [JsonProperty("downloadPath", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string DownloadPath
        {
            get;
            set;
        }
        /// <summary>
        /// Whether to emit download events (defaults to false).
        /// </summary>
        [JsonProperty("eventsEnabled", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? EventsEnabled
        {
            get;
            set;
        }
    }

    public sealed class SetDownloadBehaviorCommandResponse : ICommandResponse<SetDownloadBehaviorCommand>
    {
    }
}