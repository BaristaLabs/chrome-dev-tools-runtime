namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// NavigatorUserAgentIssueDetails
    /// </summary>
    public sealed class NavigatorUserAgentIssueDetails
    {
        /// <summary>
        /// url
        ///</summary>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
        /// <summary>
        /// location
        ///</summary>
        [JsonProperty("location", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SourceCodeLocation Location
        {
            get;
            set;
        }
    }
}