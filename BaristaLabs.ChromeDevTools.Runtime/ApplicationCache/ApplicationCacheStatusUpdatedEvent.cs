namespace BaristaLabs.ChromeDevTools.Runtime.ApplicationCache
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ApplicationCacheStatusUpdatedEvent : IEvent
    {
        /// <summary>
        /// Identifier of the frame containing document whose application cache updated status.
        /// </summary>
        [JsonProperty("frameId")]
        public string FrameId
        {
            get;
            set;
        }
        /// <summary>
        /// Manifest URL.
        /// </summary>
        [JsonProperty("manifestURL")]
        public string ManifestURL
        {
            get;
            set;
        }
        /// <summary>
        /// Updated application cache status.
        /// </summary>
        [JsonProperty("status")]
        public long Status
        {
            get;
            set;
        }
    }
}