namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Starts sending each frame using the &lt;code&gt;screencastFrame&lt;/code&gt; event.
    /// </summary>
    public sealed class StartScreencastCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.startScreencast";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Image compression format.
        /// </summary>
        [JsonProperty("format", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Format
        {
            get;
            set;
        }
        /// <summary>
        /// Compression quality from range [0..100].
        /// </summary>
        [JsonProperty("quality", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? Quality
        {
            get;
            set;
        }
        /// <summary>
        /// Maximum screenshot width.
        /// </summary>
        [JsonProperty("maxWidth", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? MaxWidth
        {
            get;
            set;
        }
        /// <summary>
        /// Maximum screenshot height.
        /// </summary>
        [JsonProperty("maxHeight", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? MaxHeight
        {
            get;
            set;
        }
        /// <summary>
        /// Send every n-th frame.
        /// </summary>
        [JsonProperty("everyNthFrame", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? EveryNthFrame
        {
            get;
            set;
        }
    }

    public sealed class StartScreencastCommandResponse : ICommandResponse<StartScreencastCommand>
    {
    }
}