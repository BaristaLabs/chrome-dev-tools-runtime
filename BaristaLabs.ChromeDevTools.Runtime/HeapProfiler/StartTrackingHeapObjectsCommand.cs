namespace BaristaLabs.ChromeDevTools.Runtime.HeapProfiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class StartTrackingHeapObjectsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "HeapProfiler.startTrackingHeapObjects";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Gets or sets the trackAllocations
        /// </summary>
        
        [JsonProperty("trackAllocations", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? TrackAllocations
        {
            get;
            set;
        }
    
    }

    public sealed class StartTrackingHeapObjectsCommandResponse : ICommandResponse<StartTrackingHeapObjectsCommand>
    {
    
    }
}