namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// HTTP request data.
    /// </summary>
    public sealed class Request
    {
        /// <summary>
        /// Request URL (without fragment).
        ///</summary>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
        /// <summary>
        /// Fragment of the requested URL starting with hash, if present.
        ///</summary>
        [JsonProperty("urlFragment", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string UrlFragment
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
        /// True when the request has POST data. Note that postData might still be omitted when this flag is true when the data is too long.
        ///</summary>
        [JsonProperty("hasPostData", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? HasPostData
        {
            get;
            set;
        }
        /// <summary>
        /// Request body elements. This will be converted from base64 to binary
        ///</summary>
        [JsonProperty("postDataEntries", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PostDataEntry[] PostDataEntries
        {
            get;
            set;
        }
        /// <summary>
        /// The mixed content type of the request.
        ///</summary>
        [JsonProperty("mixedContentType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Security.MixedContentType MixedContentType
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
        /// <summary>
        /// Set for requests when the TrustToken API is used. Contains the parameters
        /// passed by the developer (e.g. via "fetch") as understood by the backend.
        ///</summary>
        [JsonProperty("trustTokenParams", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public TrustTokenParams TrustTokenParams
        {
            get;
            set;
        }
        /// <summary>
        /// True if this resource request is considered to be the 'same site' as the
        /// request correspondinfg to the main frame.
        ///</summary>
        [JsonProperty("isSameSite", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? IsSameSite
        {
            get;
            set;
        }
    }
}