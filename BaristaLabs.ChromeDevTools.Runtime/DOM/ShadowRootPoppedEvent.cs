namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Called when shadow root is popped from the element.
    /// </summary>
    public sealed class ShadowRootPoppedEvent : IEvent
    {
        /// <summary>
        /// Host element id.
        /// </summary>
        [JsonProperty("hostId")]
        public long HostId
        {
            get;
            set;
        }
        /// <summary>
        /// Shadow root id.
        /// </summary>
        [JsonProperty("rootId")]
        public long RootId
        {
            get;
            set;
        }
    }
}