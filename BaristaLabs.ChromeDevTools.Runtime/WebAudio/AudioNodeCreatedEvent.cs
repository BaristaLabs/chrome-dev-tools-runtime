namespace BaristaLabs.ChromeDevTools.Runtime.WebAudio
{
    using Newtonsoft.Json;

    /// <summary>
    /// Notifies that a new AudioNode has been created.
    /// </summary>
    public sealed class AudioNodeCreatedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the node
        /// </summary>
        [JsonProperty("node")]
        public AudioNode Node
        {
            get;
            set;
        }
    }
}