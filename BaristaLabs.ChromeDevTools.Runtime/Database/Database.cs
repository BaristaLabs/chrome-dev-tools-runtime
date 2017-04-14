namespace BaristaLabs.ChromeDevTools.Runtime.Database
{
    using Newtonsoft.Json;

    /// <summary>
    /// Database object.
    /// </summary>
    public sealed class Database
    {
    
        /// <summary>
        /// Database ID.
        ///</summary>
        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }
    
        /// <summary>
        /// Database domain.
        ///</summary>
        [JsonProperty("domain")]
        public string Domain
        {
            get;
            set;
        }
    
        /// <summary>
        /// Database name.
        ///</summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
    
        /// <summary>
        /// Database version.
        ///</summary>
        [JsonProperty("version")]
        public string Version
        {
            get;
            set;
        }
    
    }
}