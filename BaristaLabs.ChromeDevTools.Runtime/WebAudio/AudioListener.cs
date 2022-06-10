namespace BaristaLabs.ChromeDevTools.Runtime.WebAudio
{
    using Newtonsoft.Json;

    /// <summary>
    /// Protocol object for AudioListener
    /// </summary>
    public sealed class AudioListener
    {
        /// <summary>
        /// listenerId
        ///</summary>
        [JsonProperty("listenerId")]
        public string ListenerId
        {
            get;
            set;
        }
        /// <summary>
        /// contextId
        ///</summary>
        [JsonProperty("contextId")]
        public string ContextId
        {
            get;
            set;
        }
    }
}