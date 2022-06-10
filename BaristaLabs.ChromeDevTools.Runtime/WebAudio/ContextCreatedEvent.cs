namespace BaristaLabs.ChromeDevTools.Runtime.WebAudio
{
    using Newtonsoft.Json;

    /// <summary>
    /// Notifies that a new BaseAudioContext has been created.
    /// </summary>
    public sealed class ContextCreatedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the context
        /// </summary>
        [JsonProperty("context")]
        public BaseAudioContext Context
        {
            get;
            set;
        }
    }
}