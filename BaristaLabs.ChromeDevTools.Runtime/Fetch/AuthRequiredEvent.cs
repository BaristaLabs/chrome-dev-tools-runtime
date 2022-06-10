namespace BaristaLabs.ChromeDevTools.Runtime.Fetch
{
    using Newtonsoft.Json;

    /// <summary>
    /// Issued when the domain is enabled with handleAuthRequests set to true.
    /// The request is paused until client responds with continueWithAuth.
    /// </summary>
    public sealed class AuthRequiredEvent : IEvent
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
        /// Details of the Authorization Challenge encountered.
        /// If this is set, client should respond with continueRequest that
        /// contains AuthChallengeResponse.
        /// </summary>
        [JsonProperty("authChallenge")]
        public AuthChallenge AuthChallenge
        {
            get;
            set;
        }
    }
}