namespace BaristaLabs.ChromeDevTools.Runtime.HeapProfiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class StopSamplingCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "HeapProfiler.stopSampling";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class StopSamplingCommandResponse : ICommandResponse<StopSamplingCommand>
    {
        /// <summary>
        /// Recorded sampling heap profile.
        ///</summary>
        [JsonProperty("profile")]
        public SamplingHeapProfile Profile
        {
            get;
            set;
        }
    }
}