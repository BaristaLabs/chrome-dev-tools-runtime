namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when a signed exchange was received over the network
    /// </summary>
    public sealed class SignedExchangeReceivedEvent : IEvent
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
        /// Information about the signed exchange response.
        /// </summary>
        [JsonProperty("info")]
        public SignedExchangeInfo Info
        {
            get;
            set;
        }
    }
}