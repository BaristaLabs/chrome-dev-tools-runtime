namespace BaristaLabs.ChromeDevTools.Runtime.ServiceWorker
{
    using Newtonsoft.Json;

    /// <summary>
    /// ServiceWorker error message.
    /// </summary>
    public sealed class ServiceWorkerErrorMessage
    {
    
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("errorMessage")]
        public string ErrorMessage
        {
            get;
            set;
        }
    
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("registrationId")]
        public string RegistrationId
        {
            get;
            set;
        }
    
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("versionId")]
        public string VersionId
        {
            get;
            set;
        }
    
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("sourceURL")]
        public string SourceURL
        {
            get;
            set;
        }
    
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("lineNumber")]
        public long LineNumber
        {
            get;
            set;
        }
    
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("columnNumber")]
        public long ColumnNumber
        {
            get;
            set;
        }
    
    }
}