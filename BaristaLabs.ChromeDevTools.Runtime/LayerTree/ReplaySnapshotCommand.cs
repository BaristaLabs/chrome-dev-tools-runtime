namespace BaristaLabs.ChromeDevTools.Runtime.LayerTree
{
    using Newtonsoft.Json;

    /// <summary>
    /// Replays the layer snapshot and returns the resulting bitmap.
    /// </summary>
    public sealed class ReplaySnapshotCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "LayerTree.replaySnapshot";
        
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
        /// The first step to replay from (replay from the very start if not specified).
        /// </summary>
        [JsonProperty("fromStep", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? FromStep
        {
            get;
            set;
        }
        /// <summary>
        /// The last step to replay to (replay till the end if not specified).
        /// </summary>
        [JsonProperty("toStep", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? ToStep
        {
            get;
            set;
        }
        /// <summary>
        /// The scale to apply while replaying (defaults to 1).
        /// </summary>
        [JsonProperty("scale", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? Scale
        {
            get;
            set;
        }
    }

    public sealed class ReplaySnapshotCommandResponse : ICommandResponse<ReplaySnapshotCommand>
    {
        /// <summary>
        /// A data: URL for resulting image.
        ///</summary>
        [JsonProperty("dataURL")]
        public string DataURL
        {
            get;
            set;
        }
    }
}