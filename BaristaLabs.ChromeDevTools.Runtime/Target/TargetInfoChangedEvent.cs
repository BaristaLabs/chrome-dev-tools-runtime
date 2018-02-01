namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using Newtonsoft.Json;

    /// <summary>
    /// Issued when some information about a target has changed. This only happens between `targetCreated` and `targetDestroyed`.
    /// </summary>
    public sealed class TargetInfoChangedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the targetInfo
        /// </summary>
        [JsonProperty("targetInfo")]
        public TargetInfo TargetInfo
        {
            get;
            set;
        }
    }
}