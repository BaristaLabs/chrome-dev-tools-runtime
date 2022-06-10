namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using Newtonsoft.Json;

    /// <summary>
    /// TargetInfo
    /// </summary>
    public sealed class TargetInfo
    {
        /// <summary>
        /// targetId
        ///</summary>
        [JsonProperty("targetId")]
        public string TargetId
        {
            get;
            set;
        }
        /// <summary>
        /// type
        ///</summary>
        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }
        /// <summary>
        /// title
        ///</summary>
        [JsonProperty("title")]
        public string Title
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
        /// Whether the target has an attached client.
        ///</summary>
        [JsonProperty("attached")]
        public bool Attached
        {
            get;
            set;
        }
        /// <summary>
        /// Opener target Id
        ///</summary>
        [JsonProperty("openerId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string OpenerId
        {
            get;
            set;
        }
        /// <summary>
        /// Whether the target has access to the originating window.
        ///</summary>
        [JsonProperty("canAccessOpener")]
        public bool CanAccessOpener
        {
            get;
            set;
        }
        /// <summary>
        /// Frame id of originating window (is only set if target has an opener).
        ///</summary>
        [JsonProperty("openerFrameId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string OpenerFrameId
        {
            get;
            set;
        }
        /// <summary>
        /// browserContextId
        ///</summary>
        [JsonProperty("browserContextId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BrowserContextId
        {
            get;
            set;
        }
    }
}