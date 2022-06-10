namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// For testing.
    /// </summary>
    public sealed class GetHighlightObjectForTestCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Overlay.getHighlightObjectForTest";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Id of the node to get highlight object for.
        /// </summary>
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
        /// <summary>
        /// Whether to include distance info.
        /// </summary>
        [JsonProperty("includeDistance", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? IncludeDistance
        {
            get;
            set;
        }
        /// <summary>
        /// Whether to include style info.
        /// </summary>
        [JsonProperty("includeStyle", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? IncludeStyle
        {
            get;
            set;
        }
        /// <summary>
        /// The color format to get config with (default: hex).
        /// </summary>
        [JsonProperty("colorFormat", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ColorFormat? ColorFormat
        {
            get;
            set;
        }
        /// <summary>
        /// Whether to show accessibility info (default: true).
        /// </summary>
        [JsonProperty("showAccessibilityInfo", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? ShowAccessibilityInfo
        {
            get;
            set;
        }
    }

    public sealed class GetHighlightObjectForTestCommandResponse : ICommandResponse<GetHighlightObjectForTestCommand>
    {
        /// <summary>
        /// Highlight data for the node.
        ///</summary>
        [JsonProperty("highlight")]
        public object Highlight
        {
            get;
            set;
        }
    }
}