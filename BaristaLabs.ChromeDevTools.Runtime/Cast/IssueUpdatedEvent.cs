namespace BaristaLabs.ChromeDevTools.Runtime.Cast
{
    using Newtonsoft.Json;

    /// <summary>
    /// This is fired whenever the outstanding issue/error message changes.
    /// |issueMessage| is empty if there is no issue.
    /// </summary>
    public sealed class IssueUpdatedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the issueMessage
        /// </summary>
        [JsonProperty("issueMessage")]
        public string IssueMessage
        {
            get;
            set;
        }
    }
}