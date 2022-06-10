namespace BaristaLabs.ChromeDevTools.Runtime.WebAudio
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fetch the realtime data from the registered contexts.
    /// </summary>
    public sealed class GetRealtimeDataCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "WebAudio.getRealtimeData";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the contextId
        /// </summary>
        [JsonProperty("contextId")]
        public string ContextId
        {
            get;
            set;
        }
    }

    public sealed class GetRealtimeDataCommandResponse : ICommandResponse<GetRealtimeDataCommand>
    {
        /// <summary>
        /// Gets or sets the realtimeData
        /// </summary>
        [JsonProperty("realtimeData")]
        public ContextRealtimeData RealtimeData
        {
            get;
            set;
        }
    }
}