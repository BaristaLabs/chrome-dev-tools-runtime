namespace BaristaLabs.ChromeDevTools.Runtime.Fetch
{
    using Newtonsoft.Json;

    /// <summary>
    /// Issued when the domain is enabled and the request URL matches the
    /// specified filter. The request is paused until the client responds
    /// with one of continueRequest, failRequest or fulfillRequest.
    /// The stage of the request can be determined by presence of responseErrorReason
    /// and responseStatusCode -- the request is at the response stage if either
    /// of these fields is present and in the request stage otherwise.
    /// </summary>
    public sealed class RequestPausedEvent : IEvent
    {
        /// <summary>
        /// Each request the page makes will have a unique id.
        /// </summary>
        [JsonProperty("requestId")]
        public string RequestId
        {
            get;
            set;
        }
        /// <summary>
        /// The details of the request.
        /// </summary>
        [JsonProperty("request")]
        public Network.Request Request
        {
            get;
            set;
        }
        /// <summary>
        /// The id of the frame that initiated the request.
        /// </summary>
        [JsonProperty("frameId")]
        public string FrameId
        {
            get;
            set;
        }
        /// <summary>
        /// How the requested resource will be used.
        /// </summary>
        [JsonProperty("resourceType")]
        public Network.ResourceType ResourceType
        {
            get;
            set;
        }
        /// <summary>
        /// Response error if intercepted at response stage.
        /// </summary>
        [JsonProperty("responseErrorReason", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Network.ErrorReason ResponseErrorReason
        {
            get;
            set;
        }
        /// <summary>
        /// Response code if intercepted at response stage.
        /// </summary>
        [JsonProperty("responseStatusCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? ResponseStatusCode
        {
            get;
            set;
        }
        /// <summary>
        /// Response status text if intercepted at response stage.
        /// </summary>
        [JsonProperty("responseStatusText", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ResponseStatusText
        {
            get;
            set;
        }
        /// <summary>
        /// Response headers if intercepted at the response stage.
        /// </summary>
        [JsonProperty("responseHeaders", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public HeaderEntry[] ResponseHeaders
        {
            get;
            set;
        }
        /// <summary>
        /// If the intercepted request had a corresponding Network.requestWillBeSent event fired for it,
        /// then this networkId will be the same as the requestId present in the requestWillBeSent event.
        /// </summary>
        [JsonProperty("networkId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string NetworkId
        {
            get;
            set;
        }
    }
}