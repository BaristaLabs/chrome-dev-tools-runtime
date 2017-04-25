namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when resource loading priority is changed
    /// </summary>
    public sealed class ResourceChangedPriorityEvent : IEvent
    {
        /// <summary>
        /// Request identifier.
        /// </summary>
        [JsonProperty("requestId")]
        public string RequestId
        {
            get;
            set;
        }
        /// <summary>
        /// New priority
        /// </summary>
        [JsonProperty("newPriority")]
        public ResourcePriority NewPriority
        {
            get;
            set;
        }
        /// <summary>
        /// Timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        public double Timestamp
        {
            get;
            set;
        }
    }
}