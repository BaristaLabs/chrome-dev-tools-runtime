namespace BaristaLabs.ChromeDevTools.Runtime.Fetch
{
    using Newtonsoft.Json;

    /// <summary>
    /// Causes the body of the response to be received from the server and
    /// returned as a single string. May only be issued for a request that
    /// is paused in the Response stage and is mutually exclusive with
    /// takeResponseBodyForInterceptionAsStream. Calling other methods that
    /// affect the request or disabling fetch domain before body is received
    /// results in an undefined behavior.
    /// </summary>
    public sealed class GetResponseBodyCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Fetch.getResponseBody";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Identifier for the intercepted request to get body for.
        /// </summary>
        [JsonProperty("requestId")]
        public string RequestId
        {
            get;
            set;
        }
    }

    public sealed class GetResponseBodyCommandResponse : ICommandResponse<GetResponseBodyCommand>
    {
        /// <summary>
        /// Response body.
        ///</summary>
        [JsonProperty("body")]
        public string Body
        {
            get;
            set;
        }
        /// <summary>
        /// True, if content was sent as base64.
        ///</summary>
        [JsonProperty("base64Encoded")]
        public bool Base64Encoded
        {
            get;
            set;
        }
    }
}