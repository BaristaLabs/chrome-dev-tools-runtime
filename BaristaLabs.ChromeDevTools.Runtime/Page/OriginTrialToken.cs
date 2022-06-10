namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// OriginTrialToken
    /// </summary>
    public sealed class OriginTrialToken
    {
        /// <summary>
        /// origin
        ///</summary>
        [JsonProperty("origin")]
        public string Origin
        {
            get;
            set;
        }
        /// <summary>
        /// matchSubDomains
        ///</summary>
        [JsonProperty("matchSubDomains")]
        public bool MatchSubDomains
        {
            get;
            set;
        }
        /// <summary>
        /// trialName
        ///</summary>
        [JsonProperty("trialName")]
        public string TrialName
        {
            get;
            set;
        }
        /// <summary>
        /// expiryTime
        ///</summary>
        [JsonProperty("expiryTime")]
        public double ExpiryTime
        {
            get;
            set;
        }
        /// <summary>
        /// isThirdParty
        ///</summary>
        [JsonProperty("isThirdParty")]
        public bool IsThirdParty
        {
            get;
            set;
        }
        /// <summary>
        /// usageRestriction
        ///</summary>
        [JsonProperty("usageRestriction")]
        public OriginTrialUsageRestriction UsageRestriction
        {
            get;
            set;
        }
    }
}