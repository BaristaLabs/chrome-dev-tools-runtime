namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// Details for issues around "Attribution Reporting API" usage.
    /// Explainer: https://github.com/WICG/conversion-measurement-api
    /// </summary>
    public sealed class AttributionReportingIssueDetails
    {
        /// <summary>
        /// violationType
        ///</summary>
        [JsonProperty("violationType")]
        public AttributionReportingIssueType ViolationType
        {
            get;
            set;
        }
        /// <summary>
        /// frame
        ///</summary>
        [JsonProperty("frame", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AffectedFrame Frame
        {
            get;
            set;
        }
        /// <summary>
        /// request
        ///</summary>
        [JsonProperty("request", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AffectedRequest Request
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
        /// <summary>
        /// invalidParameter
        ///</summary>
        [JsonProperty("invalidParameter", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string InvalidParameter
        {
            get;
            set;
        }
    }
}