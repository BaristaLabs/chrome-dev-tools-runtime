namespace BaristaLabs.ChromeDevTools.Runtime.Memory
{
    using Newtonsoft.Json;

    /// <summary>
    /// Start collecting native memory profile.
    /// </summary>
    public sealed class StartSamplingCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Memory.startSampling";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Average number of bytes between samples.
        /// </summary>
        [JsonProperty("samplingInterval", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? SamplingInterval
        {
            get;
            set;
        }
        /// <summary>
        /// Do not randomize intervals between samples.
        /// </summary>
        [JsonProperty("suppressRandomness", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? SuppressRandomness
        {
            get;
            set;
        }
    }

    public sealed class StartSamplingCommandResponse : ICommandResponse<StartSamplingCommand>
    {
    }
}