namespace BaristaLabs.ChromeDevTools.Runtime.IndexedDB
{
    using Newtonsoft.Json;

    /// <summary>
    /// Delete a range of entries from an object store
    /// </summary>
    public sealed class DeleteObjectStoreEntriesCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "IndexedDB.deleteObjectStoreEntries";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the securityOrigin
        /// </summary>
        [JsonProperty("securityOrigin")]
        public string SecurityOrigin
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the databaseName
        /// </summary>
        [JsonProperty("databaseName")]
        public string DatabaseName
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the objectStoreName
        /// </summary>
        [JsonProperty("objectStoreName")]
        public string ObjectStoreName
        {
            get;
            set;
        }
        /// <summary>
        /// Range of entry keys to delete
        /// </summary>
        [JsonProperty("keyRange")]
        public KeyRange KeyRange
        {
            get;
            set;
        }
    }

    public sealed class DeleteObjectStoreEntriesCommandResponse : ICommandResponse<DeleteObjectStoreEntriesCommand>
    {
    }
}