namespace BaristaLabs.ChromeDevTools.Runtime.WebAudio
{
    using Newtonsoft.Json;

    /// <summary>
    /// Protocol object for BaseAudioContext
    /// </summary>
    public sealed class BaseAudioContext
    {
        /// <summary>
        /// contextId
        ///</summary>
        [JsonProperty("contextId")]
        public string ContextId
        {
            get;
            set;
        }
        /// <summary>
        /// contextType
        ///</summary>
        [JsonProperty("contextType")]
        public ContextType ContextType
        {
            get;
            set;
        }
        /// <summary>
        /// contextState
        ///</summary>
        [JsonProperty("contextState")]
        public ContextState ContextState
        {
            get;
            set;
        }
        /// <summary>
        /// realtimeData
        ///</summary>
        [JsonProperty("realtimeData", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ContextRealtimeData RealtimeData
        {
            get;
            set;
        }
        /// <summary>
        /// Platform-dependent callback buffer size.
        ///</summary>
        [JsonProperty("callbackBufferSize")]
        public double CallbackBufferSize
        {
            get;
            set;
        }
        /// <summary>
        /// Number of output channels supported by audio hardware in use.
        ///</summary>
        [JsonProperty("maxOutputChannelCount")]
        public double MaxOutputChannelCount
        {
            get;
            set;
        }
        /// <summary>
        /// Context sample rate.
        ///</summary>
        [JsonProperty("sampleRate")]
        public double SampleRate
        {
            get;
            set;
        }
    }
}