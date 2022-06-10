namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// OriginTrialTokenWithStatus
    /// </summary>
    public sealed class OriginTrialTokenWithStatus
    {
        /// <summary>
        /// rawTokenText
        ///</summary>
        [JsonProperty("rawTokenText")]
        public string RawTokenText
        {
            get;
            set;
        }
        /// <summary>
        /// `parsedToken` is present only when the token is extractable and
        /// parsable.
        ///</summary>
        [JsonProperty("parsedToken", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public OriginTrialToken ParsedToken
        {
            get;
            set;
        }
        /// <summary>
        /// status
        ///</summary>
        [JsonProperty("status")]
        public OriginTrialTokenStatus Status
        {
            get;
            set;
        }
    }
}