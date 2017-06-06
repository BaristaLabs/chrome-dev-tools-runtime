namespace BaristaLabs.ChromeDevTools.Runtime.IndexedDB
{
    using Newtonsoft.Json;

    /// <summary>
    /// Deletes a database.
    /// </summary>
    public sealed class DeleteDatabaseCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "IndexedDB.deleteDatabase";
        
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
    
    }

    public sealed class DeleteDatabaseCommandResponse : ICommandResponse<DeleteDatabaseCommand>
    {
    
    }
}