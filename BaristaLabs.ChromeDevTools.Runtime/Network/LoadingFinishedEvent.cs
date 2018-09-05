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
        /// Set when 1) response was blocked by Cross-Origin Read Blocking and also
        /// 2) this needs to be reported to the DevTools console.
        /// </summary>
        [JsonProperty("shouldReportCorbBlocking", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? ShouldReportCorbBlocking
        {
            get;
            set;
        }
    }
}