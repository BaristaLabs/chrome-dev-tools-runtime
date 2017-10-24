namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Registers origin to be notified when an update occurs to its cache storage list.
    /// </summary>
    public sealed class TrackCacheStorageForOriginCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Storage.trackCacheStorageForOrigin";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Security origin.
        /// </summary>
        [JsonProperty("origin")]
        public string Origin
        {
            get;
            set;
        }
    }

    public sealed class TrackCacheStorageForOriginCommandResponse : ICommandResponse<TrackCacheStorageForOriginCommand>
    {
    }
}