namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// Requests that backend shows scroll bottleneck rects
    /// </summary>
    public sealed class SetShowScrollBottleneckRectsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Overlay.setShowScrollBottleneckRects";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// True for showing scroll bottleneck rects
        /// </summary>
        [JsonProperty("show")]
        public bool Show
        {
            get;
            set;
        }
    }

    public sealed class SetShowScrollBottleneckRectsCommandResponse : ICommandResponse<SetShowScrollBottleneckRectsCommand>
    {
    }
}