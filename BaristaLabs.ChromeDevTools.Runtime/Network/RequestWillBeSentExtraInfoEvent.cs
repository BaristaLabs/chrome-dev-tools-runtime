namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when additional information about a requestWillBeSent event is available from the
    /// network stack. Not every requestWillBeSent event will have an additional
    /// requestWillBeSentExtraInfo fired for it, and there is no guarantee whether requestWillBeSent
    /// or requestWillBeSentExtraInfo will be fired first for the same request.
    /// </summary>
    public sealed class RequestWillBeSentExtraInfoEvent : IEvent
    {
        /// <summary>
        /// Request identifier. Used to match this information to an existing requestWillBeSent event.
        /// </summary>
        [JsonProperty("requestId")]
        public string RequestId
        {
            get;
            set;
        }
        /// <summary>
        /// A list of cookies potentially associated to the requested URL. This includes both cookies sent with
        /// the request and the ones not sent; the latter are distinguished by having blockedReason field set.
        /// </summary>
        [JsonProperty("associatedCookies")]
        public BlockedCookieWithReason[] AssociatedCookies
        {
            get;
            set;
        }
        /// <summary>
        /// Raw request headers as they will be sent over the wire.
        /// </summary>
        [JsonProperty("headers")]
        public Headers Headers
        {
            get;
            set;
        }
        /// <summary>
        /// Connection timing information for the request.
        /// </summary>
        [JsonProperty("connectTiming")]
        public ConnectTiming ConnectTiming
        {
            get;
            set;
        }
        /// <summary>
        /// The client security state set for the request.
        /// </summary>
        [JsonProperty("clientSecurityState", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ClientSecurityState ClientSecurityState
        {
            get;
            set;
        }
    }
}