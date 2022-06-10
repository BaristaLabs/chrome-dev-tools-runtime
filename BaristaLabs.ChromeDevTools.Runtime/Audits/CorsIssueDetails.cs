namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// Details for a CORS related issue, e.g. a warning or error related to
    /// CORS RFC1918 enforcement.
    /// </summary>
    public sealed class CorsIssueDetails
    {
        /// <summary>
        /// corsErrorStatus
        ///</summary>
        [JsonProperty("corsErrorStatus")]
        public Network.CorsErrorStatus CorsErrorStatus
        {
            get;
            set;
        }
        /// <summary>
        /// isWarning
        ///</summary>
        [JsonProperty("isWarning")]
        public bool IsWarning
        {
            get;
            set;
        }
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
        /// location
        ///</summary>
        [JsonProperty("location", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SourceCodeLocation Location
        {
            get;
            set;
        }
        /// <summary>
        /// initiatorOrigin
        ///</summary>
        [JsonProperty("initiatorOrigin", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string InitiatorOrigin
        {
            get;
            set;
        }
        /// <summary>
        /// resourceIPAddressSpace
        ///</summary>
        [JsonProperty("resourceIPAddressSpace", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Network.IPAddressSpace ResourceIPAddressSpace
        {
            get;
            set;
        }
        /// <summary>
        /// clientSecurityState
        ///</summary>
        [JsonProperty("clientSecurityState", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Network.ClientSecurityState ClientSecurityState
        {
            get;
            set;
        }
    }
}