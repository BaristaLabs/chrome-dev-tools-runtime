namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns content served for the given currently intercepted request.
    /// </summary>
    public sealed class GetResponseBodyForInterceptionCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Network.getResponseBodyForInterception";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Identifier for the intercepted request to get body for.
        /// </summary>
        [JsonProperty("interceptionId")]
        public string InterceptionId
        {
            get;
            set;
        }
    }

    public sealed class GetResponseBodyForInterceptionCommandResponse : ICommandResponse<GetResponseBodyForInterceptionCommand>
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