namespace BaristaLabs.ChromeDevTools.Runtime.HeapProfiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class GetObjectByHeapObjectIdCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "HeapProfiler.getObjectByHeapObjectId";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the objectId
        /// </summary>
        [JsonProperty("objectId")]
        public string ObjectId
        {
            get;
            set;
        }
        /// <summary>
        /// Symbolic group name that can be used to release multiple objects.
        /// </summary>
        [JsonProperty("objectGroup", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ObjectGroup
        {
            get;
            set;
        }
    }

    public sealed class GetObjectByHeapObjectIdCommandResponse : ICommandResponse<GetObjectByHeapObjectIdCommand>
    {
        /// <summary>
        /// Evaluation result.
        ///</summary>
        [JsonProperty("result")]
        public Runtime.RemoteObject Result
        {
            get;
            set;
        }
    }
}