namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Determines what type of Trust Token operation is executed and
    /// depending on the type, some additional parameters. The values
    /// are specified in third_party/blink/renderer/core/fetch/trust_token.idl.
    /// </summary>
    public sealed class TrustTokenParams
    {
        /// <summary>
        /// type
        ///</summary>
        [JsonProperty("type")]
        public TrustTokenOperationType Type
        {
            get;
            set;
        }
        /// <summary>
        /// Only set for "token-redemption" type and determine whether
        /// to request a fresh SRR or use a still valid cached SRR.
        ///</summary>
        [JsonProperty("refreshPolicy")]
        public string RefreshPolicy
        {
            get;
            set;
        }
        /// <summary>
        /// Origins of issuers from whom to request tokens or redemption
        /// records.
        ///</summary>
        [JsonProperty("issuers", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string[] Issuers
        {
            get;
            set;
        }
    }
}