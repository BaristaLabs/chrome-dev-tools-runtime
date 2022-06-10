namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// CrossOriginEmbedderPolicyStatus
    /// </summary>
    public sealed class CrossOriginEmbedderPolicyStatus
    {
        /// <summary>
        /// value
        ///</summary>
        [JsonProperty("value")]
        public CrossOriginEmbedderPolicyValue Value
        {
            get;
            set;
        }
        /// <summary>
        /// reportOnlyValue
        ///</summary>
        [JsonProperty("reportOnlyValue")]
        public CrossOriginEmbedderPolicyValue ReportOnlyValue
        {
            get;
            set;
        }
        /// <summary>
        /// reportingEndpoint
        ///</summary>
        [JsonProperty("reportingEndpoint", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ReportingEndpoint
        {
            get;
            set;
        }
        /// <summary>
        /// reportOnlyReportingEndpoint
        ///</summary>
        [JsonProperty("reportOnlyReportingEndpoint", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ReportOnlyReportingEndpoint
        {
            get;
            set;
        }
    }
}