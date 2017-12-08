namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Registers origin to be notified when an update occurs to its IndexedDB.
    /// </summary>
    public sealed class TrackIndexedDBForOriginCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Storage.trackIndexedDBForOrigin";
        
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

    public sealed class TrackIndexedDBForOriginCommandResponse : ICommandResponse<TrackIndexedDBForOriginCommand>
    {
    }
}