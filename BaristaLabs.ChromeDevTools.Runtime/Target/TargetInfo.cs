namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class TargetInfo
    {
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("targetId")]
        public string TargetId
        {
            get;
            set;
        }
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("title")]
        public string Title
        {
            get;
            set;
        }
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
        /// <summary>
        /// Whether the target has an attached client.
        ///</summary>
        [JsonProperty("attached")]
        public bool Attached
        {
            get;
            set;
        }
    }
}