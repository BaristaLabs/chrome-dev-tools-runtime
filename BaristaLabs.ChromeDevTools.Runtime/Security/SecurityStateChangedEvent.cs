namespace BaristaLabs.ChromeDevTools.Runtime.Security
{
    using Newtonsoft.Json;

    /// <summary>
    /// The security state of the page changed. No longer being sent.
    /// </summary>
    public sealed class SecurityStateChangedEvent : IEvent
    {
        /// <summary>
        /// Security state.
        /// </summary>
        [JsonProperty("securityState")]
        public SecurityState SecurityState
        {
            get;
            set;
        }
        /// <summary>
        /// True if the page was loaded over cryptographic transport such as HTTPS.
        /// </summary>
        [JsonProperty("schemeIsCryptographic")]
        public bool SchemeIsCryptographic
        {
            get;
            set;
        }
        /// <summary>
        /// Previously a list of explanations for the security state. Now always
        /// empty.
        /// </summary>
        [JsonProperty("explanations")]
        public SecurityStateExplanation[] Explanations
        {
            get;
            set;
        }
        /// <summary>
        /// Information about insecure content on the page.
        /// </summary>
        [JsonProperty("insecureContentStatus")]
        public InsecureContentStatus InsecureContentStatus
        {
            get;
            set;
        }
        /// <summary>
        /// Overrides user-visible description of the state. Always omitted.
        /// </summary>
        [JsonProperty("summary", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Summary
        {
            get;
            set;
        }
    }
}