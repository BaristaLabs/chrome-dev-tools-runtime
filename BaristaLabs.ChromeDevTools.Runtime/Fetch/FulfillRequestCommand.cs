namespace BaristaLabs.ChromeDevTools.Runtime.Fetch
{
    using Newtonsoft.Json;

    /// <summary>
    /// Provides response to the request.
    /// </summary>
    public sealed class FulfillRequestCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Fetch.fulfillRequest";
        
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
        /// An HTTP response code.
        /// </summary>
        [JsonProperty("responseCode")]
        public long ResponseCode
        {
            get;
            set;
        }
        /// <summary>
        /// Response headers.
        /// </summary>
        [JsonProperty("responseHeaders", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public HeaderEntry[] ResponseHeaders
        {
            get;
            set;
        }
        /// <summary>
        /// Alternative way of specifying response headers as a \0-separated
        /// series of name: value pairs. Prefer the above method unless you
        /// need to represent some non-UTF8 values that can't be transmitted
        /// over the protocol as text.
        /// </summary>
        [JsonProperty("binaryResponseHeaders", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public byte[] BinaryResponseHeaders
        {
            get;
            set;
        }
        /// <summary>
        /// A response body. If absent, original response body will be used if
        /// the request is intercepted at the response stage and empty body
        /// will be used if the request is intercepted at the request stage.
        /// </summary>
        [JsonProperty("body", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public byte[] Body
        {
            get;
            set;
        }
        /// <summary>
        /// A textual representation of responseCode.
        /// If absent, a standard phrase matching responseCode is used.
        /// </summary>
        [JsonProperty("responsePhrase", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ResponsePhrase
        {
            get;
            set;
        }
    }

    public sealed class FulfillRequestCommandResponse : ICommandResponse<FulfillRequestCommand>
    {
    }
}