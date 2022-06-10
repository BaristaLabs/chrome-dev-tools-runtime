namespace BaristaLabs.ChromeDevTools.Runtime.Input
{
    using Newtonsoft.Json;

    /// <summary>
    /// Emitted only when `Input.setInterceptDrags` is enabled. Use this data with `Input.dispatchDragEvent` to
    /// restore normal drag and drop behavior.
    /// </summary>
    public sealed class DragInterceptedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the data
        /// </summary>
        [JsonProperty("data")]
        public DragData Data
        {
            get;
            set;
        }
    }
}