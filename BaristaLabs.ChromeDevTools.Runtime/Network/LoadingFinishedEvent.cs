namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when HTTP request has finished loading.
    /// </summary>
    public sealed class LoadingFinishedEvent : IEvent
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
        /// Timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        public double Timestamp
        {
            get;
            set;
        }
        /// <summary>
        /// Total number of bytes received for this request.
        /// </summary>
        [JsonProperty("encodedDataLength")]
        public double EncodedDataLength
        {
            get;
            set;
        }
        /// <summary>
        /// Set when response was blocked due to being cross-site document response.
        /// </summary>
        [JsonProperty("blockedCrossSiteDocument", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? BlockedCrossSiteDocument
        {
            get;
            set;
        }
    }
}