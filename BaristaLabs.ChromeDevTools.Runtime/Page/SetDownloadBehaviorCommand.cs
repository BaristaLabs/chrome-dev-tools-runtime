namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Set the behavior when downloading a file.
    /// </summary>
    public sealed class SetDownloadBehaviorCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.setDownloadBehavior";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Whether to allow all or deny all download requests, or use default Chrome behavior if available (otherwise deny).
        /// </summary>
        [JsonProperty("behavior")]
        public string Behavior
        {
            get;
            set;
        }
        /// <summary>
        /// The default path to save downloaded files to. This is requred if behavior is set to 'allow'
        /// </summary>
        [JsonProperty("downloadPath", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string DownloadPath
        {
            get;
            set;
        }
    }

    public sealed class SetDownloadBehaviorCommandResponse : ICommandResponse<SetDownloadBehaviorCommand>
    {
    }
}