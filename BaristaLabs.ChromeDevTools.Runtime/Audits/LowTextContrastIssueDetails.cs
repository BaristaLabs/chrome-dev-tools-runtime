namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// LowTextContrastIssueDetails
    /// </summary>
    public sealed class LowTextContrastIssueDetails
    {
        /// <summary>
        /// violatingNodeId
        ///</summary>
        [JsonProperty("violatingNodeId")]
        public long ViolatingNodeId
        {
            get;
            set;
        }
        /// <summary>
        /// violatingNodeSelector
        ///</summary>
        [JsonProperty("violatingNodeSelector")]
        public string ViolatingNodeSelector
        {
            get;
            set;
        }
        /// <summary>
        /// contrastRatio
        ///</summary>
        [JsonProperty("contrastRatio")]
        public double ContrastRatio
        {
            get;
            set;
        }
        /// <summary>
        /// thresholdAA
        ///</summary>
        [JsonProperty("thresholdAA")]
        public double ThresholdAA
        {
            get;
            set;
        }
        /// <summary>
        /// thresholdAAA
        ///</summary>
        [JsonProperty("thresholdAAA")]
        public double ThresholdAAA
        {
            get;
            set;
        }
        /// <summary>
        /// fontSize
        ///</summary>
        [JsonProperty("fontSize")]
        public string FontSize
        {
            get;
            set;
        }
        /// <summary>
        /// fontWeight
        ///</summary>
        [JsonProperty("fontWeight")]
        public string FontWeight
        {
            get;
            set;
        }
    }
}