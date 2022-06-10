namespace BaristaLabs.ChromeDevTools.Runtime.WebAudio
{
    using Newtonsoft.Json;

    /// <summary>
    /// Notifies that an AudioNode is disconnected to an AudioParam.
    /// </summary>
    public sealed class NodeParamDisconnectedEvent : IEvent
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
    }
}