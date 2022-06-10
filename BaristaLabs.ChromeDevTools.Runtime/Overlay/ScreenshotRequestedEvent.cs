namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when user asks to capture screenshot of some area on the page.
    /// </summary>
    public sealed class ScreenshotRequestedEvent : IEvent
    {
        /// <summary>
        /// Viewport to capture, in device independent pixels (dip).
        /// </summary>
        [JsonProperty("viewport")]
        public Page.Viewport Viewport
        {
            get;
            set;
        }
    }
}