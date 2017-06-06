namespace BaristaLabs.ChromeDevTools.Runtime.LayerTree
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ProfileSnapshotCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "LayerTree.profileSnapshot";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// The id of the layer snapshot.
        /// </summary>
        
        [JsonProperty("snapshotId")]
        public string SnapshotId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// The maximum number of times to replay the snapshot (1, if not specified).
        /// </summary>
        
        [JsonProperty("minRepeatCount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? MinRepeatCount
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// The minimum duration (in seconds) to replay the snapshot.
        /// </summary>
        
        [JsonProperty("minDuration", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? MinDuration
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// The clip rectangle to apply when replaying the snapshot.
        /// </summary>
        
        [JsonProperty("clipRect", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DOM.Rect ClipRect
        {
            get;
            set;
        }
    
    }

    public sealed class ProfileSnapshotCommandResponse : ICommandResponse<ProfileSnapshotCommand>
    {
    
        
        /// <summary>
        /// The array of paint profiles, one per run.
        ///</summary>
        
        [JsonProperty("timings")]
        public double[][] Timings
        {
            get;
            set;
        }
    
    }
}