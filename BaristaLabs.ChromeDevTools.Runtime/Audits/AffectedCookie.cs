namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// Information about a cookie that is affected by an inspector issue.
    /// </summary>
    public sealed class AffectedCookie
    {
        /// <summary>
        /// The following three properties uniquely identify a cookie
        ///</summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// path
        ///</summary>
        [JsonProperty("path")]
        public string Path
        {
            get;
            set;
        }
        /// <summary>
        /// domain
        ///</summary>
        [JsonProperty("domain")]
        public string Domain
        {
            get;
            set;
        }
    }
}