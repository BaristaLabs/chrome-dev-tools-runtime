namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Pair of issuer origin and number of available (signed, but not used) Trust
    /// Tokens from that issuer.
    /// </summary>
    public sealed class TrustTokens
    {
        /// <summary>
        /// issuerOrigin
        ///</summary>
        [JsonProperty("issuerOrigin")]
        public string IssuerOrigin
        {
            get;
            set;
        }
        /// <summary>
        /// count
        ///</summary>
        [JsonProperty("count")]
        public double Count
        {
            get;
            set;
        }
    }
}