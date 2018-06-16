namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// CustomPreview
    /// </summary>
    public sealed class CustomPreview
    {
        /// <summary>
        /// header
        ///</summary>
        [JsonProperty("header")]
        public string Header
        {
            get;
            set;
        }
        /// <summary>
        /// hasBody
        ///</summary>
        [JsonProperty("hasBody")]
        public bool HasBody
        {
            get;
            set;
        }
        /// <summary>
        /// formatterObjectId
        ///</summary>
        [JsonProperty("formatterObjectId")]
        public string FormatterObjectId
        {
            get;
            set;
        }
        /// <summary>
        /// bindRemoteObjectFunctionId
        ///</summary>
        [JsonProperty("bindRemoteObjectFunctionId")]
        public string BindRemoteObjectFunctionId
        {
            get;
            set;
        }
        /// <summary>
        /// configObjectId
        ///</summary>
        [JsonProperty("configObjectId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ConfigObjectId
        {
            get;
            set;
        }
    }
}