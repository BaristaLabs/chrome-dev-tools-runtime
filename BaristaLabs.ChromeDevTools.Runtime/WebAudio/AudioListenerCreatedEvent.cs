namespace BaristaLabs.ChromeDevTools.Runtime.WebAudio
{
    using Newtonsoft.Json;

    /// <summary>
    /// Notifies that the construction of an AudioListener has finished.
    /// </summary>
    public sealed class AudioListenerCreatedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the listener
        /// </summary>
        [JsonProperty("listener")]
        public AudioListener Listener
        {
            get;
            set;
        }
    }
}