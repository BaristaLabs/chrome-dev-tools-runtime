namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// Request that backend shows an overlay with web vital metrics.
    /// </summary>
    public sealed class SetShowWebVitalsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Overlay.setShowWebVitals";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the show
        /// </summary>
        [JsonProperty("show")]
        public bool Show
        {
            get;
            set;
        }
    }

    public sealed class SetShowWebVitalsCommandResponse : ICommandResponse<SetShowWebVitalsCommand>
    {
    }
}