namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Notification sent after the virtual time has advanced.
    /// </summary>
    public sealed class VirtualTimeAdvancedEvent : IEvent
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