namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// ContentSecurityPolicyIssueDetails
    /// </summary>
    public sealed class ContentSecurityPolicyIssueDetails
    {
        /// <summary>
        /// The url not included in allowed sources.
        ///</summary>
        [JsonProperty("blockedURL", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BlockedURL
        {
            get;
            set;
        }
        /// <summary>
        /// Specific directive that is violated, causing the CSP issue.
        ///</summary>
        [JsonProperty("violatedDirective")]
        public string ViolatedDirective
        {
            get;
            set;
        }
        /// <summary>
        /// isReportOnly
        ///</summary>
        [JsonProperty("isReportOnly")]
        public bool IsReportOnly
        {
            get;
            set;
        }
        /// <summary>
        /// contentSecurityPolicyViolationType
        ///</summary>
        [JsonProperty("contentSecurityPolicyViolationType")]
        public ContentSecurityPolicyViolationType ContentSecurityPolicyViolationType
        {
            get;
            set;
        }
        /// <summary>
        /// frameAncestor
        ///</summary>
        [JsonProperty("frameAncestor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AffectedFrame FrameAncestor
        {
            get;
            set;
        }
        /// <summary>
        /// sourceCodeLocation
        ///</summary>
        [JsonProperty("sourceCodeLocation", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SourceCodeLocation SourceCodeLocation
        {
            get;
            set;
        }
        /// <summary>
        /// violatingNodeId
        ///</summary>
        [JsonProperty("violatingNodeId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? ViolatingNodeId
        {
            get;
            set;
        }
    }
}