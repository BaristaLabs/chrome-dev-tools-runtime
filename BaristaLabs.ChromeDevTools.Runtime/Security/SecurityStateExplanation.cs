namespace BaristaLabs.ChromeDevTools.Runtime.Security
{
    using Newtonsoft.Json;

    /// <summary>
    /// An explanation of an factor contributing to the security state.
    /// </summary>
    public sealed class SecurityStateExplanation
    {
        /// <summary>
        /// Security state representing the severity of the factor being explained.
        ///</summary>
        [JsonProperty("securityState")]
        public SecurityState SecurityState
        {
            get;
            set;
        }
        /// <summary>
        /// Short phrase describing the type of factor.
        ///</summary>
        [JsonProperty("summary")]
        public string Summary
        {
            get;
            set;
        }
        /// <summary>
        /// Full text explanation of the factor.
        ///</summary>
        [JsonProperty("description")]
        public string Description
        {
            get;
            set;
        }
        /// <summary>
        /// The type of mixed content described by the explanation.
        ///</summary>
        [JsonProperty("mixedContentType")]
        public MixedContentType MixedContentType
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
    }
}