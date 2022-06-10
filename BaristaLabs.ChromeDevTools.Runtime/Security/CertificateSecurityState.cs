namespace BaristaLabs.ChromeDevTools.Runtime.Security
{
    using Newtonsoft.Json;

    /// <summary>
    /// Details about the security state of the page certificate.
    /// </summary>
    public sealed class CertificateSecurityState
    {
        /// <summary>
        /// Protocol name (e.g. "TLS 1.2" or "QUIC").
        ///</summary>
        [JsonProperty("protocol")]
        public string Protocol
        {
            get;
            set;
        }
        /// <summary>
        /// Key Exchange used by the connection, or the empty string if not applicable.
        ///</summary>
        [JsonProperty("keyExchange")]
        public string KeyExchange
        {
            get;
            set;
        }
        /// <summary>
        /// (EC)DH group used by the connection, if applicable.
        ///</summary>
        [JsonProperty("keyExchangeGroup", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string KeyExchangeGroup
        {
            get;
            set;
        }
        /// <summary>
        /// Cipher name.
        ///</summary>
        [JsonProperty("cipher")]
        public string Cipher
        {
            get;
            set;
        }
        /// <summary>
        /// TLS MAC. Note that AEAD ciphers do not have separate MACs.
        ///</summary>
        [JsonProperty("mac", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Mac
        {
            get;
            set;
        }
        /// <summary>
        /// Page certificate.
        ///</summary>
        [JsonProperty("certificate")]
        public string[] Certificate
        {
            get;
            set;
        }
        /// <summary>
        /// Certificate subject name.
        ///</summary>
        [JsonProperty("subjectName")]
        public string SubjectName
        {
            get;
            set;
        }
        /// <summary>
        /// Name of the issuing CA.
        ///</summary>
        [JsonProperty("issuer")]
        public string Issuer
        {
            get;
            set;
        }
        /// <summary>
        /// Certificate valid from date.
        ///</summary>
        [JsonProperty("validFrom")]
        public double ValidFrom
        {
            get;
            set;
        }
        /// <summary>
        /// Certificate valid to (expiration) date
        ///</summary>
        [JsonProperty("validTo")]
        public double ValidTo
        {
            get;
            set;
        }
        /// <summary>
        /// The highest priority network error code, if the certificate has an error.
        ///</summary>
        [JsonProperty("certificateNetworkError", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string CertificateNetworkError
        {
            get;
            set;
        }
        /// <summary>
        /// True if the certificate uses a weak signature aglorithm.
        ///</summary>
        [JsonProperty("certificateHasWeakSignature")]
        public bool CertificateHasWeakSignature
        {
            get;
            set;
        }
        /// <summary>
        /// True if the certificate has a SHA1 signature in the chain.
        ///</summary>
        [JsonProperty("certificateHasSha1Signature")]
        public bool CertificateHasSha1Signature
        {
            get;
            set;
        }
        /// <summary>
        /// True if modern SSL
        ///</summary>
        [JsonProperty("modernSSL")]
        public bool ModernSSL
        {
            get;
            set;
        }
        /// <summary>
        /// True if the connection is using an obsolete SSL protocol.
        ///</summary>
        [JsonProperty("obsoleteSslProtocol")]
        public bool ObsoleteSslProtocol
        {
            get;
            set;
        }
        /// <summary>
        /// True if the connection is using an obsolete SSL key exchange.
        ///</summary>
        [JsonProperty("obsoleteSslKeyExchange")]
        public bool ObsoleteSslKeyExchange
        {
            get;
            set;
        }
        /// <summary>
        /// True if the connection is using an obsolete SSL cipher.
        ///</summary>
        [JsonProperty("obsoleteSslCipher")]
        public bool ObsoleteSslCipher
        {
            get;
            set;
        }
        /// <summary>
        /// True if the connection is using an obsolete SSL signature.
        ///</summary>
        [JsonProperty("obsoleteSslSignature")]
        public bool ObsoleteSslSignature
        {
            get;
            set;
        }
    }
}