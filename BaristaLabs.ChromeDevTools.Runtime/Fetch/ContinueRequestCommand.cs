namespace BaristaLabs.ChromeDevTools.Runtime.Fetch
{
    using Newtonsoft.Json;

    /// <summary>
    /// Continues the request, optionally modifying some of its parameters.
    /// </summary>
    public sealed class ContinueRequestCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Fetch.continueRequest";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// An id the client received in requestPaused event.
        /// </summary>
        [JsonProperty("requestId")]
        public string RequestId
        {
            get;
            set;
        }
        /// <summary>
        /// If set, the request url will be modified in a way that's not observable by page.
        /// </summary>
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Url
        {
            get;
            set;
        }
        /// <summary>
        /// If set, the request method is overridden.
        /// </summary>
        [JsonProperty("method", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Method
        {
            get;
            set;
        }
        /// <summary>
        /// If set, overrides the post data in the request.
        /// </summary>
        [JsonProperty("postData", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public byte[] PostData
        {
            get;
            set;
        }
        /// <summary>
        /// If set, overrides the request headers.
        /// </summary>
        [JsonProperty("headers", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public HeaderEntry[] Headers
        {
            get;
            set;
        }
        /// <summary>
        /// If set, overrides response interception behavior for this request.
        /// </summary>
        [JsonProperty("interceptResponse", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? InterceptResponse
        {
            get;
            set;
        }
    }

    public sealed class ContinueRequestCommandResponse : ICommandResponse<ContinueRequestCommand>
    {
    }
}