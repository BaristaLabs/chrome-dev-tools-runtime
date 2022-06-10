namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// Details for a request that has been blocked with the BLOCKED_BY_RESPONSE
    /// code. Currently only used for COEP/COOP, but may be extended to include
    /// some CSP errors in the future.
    /// </summary>
    public sealed class BlockedByResponseIssueDetails
    {
        /// <summary>
        /// request
        ///</summary>
        [JsonProperty("request")]
        public AffectedRequest Request
        {
            get;
            set;
        }
        /// <summary>
        /// parentFrame
        ///</summary>
        [JsonProperty("parentFrame", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AffectedFrame ParentFrame
        {
            get;
            set;
        }
        /// <summary>
        /// blockedFrame
        ///</summary>
        [JsonProperty("blockedFrame", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AffectedFrame BlockedFrame
        {
            get;
            set;
        }
        /// <summary>
        /// reason
        ///</summary>
        [JsonProperty("reason")]
        public BlockedByResponseReason Reason
        {
            get;
            set;
        }
    }
}