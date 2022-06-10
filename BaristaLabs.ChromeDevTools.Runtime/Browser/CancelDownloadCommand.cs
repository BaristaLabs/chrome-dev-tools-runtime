namespace BaristaLabs.ChromeDevTools.Runtime.Browser
{
    using Newtonsoft.Json;

    /// <summary>
    /// Cancel a download if in progress
    /// </summary>
    public sealed class CancelDownloadCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Browser.cancelDownload";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Global unique identifier of the download.
        /// </summary>
        [JsonProperty("guid")]
        public string Guid
        {
            get;
            set;
        }
        /// <summary>
        /// BrowserContext to perform the action in. When omitted, default browser context is used.
        /// </summary>
        [JsonProperty("browserContextId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BrowserContextId
        {
            get;
            set;
        }
    }

    public sealed class CancelDownloadCommandResponse : ICommandResponse<CancelDownloadCommand>
    {
    }
}