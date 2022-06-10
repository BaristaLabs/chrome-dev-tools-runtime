namespace BaristaLabs.ChromeDevTools.Runtime.WebAudio
{
    using Newtonsoft.Json;

    /// <summary>
    /// Protocol object for AudioNode
    /// </summary>
    public sealed class AudioNode
    {
        /// <summary>
        /// nodeId
        ///</summary>
        [JsonProperty("nodeId")]
        public string NodeId
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
        /// <summary>
        /// nodeType
        ///</summary>
        [JsonProperty("nodeType")]
        public string NodeType
        {
            get;
            set;
        }
        /// <summary>
        /// numberOfInputs
        ///</summary>
        [JsonProperty("numberOfInputs")]
        public double NumberOfInputs
        {
            get;
            set;
        }
        /// <summary>
        /// numberOfOutputs
        ///</summary>
        [JsonProperty("numberOfOutputs")]
        public double NumberOfOutputs
        {
            get;
            set;
        }
        /// <summary>
        /// channelCount
        ///</summary>
        [JsonProperty("channelCount")]
        public double ChannelCount
        {
            get;
            set;
        }
        /// <summary>
        /// channelCountMode
        ///</summary>
        [JsonProperty("channelCountMode")]
        public ChannelCountMode ChannelCountMode
        {
            get;
            set;
        }
        /// <summary>
        /// channelInterpretation
        ///</summary>
        [JsonProperty("channelInterpretation")]
        public ChannelInterpretation ChannelInterpretation
        {
            get;
            set;
        }
    }
}