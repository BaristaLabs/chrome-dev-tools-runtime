namespace BaristaLabs.ChromeDevTools.Runtime.ServiceWorker
{
    using Newtonsoft.Json;

    /// <summary>
    /// ServiceWorker error message.
    /// </summary>
    public sealed class ServiceWorkerErrorMessage
    {
        /// <summary>
        /// errorMessage
        ///</summary>
        [JsonProperty("errorMessage")]
        public string ErrorMessage
        {
            get;
            set;
        }
        /// <summary>
        /// registrationId
        ///</summary>
        [JsonProperty("registrationId")]
        public string RegistrationId
        {
            get;
            set;
        }
        /// <summary>
        /// versionId
        ///</summary>
        [JsonProperty("versionId")]
        public string VersionId
        {
            get;
            set;
        }
        /// <summary>
        /// sourceURL
        ///</summary>
        [JsonProperty("sourceURL")]
        public string SourceURL
        {
            get;
            set;
        }
        /// <summary>
        /// lineNumber
        ///</summary>
        [JsonProperty("lineNumber")]
        public long LineNumber
        {
            get;
            set;
        }
        /// <summary>
        /// columnNumber
        ///</summary>
        [JsonProperty("columnNumber")]
        public long ColumnNumber
        {
            get;
            set;
        }
    }
}