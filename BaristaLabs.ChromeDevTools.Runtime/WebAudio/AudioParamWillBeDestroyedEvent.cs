namespace BaristaLabs.ChromeDevTools.Runtime.WebAudio
{
    using Newtonsoft.Json;

    /// <summary>
    /// Notifies that an existing AudioParam has been destroyed.
    /// </summary>
    public sealed class AudioParamWillBeDestroyedEvent : IEvent
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
        /// Gets or sets the nodeId
        /// </summary>
        [JsonProperty("nodeId")]
        public string NodeId
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the paramId
        /// </summary>
        [JsonProperty("paramId")]
        public string ParamId
        {
            get;
            set;
        }
    }
}