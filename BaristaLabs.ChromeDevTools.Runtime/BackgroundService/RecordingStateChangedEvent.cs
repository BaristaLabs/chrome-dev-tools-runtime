namespace BaristaLabs.ChromeDevTools.Runtime.BackgroundService
{
    using Newtonsoft.Json;

    /// <summary>
    /// Called when the recording state for the service has been updated.
    /// </summary>
    public sealed class RecordingStateChangedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the isRecording
        /// </summary>
        [JsonProperty("isRecording")]
        public bool IsRecording
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the service
        /// </summary>
        [JsonProperty("service")]
        public ServiceName Service
        {
            get;
            set;
        }
    }
}