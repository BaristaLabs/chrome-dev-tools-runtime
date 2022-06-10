namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Emitted only when `page.interceptFileChooser` is enabled.
    /// </summary>
    public sealed class FileChooserOpenedEvent : IEvent
    {
        /// <summary>
        /// Id of the frame containing input node.
        /// </summary>
        [JsonProperty("frameId")]
        public string FrameId
        {
            get;
            set;
        }
        /// <summary>
        /// Input node id.
        /// </summary>
        [JsonProperty("backendNodeId")]
        public long BackendNodeId
        {
            get;
            set;
        }
        /// <summary>
        /// Input mode.
        /// </summary>
        [JsonProperty("mode")]
        public string Mode
        {
            get;
            set;
        }
    }
}