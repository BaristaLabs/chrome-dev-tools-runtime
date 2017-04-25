namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using Newtonsoft.Json;

    /// <summary>
    /// Notifies about new protocol message from attached target.
    /// </summary>
    public sealed class ReceivedMessageFromTargetEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the targetId
        /// </summary>
        [JsonProperty("targetId")]
        public string TargetId
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the message
        /// </summary>
        [JsonProperty("message")]
        public string Message
        {
            get;
            set;
        }
    }
}