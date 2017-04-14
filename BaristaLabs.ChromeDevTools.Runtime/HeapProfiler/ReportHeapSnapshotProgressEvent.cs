namespace BaristaLabs.ChromeDevTools.Runtime.HeapProfiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ReportHeapSnapshotProgressEvent : IEvent
    {
    
        
        /// <summary>
        /// Gets or sets the done
        /// </summary>
        
        [JsonProperty("done")]
        public long Done
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the total
        /// </summary>
        
        [JsonProperty("total")]
        public long Total
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the finished
        /// </summary>
        
        [JsonProperty("finished", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Finished
        {
            get;
            set;
        }
    
    }
}