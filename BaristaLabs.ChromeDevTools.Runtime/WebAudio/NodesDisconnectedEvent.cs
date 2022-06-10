namespace BaristaLabs.ChromeDevTools.Runtime.WebAudio
{
    using Newtonsoft.Json;

    /// <summary>
    /// Notifies that AudioNodes are disconnected. The destination can be null, and it means all the outgoing connections from the source are disconnected.
    /// </summary>
    public sealed class NodesDisconnectedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the contextId
        /// </summary>
        [JsonProperty("contextId")]
        public string ContextId
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the sourceId
        /// </summary>
        [JsonProperty("sourceId")]
        public string SourceId
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the destinationId
        /// </summary>
        [JsonProperty("destinationId")]
        public string DestinationId
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the sourceOutputIndex
        /// </summary>
        [JsonProperty("sourceOutputIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? SourceOutputIndex
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the destinationInputIndex
        /// </summary>
        [JsonProperty("destinationInputIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? DestinationInputIndex
        {
            get;
            set;
        }
    }
}