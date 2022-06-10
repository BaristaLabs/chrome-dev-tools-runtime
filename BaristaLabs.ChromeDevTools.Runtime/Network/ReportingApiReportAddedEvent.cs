namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Is sent whenever a new report is added.
    /// And after 'enableReportingApi' for all existing reports.
    /// </summary>
    public sealed class ReportingApiReportAddedEvent : IEvent
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