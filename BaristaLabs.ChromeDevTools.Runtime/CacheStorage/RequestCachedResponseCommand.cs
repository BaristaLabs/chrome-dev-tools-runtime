namespace BaristaLabs.ChromeDevTools.Runtime.CacheStorage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fetches cache entry.
    /// </summary>
    public sealed class RequestCachedResponseCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "CacheStorage.requestCachedResponse";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Id of cache that contains the enty.
        /// </summary>
        [JsonProperty("cacheId")]
        public string CacheId
        {
            get;
            set;
        }
        /// <summary>
        /// URL spec of the request.
        /// </summary>
        [JsonProperty("requestURL")]
        public string RequestURL
        {
            get;
            set;
        }
    }

    public sealed class RequestCachedResponseCommandResponse : ICommandResponse<RequestCachedResponseCommand>
    {
        /// <summary>
        /// Response read from the cache.
        ///</summary>
        [JsonProperty("response")]
        public CachedResponse Response
        {
            get;
            set;
        }
    }
}