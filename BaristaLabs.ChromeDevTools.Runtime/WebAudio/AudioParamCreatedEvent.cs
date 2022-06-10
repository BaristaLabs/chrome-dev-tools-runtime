namespace BaristaLabs.ChromeDevTools.Runtime.WebAudio
{
    using Newtonsoft.Json;

    /// <summary>
    /// Notifies that a new AudioParam has been created.
    /// </summary>
    public sealed class AudioParamCreatedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the param
        /// </summary>
        [JsonProperty("param")]
        public AudioParam Param
        {
            get;
            set;
        }
    }
}