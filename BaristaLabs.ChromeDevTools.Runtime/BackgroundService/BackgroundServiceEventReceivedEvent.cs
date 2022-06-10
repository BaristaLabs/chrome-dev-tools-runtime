namespace BaristaLabs.ChromeDevTools.Runtime.BackgroundService
{
    using Newtonsoft.Json;

    /// <summary>
    /// Called with all existing backgroundServiceEvents when enabled, and all new
    /// events afterwards if enabled and recording.
    /// </summary>
    public sealed class BackgroundServiceEventReceivedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the backgroundServiceEvent
        /// </summary>
        [JsonProperty("backgroundServiceEvent")]
        public BackgroundServiceEvent BackgroundServiceEvent
        {
            get;
            set;
        }
    }
}