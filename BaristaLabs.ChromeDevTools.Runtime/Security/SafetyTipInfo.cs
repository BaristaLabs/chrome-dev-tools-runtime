namespace BaristaLabs.ChromeDevTools.Runtime.Security
{
    using Newtonsoft.Json;

    /// <summary>
    /// SafetyTipInfo
    /// </summary>
    public sealed class SafetyTipInfo
    {
        /// <summary>
        /// Describes whether the page triggers any safety tips or reputation warnings. Default is unknown.
        ///</summary>
        [JsonProperty("safetyTipStatus")]
        public SafetyTipStatus SafetyTipStatus
        {
            get;
            set;
        }
        /// <summary>
        /// The URL the safety tip suggested ("Did you mean?"). Only filled in for lookalike matches.
        ///</summary>
        [JsonProperty("safeUrl", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string SafeUrl
        {
            get;
            set;
        }
    }
}