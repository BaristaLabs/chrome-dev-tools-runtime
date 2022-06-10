namespace BaristaLabs.ChromeDevTools.Runtime.Browser
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when download makes progress. Last call has |done| == true.
    /// </summary>
    public sealed class DownloadProgressEvent : IEvent
    {
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
        /// Total expected bytes to download.
        /// </summary>
        [JsonProperty("totalBytes")]
        public double TotalBytes
        {
            get;
            set;
        }
        /// <summary>
        /// Total bytes received.
        /// </summary>
        [JsonProperty("receivedBytes")]
        public double ReceivedBytes
        {
            get;
            set;
        }
        /// <summary>
        /// Download status.
        /// </summary>
        [JsonProperty("state")]
        public string State
        {
            get;
            set;
        }
    }
}