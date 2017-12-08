namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when window.open() was called
    /// </summary>
    public sealed class WindowOpenEvent : IEvent
    {
        /// <summary>
        /// The URL for the new window.
        /// </summary>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
        /// <summary>
        /// Window name passed to window.open().
        /// </summary>
        [JsonProperty("windowName")]
        public string WindowName
        {
            get;
            set;
        }
        /// <summary>
        /// Window features passed to window.open().
        /// </summary>
        [JsonProperty("windowFeatures")]
        public string WindowFeatures
        {
            get;
            set;
        }
        /// <summary>
        /// Whether or not window.open() was triggered by user gesture.
        /// </summary>
        [JsonProperty("userGesture")]
        public bool UserGesture
        {
            get;
            set;
        }
    }
}