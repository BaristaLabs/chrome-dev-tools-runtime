namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Information about a signed exchange signature.
    /// https://wicg.github.io/webpackage/draft-yasskin-httpbis-origin-signed-exchanges-impl.html#rfc.section.3.1
    /// </summary>
    public sealed class SignedExchangeSignature
    {
        /// <summary>
        /// Signed exchange signature label.
        ///</summary>
        [JsonProperty("label")]
        public string Label
        {
            get;
            set;
        }
        /// <summary>
        /// Signed exchange signature integrity.
        ///</summary>
        [JsonProperty("integrity")]
        public string Integrity
        {
            get;
            set;
        }
        /// <summary>
        /// Signed exchange signature cert Url.
        ///</summary>
        [JsonProperty("certUrl")]
        public string CertUrl
        {
            get;
            set;
        }
        /// <summary>
        /// Signed exchange signature validity Url.
        ///</summary>
        [JsonProperty("validityUrl")]
        public string ValidityUrl
        {
            get;
            set;
        }
        /// <summary>
        /// Signed exchange signature date.
        ///</summary>
        [JsonProperty("date")]
        public long Date
        {
            get;
            set;
        }
        /// <summary>
        /// Signed exchange signature expires.
        ///</summary>
        [JsonProperty("expires")]
        public long Expires
        {
            get;
            set;
        }
    }
}