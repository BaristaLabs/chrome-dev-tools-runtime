namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class CustomPreview
    {
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("header")]
        public string Header
        {
            get;
            set;
        }
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("hasBody")]
        public bool HasBody
        {
            get;
            set;
        }
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("formatterObjectId")]
        public string FormatterObjectId
        {
            get;
            set;
        }
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("bindRemoteObjectFunctionId")]
        public string BindRemoteObjectFunctionId
        {
            get;
            set;
        }
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("configObjectId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ConfigObjectId
        {
            get;
            set;
        }
    }
}