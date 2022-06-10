namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// HeavyAdIssueDetails
    /// </summary>
    public sealed class HeavyAdIssueDetails
    {
        /// <summary>
        /// The resolution status, either blocking the content or warning.
        ///</summary>
        [JsonProperty("resolution")]
        public HeavyAdResolutionStatus Resolution
        {
            get;
            set;
        }
        /// <summary>
        /// The reason the ad was blocked, total network or cpu or peak cpu.
        ///</summary>
        [JsonProperty("reason")]
        public HeavyAdReason Reason
        {
            get;
            set;
        }
        /// <summary>
        /// The frame that was blocked.
        ///</summary>
        [JsonProperty("frame")]
        public AffectedFrame Frame
        {
            get;
            set;
        }
    }
}