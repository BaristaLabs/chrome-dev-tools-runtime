namespace BaristaLabs.ChromeDevTools.Runtime.Database
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ExecuteSQLCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Database.executeSQL";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the databaseId
        /// </summary>
        [JsonProperty("databaseId")]
        public string DatabaseId
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the query
        /// </summary>
        [JsonProperty("query")]
        public string Query
        {
            get;
            set;
        }
    }

    public sealed class ExecuteSQLCommandResponse : ICommandResponse<ExecuteSQLCommand>
    {
        /// <summary>
        /// Gets or sets the columnNames
        /// </summary>
        [JsonProperty("columnNames", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string[] ColumnNames
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the values
        /// </summary>
        [JsonProperty("values", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object[] Values
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the sqlError
        /// </summary>
        [JsonProperty("sqlError", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Error SqlError
        {
            get;
            set;
        }
    }
}