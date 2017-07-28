namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// HTTP request data.
    /// </summary>
    public sealed class Request
    {
        /// <summary>
        /// Request URL.
        ///</summary>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
        /// <summary>
        /// HTTP request method.
        ///</summary>
        [JsonProperty("method")]
        public string Method
        {
            get;
            set;
        }
        /// <summary>
        /// HTTP request headers.
        ///</summary>
        [JsonProperty("headers")]
        public Headers Headers
        {
            get;
            set;
        }
        /// <summary>
        /// HTTP POST request data.
        ///</summary>
        [JsonProperty("postData", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PostData
        {
            get;
            set;
        }
        /// <summary>
        /// The mixed content status of the request, as defined in http://www.w3.org/TR/mixed-content/
        ///</summary>
        [JsonProperty("mixedContentType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string MixedContentType
        {
            get;
            set;
        }
        /// <summary>
        /// Priority of the resource request at the time request is sent.
        ///</summary>
        [JsonProperty("initialPriority")]
        public ResourcePriority InitialPriority
        {
            get;
            set;
        }
        /// <summary>
        /// The referrer policy of the request, as defined in https://www.w3.org/TR/referrer-policy/
        ///</summary>
        [JsonProperty("referrerPolicy")]
        public string ReferrerPolicy
        {
            get;
            set;
        }
        /// <summary>
        /// Whether is loaded via link preload.
        ///</summary>
        [JsonProperty("isLinkPreload", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? IsLinkPreload
        {
            get;
            set;
        }
    }
}