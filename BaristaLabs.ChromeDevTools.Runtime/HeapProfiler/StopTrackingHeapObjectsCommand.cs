namespace BaristaLabs.ChromeDevTools.Runtime.HeapProfiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// StopTrackingHeapObjects
    /// </summary>
    public sealed class StopTrackingHeapObjectsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "HeapProfiler.stopTrackingHeapObjects";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// If true 'reportHeapSnapshotProgress' events will be generated while snapshot is being taken
        /// when the tracking is stopped.
        /// </summary>
        [JsonProperty("reportProgress", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? ReportProgress
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the treatGlobalObjectsAsRoots
        /// </summary>
        [JsonProperty("treatGlobalObjectsAsRoots", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? TreatGlobalObjectsAsRoots
        {
            get;
            set;
        }
        /// <summary>
        /// If true, numerical values are included in the snapshot
        /// </summary>
        [JsonProperty("captureNumericValue", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CaptureNumericValue
        {
            get;
            set;
        }
    }

    public sealed class StopTrackingHeapObjectsCommandResponse : ICommandResponse<StopTrackingHeapObjectsCommand>
    {
    }
}