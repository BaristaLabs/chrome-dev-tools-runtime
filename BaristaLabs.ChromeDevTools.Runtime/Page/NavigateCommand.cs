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
        /// <summary>
        /// Intended transition type.
        /// </summary>
        [JsonProperty("transitionType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public TransitionType? TransitionType
        {
            get;
            set;
        }
        /// <summary>
        /// Frame id to navigate, if not specified navigates the top frame.
        /// </summary>
        [JsonProperty("frameId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FrameId
        {
            get;
            set;
        }
    }

    public sealed class NavigateCommandResponse : ICommandResponse<NavigateCommand>
    {
        /// <summary>
        /// Frame id that has navigated (or failed to navigate)
        ///</summary>
        [JsonProperty("frameId")]
        public string FrameId
        {
            get;
            set;
        }
        /// <summary>
        /// Loader identifier.
        ///</summary>
        [JsonProperty("loaderId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LoaderId
        {
            get;
            set;
        }
        /// <summary>
        /// User friendly error message, present if and only if navigation has failed.
        ///</summary>
        [JsonProperty("errorText", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ErrorText
        {
            get;
            set;
        }
    }
}