namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when frame has stopped loading.
    /// </summary>
    public sealed class FrameStoppedLoadingEvent : IEvent
    {
        /// <summary>
        /// Id of the frame that has stopped loading.
        /// </summary>
        [JsonProperty("frameId")]
        public string FrameId
        {
            get;
            set;
        }
    }
}