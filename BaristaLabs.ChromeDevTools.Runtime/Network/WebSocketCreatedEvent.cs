namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired upon WebSocket creation.
    /// </summary>
    public sealed class WebSocketCreatedEvent : IEvent
    {
        /// <summary>
        /// Request identifier.
        /// </summary>
        [JsonProperty("requestId")]
        public string RequestId
        {
            get;
            set;
        }
        /// <summary>
        /// WebSocket request URL.
        /// </summary>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
        /// <summary>
        /// Request initiator.
        /// </summary>
        [JsonProperty("initiator", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Initiator Initiator
        {
            get;
            set;
        }
    }
}