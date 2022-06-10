namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when page is about to start a download.
    /// Deprecated. Use Browser.downloadWillBegin instead.
    /// </summary>
    public sealed class DownloadWillBeginEvent : IEvent
    {
        /// <summary>
        /// Id of the frame that caused download to begin.
        /// </summary>
        [JsonProperty("frameId")]
        public string FrameId
        {
            get;
            set;
        }
        /// <summary>
        /// Global unique identifier of the download.
        /// </summary>
        [JsonProperty("guid")]
        public string Guid
        {
            get;
            set;
        }
        /// <summary>
        /// URL of the resource being downloaded.
        /// </summary>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
        /// <summary>
        /// Suggested file name of the resource (the actual name of the file saved on disk may differ).
        /// </summary>
        [JsonProperty("suggestedFilename")]
        public string SuggestedFilename
        {
            get;
            set;
        }
    }
}