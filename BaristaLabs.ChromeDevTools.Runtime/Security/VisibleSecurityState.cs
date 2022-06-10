namespace BaristaLabs.ChromeDevTools.Runtime.Security
{
    using Newtonsoft.Json;

    /// <summary>
    /// Security state information about the page.
    /// </summary>
    public sealed class VisibleSecurityState
    {
        /// <summary>
        /// The security level of the page.
        ///</summary>
        [JsonProperty("securityState")]
        public SecurityState SecurityState
        {
            get;
            set;
        }
        /// <summary>
        /// Security state details about the page certificate.
        ///</summary>
        [JsonProperty("certificateSecurityState", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CertificateSecurityState CertificateSecurityState
        {
            get;
            set;
        }
        /// <summary>
        /// The type of Safety Tip triggered on the page. Note that this field will be set even if the Safety Tip UI was not actually shown.
        ///</summary>
        [JsonProperty("safetyTipInfo", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SafetyTipInfo SafetyTipInfo
        {
            get;
            set;
        }
        /// <summary>
        /// Array of security state issues ids.
        ///</summary>
        [JsonProperty("securityStateIssueIds")]
        public string[] SecurityStateIssueIds
        {
            get;
            set;
        }
    }
}