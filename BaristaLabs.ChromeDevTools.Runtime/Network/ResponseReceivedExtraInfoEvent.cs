namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when additional information about a responseReceived event is available from the network
    /// stack. Not every responseReceived event will have an additional responseReceivedExtraInfo for
    /// it, and responseReceivedExtraInfo may be fired before or after responseReceived.
    /// </summary>
    public sealed class ResponseReceivedExtraInfoEvent : IEvent
    {
        /// <summary>
        /// Request identifier. Used to match this information to another responseReceived event.
        /// </summary>
        [JsonProperty("requestId")]
        public string RequestId
        {
            get;
            set;
        }
        /// <summary>
        /// A list of cookies which were not stored from the response along with the corresponding
        /// reasons for blocking. The cookies here may not be valid due to syntax errors, which
        /// are represented by the invalid cookie line string instead of a proper cookie.
        /// </summary>
        [JsonProperty("blockedCookies")]
        public BlockedSetCookieWithReason[] BlockedCookies
        {
            get;
            set;
        }
        /// <summary>
        /// Raw response headers as they were received over the wire.
        /// </summary>
        [JsonProperty("headers")]
        public Headers Headers
        {
            get;
            set;
        }
        /// <summary>
        /// The IP address space of the resource. The address space can only be determined once the transport
        /// established the connection, so we can't send it in `requestWillBeSentExtraInfo`.
        /// </summary>
        [JsonProperty("resourceIPAddressSpace")]
        public IPAddressSpace ResourceIPAddressSpace
        {
            get;
            set;
        }
        /// <summary>
        /// The status code of the response. This is useful in cases the request failed and no responseReceived
        /// event is triggered, which is the case for, e.g., CORS errors. This is also the correct status code
        /// for cached requests, where the status in responseReceived is a 200 and this will be 304.
        /// </summary>
        [JsonProperty("statusCode")]
        public long StatusCode
        {
            get;
            set;
        }
        /// <summary>
        /// Raw response header text as it was received over the wire. The raw text may not always be
        /// available, such as in the case of HTTP/2 or QUIC.
        /// </summary>
        [JsonProperty("headersText", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string HeadersText
        {
            get;
            set;
        }
    }
}