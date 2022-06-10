namespace BaristaLabs.ChromeDevTools.Runtime.CacheStorage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Requests data from cache.
    /// </summary>
    public sealed class RequestEntriesCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "CacheStorage.requestEntries";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// ID of cache to get entries from.
        /// </summary>
        [JsonProperty("cacheId")]
        public string CacheId
        {
            get;
            set;
        }
        /// <summary>
        /// Number of records to skip.
        /// </summary>
        [JsonProperty("skipCount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? SkipCount
        {
            get;
            set;
        }
        /// <summary>
        /// Number of records to fetch.
        /// </summary>
        [JsonProperty("pageSize", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? PageSize
        {
            get;
            set;
        }
        /// <summary>
        /// If present, only return the entries containing this substring in the path
        /// </summary>
        [JsonProperty("pathFilter", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PathFilter
        {
            get;
            set;
        }
    }

    public sealed class RequestEntriesCommandResponse : ICommandResponse<RequestEntriesCommand>
    {
        /// <summary>
        /// Array of object store data entries.
        ///</summary>
        [JsonProperty("cacheDataEntries")]
        public DataEntry[] CacheDataEntries
        {
            get;
            set;
        }
        /// <summary>
        /// Count of returned entries from this storage. If pathFilter is empty, it
        /// is the count of all entries from this storage.
        ///</summary>
        [JsonProperty("returnCount")]
        public double ReturnCount
        {
            get;
            set;
        }
    }
}