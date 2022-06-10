namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// ReportingApiReportUpdated
    /// </summary>
    public sealed class ReportingApiReportUpdatedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the report
        /// </summary>
        [JsonProperty("report")]
        public ReportingApiReport Report
        {
            get;
            set;
        }
    }
}