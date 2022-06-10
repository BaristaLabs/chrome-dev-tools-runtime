namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when WebTransport handshake is finished.
    /// </summary>
    public sealed class WebTransportConnectionEstablishedEvent : IEvent
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
        /// Timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        public double Timestamp
        {
            get;
            set;
        }
    }
}