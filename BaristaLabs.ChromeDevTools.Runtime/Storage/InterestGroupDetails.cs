namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// The full details of an interest group.
    /// </summary>
    public sealed class InterestGroupDetails
    {
        /// <summary>
        /// ownerOrigin
        ///</summary>
        [JsonProperty("ownerOrigin")]
        public string OwnerOrigin
        {
            get;
            set;
        }
        /// <summary>
        /// name
        ///</summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// expirationTime
        ///</summary>
        [JsonProperty("expirationTime")]
        public double ExpirationTime
        {
            get;
            set;
        }
        /// <summary>
        /// joiningOrigin
        ///</summary>
        [JsonProperty("joiningOrigin")]
        public string JoiningOrigin
        {
            get;
            set;
        }
        /// <summary>
        /// biddingUrl
        ///</summary>
        [JsonProperty("biddingUrl", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BiddingUrl
        {
            get;
            set;
        }
        /// <summary>
        /// biddingWasmHelperUrl
        ///</summary>
        [JsonProperty("biddingWasmHelperUrl", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BiddingWasmHelperUrl
        {
            get;
            set;
        }
        /// <summary>
        /// updateUrl
        ///</summary>
        [JsonProperty("updateUrl", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string UpdateUrl
        {
            get;
            set;
        }
        /// <summary>
        /// trustedBiddingSignalsUrl
        ///</summary>
        [JsonProperty("trustedBiddingSignalsUrl", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TrustedBiddingSignalsUrl
        {
            get;
            set;
        }
        /// <summary>
        /// trustedBiddingSignalsKeys
        ///</summary>
        [JsonProperty("trustedBiddingSignalsKeys")]
        public string[] TrustedBiddingSignalsKeys
        {
            get;
            set;
        }
        /// <summary>
        /// userBiddingSignals
        ///</summary>
        [JsonProperty("userBiddingSignals", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string UserBiddingSignals
        {
            get;
            set;
        }
        /// <summary>
        /// ads
        ///</summary>
        [JsonProperty("ads")]
        public InterestGroupAd[] Ads
        {
            get;
            set;
        }
        /// <summary>
        /// adComponents
        ///</summary>
        [JsonProperty("adComponents")]
        public InterestGroupAd[] AdComponents
        {
            get;
            set;
        }
    }
}