namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// SourceCodeLocation
    /// </summary>
    public sealed class SourceCodeLocation
    {
        /// <summary>
        /// scriptId
        ///</summary>
        [JsonProperty("scriptId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ScriptId
        {
            get;
            set;
        }
        /// <summary>
        /// url
        ///</summary>
        [JsonProperty("url")]
        public string Url
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