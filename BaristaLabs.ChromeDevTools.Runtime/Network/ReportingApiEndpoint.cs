namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// ReportingApiEndpoint
    /// </summary>
    public sealed class ReportingApiEndpoint
    {
        /// <summary>
        /// The URL of the endpoint to which reports may be delivered.
        ///</summary>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
        /// <summary>
        /// Name of the endpoint group.
        ///</summary>
        [JsonProperty("groupName")]
        public string GroupName
        {
            get;
            set;
        }
    }
}