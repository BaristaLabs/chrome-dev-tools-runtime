namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// IssueAdded
    /// </summary>
    public sealed class IssueAddedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the issue
        /// </summary>
        [JsonProperty("issue")]
        public InspectorIssue Issue
        {
            get;
            set;
        }
    }
}