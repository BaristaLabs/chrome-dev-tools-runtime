namespace BaristaLabs.ChromeDevTools.Runtime.CacheStorage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Data entry.
    /// </summary>
    public sealed class DataEntry
    {
        /// <summary>
        /// Request URL.
        ///</summary>
        [JsonProperty("requestURL")]
        public string RequestURL
        {
            get;
            set;
        }
        /// <summary>
        /// Request method.
        ///</summary>
        [JsonProperty("requestMethod")]
        public string RequestMethod
        {
            get;
            set;
        }
        /// <summary>
        /// Request headers
        ///</summary>
        [JsonProperty("requestHeaders")]
        public Header[] RequestHeaders
        {
            get;
            set;
        }
        /// <summary>
        /// Number of seconds since epoch.
        ///</summary>
        [JsonProperty("responseTime")]
        public double ResponseTime
        {
            get;
            set;
        }
        /// <summary>
        /// HTTP response status code.
        ///</summary>
        [JsonProperty("responseStatus")]
        public long ResponseStatus
        {
            get;
            set;
        }
        /// <summary>
        /// HTTP response status text.
        ///</summary>
        [JsonProperty("responseStatusText")]
        public string ResponseStatusText
        {
            get;
            set;
        }
        /// <summary>
        /// HTTP response type
        ///</summary>
        [JsonProperty("responseType")]
        public CachedResponseType ResponseType
        {
            get;
            set;
        }
        /// <summary>
        /// Response headers
        ///</summary>
        [JsonProperty("responseHeaders")]
        public Header[] ResponseHeaders
        {
            get;
            set;
        }
    }
}