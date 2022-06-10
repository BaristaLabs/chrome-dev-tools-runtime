namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// Highlights owner element of all frames detected to be ads.
    /// </summary>
    public sealed class SetShowAdHighlightsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Overlay.setShowAdHighlights";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// True for showing ad highlights
        /// </summary>
        [JsonProperty("show")]
        public bool Show
        {
            get;
            set;
        }
    }

    public sealed class SetShowAdHighlightsCommandResponse : ICommandResponse<SetShowAdHighlightsCommand>
    {
    }
}