namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when same-document navigation happens, e.g. due to history API usage or anchor navigation.
    /// </summary>
    public sealed class NavigatedWithinDocumentEvent : IEvent
    {
        /// <summary>
        /// Id of the frame.
        /// </summary>
        [JsonProperty("frameId")]
        public string FrameId
        {
            get;
            set;
        }
        /// <summary>
        /// Frame's new url.
        /// </summary>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
    }
}