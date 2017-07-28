namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Called when shadow root is pushed into the element.
    /// </summary>
    public sealed class ShadowRootPushedEvent : IEvent
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
        /// Shadow root.
        /// </summary>
        [JsonProperty("root")]
        public Node Root
        {
            get;
            set;
        }
    }
}