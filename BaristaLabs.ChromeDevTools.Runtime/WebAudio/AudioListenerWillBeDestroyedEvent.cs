namespace BaristaLabs.ChromeDevTools.Runtime.WebAudio
{
    using Newtonsoft.Json;

    /// <summary>
    /// Notifies that a new AudioListener has been created.
    /// </summary>
    public sealed class AudioListenerWillBeDestroyedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the contextId
        /// </summary>
        [JsonProperty("contextId")]
        public string ContextId
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the listenerId
        /// </summary>
        [JsonProperty("listenerId")]
        public string ListenerId
        {
            get;
            set;
        }
    }
}