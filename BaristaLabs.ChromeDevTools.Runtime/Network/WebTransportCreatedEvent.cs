namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired upon WebTransport creation.
    /// </summary>
    public sealed class WebTransportCreatedEvent : IEvent
    {
        /// <summary>
        /// WebTransport identifier.
        /// </summary>
        [JsonProperty("transportId")]
        public string TransportId
        {
            get;
            set;
        }
        /// <summary>
        /// WebTransport request URL.
        /// </summary>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
        /// <summary>
        /// Timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        public double Timestamp
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