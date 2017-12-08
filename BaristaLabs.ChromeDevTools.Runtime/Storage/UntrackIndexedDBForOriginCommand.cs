namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Unregisters origin from receiving notifications for IndexedDB.
    /// </summary>
    public sealed class UntrackIndexedDBForOriginCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Storage.untrackIndexedDBForOrigin";
        
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

    public sealed class UntrackIndexedDBForOriginCommandResponse : ICommandResponse<UntrackIndexedDBForOriginCommand>
    {
    }
}