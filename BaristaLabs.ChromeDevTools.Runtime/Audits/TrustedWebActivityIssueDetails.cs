namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// TrustedWebActivityIssueDetails
    /// </summary>
    public sealed class TrustedWebActivityIssueDetails
    {
        /// <summary>
        /// The url that triggers the violation.
        ///</summary>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
        /// <summary>
        /// violationType
        ///</summary>
        [JsonProperty("violationType")]
        public TwaQualityEnforcementViolationType ViolationType
        {
            get;
            set;
        }
        /// <summary>
        /// httpStatusCode
        ///</summary>
        [JsonProperty("httpStatusCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? HttpStatusCode
        {
            get;
            set;
        }
        /// <summary>
        /// The package name of the Trusted Web Activity client app. This field is
        /// only used when violation type is kDigitalAssetLinks.
        ///</summary>
        [JsonProperty("packageName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PackageName
        {
            get;
            set;
        }
        /// <summary>
        /// The signature of the Trusted Web Activity client app. This field is only
        /// used when violation type is kDigitalAssetLinks.
        ///</summary>
        [JsonProperty("signature", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Signature
        {
            get;
            set;
        }
    }
}