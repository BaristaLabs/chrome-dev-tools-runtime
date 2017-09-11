namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Details of an intercepted HTTP request, which must be either allowed, blocked, modified or mocked.
    /// </summary>
    public sealed class RequestInterceptedEvent : IEvent
    {
        /// <summary>
        /// Each request the page makes will have a unique id, however if any redirects are encountered while processing that fetch, they will be reported with the same id as the original fetch. Likewise if HTTP authentication is needed then the same fetch id will be used.
        /// </summary>
        [JsonProperty("interceptionId")]
        public string InterceptionId
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the request
        /// </summary>
        [JsonProperty("request")]
        public Request Request
        {
            get;
            set;
        }
        /// <summary>
        /// How the requested resource will be used.
        /// </summary>
        [JsonProperty("resourceType")]
        public Page.ResourceType ResourceType
        {
            get;
            set;
        }
        /// <summary>
        /// HTTP response headers, only sent if a redirect was intercepted.
        /// </summary>
        [JsonProperty("redirectHeaders", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Headers RedirectHeaders
        {
            get;
            set;
        }
        /// <summary>
        /// HTTP response code, only sent if a redirect was intercepted.
        /// </summary>
        [JsonProperty("redirectStatusCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? RedirectStatusCode
        {
            get;
            set;
        }
        /// <summary>
        /// Redirect location, only sent if a redirect was intercepted.
        /// </summary>
        [JsonProperty("redirectUrl", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RedirectUrl
        {
            get;
            set;
        }
        /// <summary>
        /// Details of the Authorization Challenge encountered. If this is set then continueInterceptedRequest must contain an authChallengeResponse.
        /// </summary>
        [JsonProperty("authChallenge", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AuthChallenge AuthChallenge
        {
            get;
            set;
        }
    }
}