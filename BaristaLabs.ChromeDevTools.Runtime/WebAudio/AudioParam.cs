namespace BaristaLabs.ChromeDevTools.Runtime.WebAudio
{
    using Newtonsoft.Json;

    /// <summary>
    /// Protocol object for AudioParam
    /// </summary>
    public sealed class AudioParam
    {
        /// <summary>
        /// paramId
        ///</summary>
        [JsonProperty("paramId")]
        public string ParamId
        {
            get;
            set;
        }
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
        /// paramType
        ///</summary>
        [JsonProperty("paramType")]
        public string ParamType
        {
            get;
            set;
        }
        /// <summary>
        /// rate
        ///</summary>
        [JsonProperty("rate")]
        public AutomationRate Rate
        {
            get;
            set;
        }
        /// <summary>
        /// defaultValue
        ///</summary>
        [JsonProperty("defaultValue")]
        public double DefaultValue
        {
            get;
            set;
        }
        /// <summary>
        /// minValue
        ///</summary>
        [JsonProperty("minValue")]
        public double MinValue
        {
            get;
            set;
        }
        /// <summary>
        /// maxValue
        ///</summary>
        [JsonProperty("maxValue")]
        public double MaxValue
        {
            get;
            set;
        }
    }
}