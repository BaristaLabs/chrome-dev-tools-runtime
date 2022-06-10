namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// An inspector issue reported from the back-end.
    /// </summary>
    public sealed class InspectorIssue
    {
        /// <summary>
        /// code
        ///</summary>
        [JsonProperty("code")]
        public InspectorIssueCode Code
        {
            get;
            set;
        }
        /// <summary>
        /// details
        ///</summary>
        [JsonProperty("details")]
        public InspectorIssueDetails Details
        {
            get;
            set;
        }
        /// <summary>
        /// A unique id for this issue. May be omitted if no other entity (e.g.
        /// exception, CDP message, etc.) is referencing this issue.
        ///</summary>
        [JsonProperty("issueId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string IssueId
        {
            get;
            set;
        }
    }
}