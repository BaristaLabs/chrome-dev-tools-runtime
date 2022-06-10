namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// CrossOriginOpenerPolicyStatus
    /// </summary>
    public sealed class CrossOriginOpenerPolicyStatus
    {
        /// <summary>
        /// value
        ///</summary>
        [JsonProperty("value")]
        public CrossOriginOpenerPolicyValue Value
        {
            get;
            set;
        }
        /// <summary>
        /// reportOnlyValue
        ///</summary>
        [JsonProperty("reportOnlyValue")]
        public CrossOriginOpenerPolicyValue ReportOnlyValue
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