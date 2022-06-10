namespace BaristaLabs.ChromeDevTools.Runtime.IndexedDB
{
    using Newtonsoft.Json;

    /// <summary>
    /// Gets metadata of an object store
    /// </summary>
    public sealed class GetMetadataCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "IndexedDB.getMetadata";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Security origin.
        /// </summary>
        [JsonProperty("securityOrigin")]
        public string SecurityOrigin
        {
            get;
            set;
        }
        /// <summary>
        /// Database name.
        /// </summary>
        [JsonProperty("databaseName")]
        public string DatabaseName
        {
            get;
            set;
        }
        /// <summary>
        /// Object store name.
        /// </summary>
        [JsonProperty("objectStoreName")]
        public string ObjectStoreName
        {
            get;
            set;
        }
    }

    public sealed class GetMetadataCommandResponse : ICommandResponse<GetMetadataCommand>
    {
        /// <summary>
        /// the entries count
        ///</summary>
        [JsonProperty("entriesCount")]
        public double EntriesCount
        {
            get;
            set;
        }
        /// <summary>
        /// the current value of key generator, to become the next inserted
        /// key into the object store. Valid if objectStore.autoIncrement
        /// is true.
        ///</summary>
        [JsonProperty("keyGeneratorValue")]
        public double KeyGeneratorValue
        {
            get;
            set;
        }
    }
}