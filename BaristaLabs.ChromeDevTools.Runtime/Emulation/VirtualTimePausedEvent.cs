namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Notification sent after the virtual time has paused.
    /// </summary>
    public sealed class VirtualTimePausedEvent : IEvent
    {
        /// <summary>
        /// The amount of virtual time that has elapsed in milliseconds since virtual time was first enabled.
        /// </summary>
        [JsonProperty("virtualTimeElapsed")]
        public long VirtualTimeElapsed
        {
            get;
            set;
        }
    }
}