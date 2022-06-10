namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// OriginTrial
    /// </summary>
    public sealed class OriginTrial
    {
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
        /// status
        ///</summary>
        [JsonProperty("status")]
        public OriginTrialStatus Status
        {
            get;
            set;
        }
        /// <summary>
        /// tokensWithStatus
        ///</summary>
        [JsonProperty("tokensWithStatus")]
        public OriginTrialTokenWithStatus[] TokensWithStatus
        {
            get;
            set;
        }
    }
}