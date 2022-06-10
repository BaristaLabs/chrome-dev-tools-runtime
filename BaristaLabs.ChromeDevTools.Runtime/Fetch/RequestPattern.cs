namespace BaristaLabs.ChromeDevTools.Runtime.Fetch
{
    using Newtonsoft.Json;

    /// <summary>
    /// RequestPattern
    /// </summary>
    public sealed class RequestPattern
    {
        /// <summary>
        /// Wildcards (`'*'` -> zero or more, `'?'` -> exactly one) are allowed. Escape character is
        /// backslash. Omitting is equivalent to `"*"`.
        ///</summary>
        [JsonProperty("urlPattern", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string UrlPattern
        {
            get;
            set;
        }
        /// <summary>
        /// If set, only requests for matching resource types will be intercepted.
        ///</summary>
        [JsonProperty("resourceType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Network.ResourceType ResourceType
        {
            get;
            set;
        }
        /// <summary>
        /// Stage at which to begin intercepting requests. Default is Request.
        ///</summary>
        [JsonProperty("requestStage", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public RequestStage? RequestStage
        {
            get;
            set;
        }
    }
}