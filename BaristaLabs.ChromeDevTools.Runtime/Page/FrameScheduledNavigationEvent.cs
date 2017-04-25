namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when frame schedules a potential navigation.
    /// </summary>
    public sealed class FrameScheduledNavigationEvent : IEvent
    {
        /// <summary>
        /// Id of the frame that has scheduled a navigation.
        /// </summary>
        [JsonProperty("frameId")]
        public string FrameId
        {
            get;
            set;
        }
        /// <summary>
        /// Delay (in seconds) until the navigation is scheduled to begin. The navigation is not guaranteed to start.
        /// </summary>
        [JsonProperty("delay")]
        public double Delay
        {
            get;
            set;
        }
    }
}