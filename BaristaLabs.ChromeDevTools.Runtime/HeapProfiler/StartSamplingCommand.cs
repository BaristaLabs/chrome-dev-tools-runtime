namespace BaristaLabs.ChromeDevTools.Runtime.HeapProfiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class StartSamplingCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "HeapProfiler.startSampling";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Average sample interval in bytes. Poisson distribution is used for the intervals. The default value is 32768 bytes.
        /// </summary>
        [JsonProperty("samplingInterval", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? SamplingInterval
        {
            get;
            set;
        }
    }

    public sealed class StartSamplingCommandResponse : ICommandResponse<StartSamplingCommand>
    {
    }
}