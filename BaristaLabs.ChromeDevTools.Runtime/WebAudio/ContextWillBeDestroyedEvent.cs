namespace BaristaLabs.ChromeDevTools.Runtime.WebAudio
{
    using Newtonsoft.Json;

    /// <summary>
    /// Notifies that an existing BaseAudioContext will be destroyed.
    /// </summary>
    public sealed class ContextWillBeDestroyedEvent : IEvent
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
    }
}