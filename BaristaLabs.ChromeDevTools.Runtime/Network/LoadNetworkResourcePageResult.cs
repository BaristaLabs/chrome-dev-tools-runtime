namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// An object providing the result of a network resource load.
    /// </summary>
    public sealed class LoadNetworkResourcePageResult
    {
        /// <summary>
        /// success
        ///</summary>
        [JsonProperty("success")]
        public bool Success
        {
            get;
            set;
        }
        /// <summary>
        /// Optional values used for error reporting.
        ///</summary>
        [JsonProperty("netError", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? NetError
        {
            get;
            set;
        }
        /// <summary>
        /// netErrorName
        ///</summary>
        [JsonProperty("netErrorName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string NetErrorName
        {
            get;
            set;
        }
        /// <summary>
        /// httpStatusCode
        ///</summary>
        [JsonProperty("httpStatusCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? HttpStatusCode
        {
            get;
            set;
        }
        /// <summary>
        /// If successful, one of the following two fields holds the result.
        ///</summary>
        [JsonProperty("stream", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Stream
        {
            get;
            set;
        }
        /// <summary>
        /// Response headers.
        ///</summary>
        [JsonProperty("headers", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Network.Headers Headers
        {
            get;
            set;
        }
    }
}