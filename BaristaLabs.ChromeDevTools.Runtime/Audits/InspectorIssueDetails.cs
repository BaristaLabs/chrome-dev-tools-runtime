namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// This struct holds a list of optional fields with additional information
    /// specific to the kind of issue. When adding a new issue code, please also
    /// add a new optional field to this type.
    /// </summary>
    public sealed class InspectorIssueDetails
    {
        /// <summary>
        /// cookieIssueDetails
        ///</summary>
        [JsonProperty("cookieIssueDetails", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CookieIssueDetails CookieIssueDetails
        {
            get;
            set;
        }
        /// <summary>
        /// mixedContentIssueDetails
        ///</summary>
        [JsonProperty("mixedContentIssueDetails", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public MixedContentIssueDetails MixedContentIssueDetails
        {
            get;
            set;
        }
        /// <summary>
        /// blockedByResponseIssueDetails
        ///</summary>
        [JsonProperty("blockedByResponseIssueDetails", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public BlockedByResponseIssueDetails BlockedByResponseIssueDetails
        {
            get;
            set;
        }
        /// <summary>
        /// heavyAdIssueDetails
        ///</summary>
        [JsonProperty("heavyAdIssueDetails", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public HeavyAdIssueDetails HeavyAdIssueDetails
        {
            get;
            set;
        }
        /// <summary>
        /// contentSecurityPolicyIssueDetails
        ///</summary>
        [JsonProperty("contentSecurityPolicyIssueDetails", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ContentSecurityPolicyIssueDetails ContentSecurityPolicyIssueDetails
        {
            get;
            set;
        }
        /// <summary>
        /// sharedArrayBufferIssueDetails
        ///</summary>
        [JsonProperty("sharedArrayBufferIssueDetails", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SharedArrayBufferIssueDetails SharedArrayBufferIssueDetails
        {
            get;
            set;
        }
        /// <summary>
        /// twaQualityEnforcementDetails
        ///</summary>
        [JsonProperty("twaQualityEnforcementDetails", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public TrustedWebActivityIssueDetails TwaQualityEnforcementDetails
        {
            get;
            set;
        }
        /// <summary>
        /// lowTextContrastIssueDetails
        ///</summary>
        [JsonProperty("lowTextContrastIssueDetails", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public LowTextContrastIssueDetails LowTextContrastIssueDetails
        {
            get;
            set;
        }
        /// <summary>
        /// corsIssueDetails
        ///</summary>
        [JsonProperty("corsIssueDetails", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CorsIssueDetails CorsIssueDetails
        {
            get;
            set;
        }
        /// <summary>
        /// attributionReportingIssueDetails
        ///</summary>
        [JsonProperty("attributionReportingIssueDetails", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AttributionReportingIssueDetails AttributionReportingIssueDetails
        {
            get;
            set;
        }
        /// <summary>
        /// quirksModeIssueDetails
        ///</summary>
        [JsonProperty("quirksModeIssueDetails", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public QuirksModeIssueDetails QuirksModeIssueDetails
        {
            get;
            set;
        }
        /// <summary>
        /// navigatorUserAgentIssueDetails
        ///</summary>
        [JsonProperty("navigatorUserAgentIssueDetails", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public NavigatorUserAgentIssueDetails NavigatorUserAgentIssueDetails
        {
            get;
            set;
        }
        /// <summary>
        /// genericIssueDetails
        ///</summary>
        [JsonProperty("genericIssueDetails", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GenericIssueDetails GenericIssueDetails
        {
            get;
            set;
        }
        /// <summary>
        /// deprecationIssueDetails
        ///</summary>
        [JsonProperty("deprecationIssueDetails", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DeprecationIssueDetails DeprecationIssueDetails
        {
            get;
            set;
        }
        /// <summary>
        /// clientHintIssueDetails
        ///</summary>
        [JsonProperty("clientHintIssueDetails", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ClientHintIssueDetails ClientHintIssueDetails
        {
            get;
            set;
        }
        /// <summary>
        /// federatedAuthRequestIssueDetails
        ///</summary>
        [JsonProperty("federatedAuthRequestIssueDetails", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public FederatedAuthRequestIssueDetails FederatedAuthRequestIssueDetails
        {
            get;
            set;
        }
    }
}