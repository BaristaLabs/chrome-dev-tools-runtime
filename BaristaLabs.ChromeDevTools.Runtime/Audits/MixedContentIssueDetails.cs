namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// MixedContentIssueDetails
    /// </summary>
    public sealed class MixedContentIssueDetails
    {
        /// <summary>
        /// The type of resource causing the mixed content issue (css, js, iframe,
        /// form,...). Marked as optional because it is mapped to from
        /// blink::mojom::RequestContextType, which will be replaced
        /// by network::mojom::RequestDestination
        ///</summary>
        [JsonProperty("resourceType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public MixedContentResourceType? ResourceType
        {
            get;
            set;
        }
        /// <summary>
        /// The way the mixed content issue is being resolved.
        ///</summary>
        [JsonProperty("resolutionStatus")]
        public MixedContentResolutionStatus ResolutionStatus
        {
            get;
            set;
        }
        /// <summary>
        /// The unsafe http url causing the mixed content issue.
        ///</summary>
        [JsonProperty("insecureURL")]
        public string InsecureURL
        {
            get;
            set;
        }
        /// <summary>
        /// The url responsible for the call to an unsafe url.
        ///</summary>
        [JsonProperty("mainResourceURL")]
        public string MainResourceURL
        {
            get;
            set;
        }
        /// <summary>
        /// The mixed content request.
        /// Does not always exist (e.g. for unsafe form submission urls).
        ///</summary>
        [JsonProperty("request", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AffectedRequest Request
        {
            get;
            set;
        }
        /// <summary>
        /// Optional because not every mixed content issue is necessarily linked to a frame.
        ///</summary>
        [JsonProperty("frame", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AffectedFrame Frame
        {
            get;
            set;
        }
    }
}