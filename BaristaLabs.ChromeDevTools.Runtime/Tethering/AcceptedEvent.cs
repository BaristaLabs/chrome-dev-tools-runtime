namespace BaristaLabs.ChromeDevTools.Runtime.Tethering
{
    using Newtonsoft.Json;

    /// <summary>
    /// Informs that port was successfully bound and got a specified connection id.
    /// </summary>
    public sealed class AcceptedEvent : IEvent
    {
        /// <summary>
        /// Port number that was successfully bound.
        /// </summary>
        [JsonProperty("port")]
        public long Port
        {
            get;
            set;
        }
        /// <summary>
        /// Connection id to be used.
        /// </summary>
        [JsonProperty("connectionId")]
        public string ConnectionId
        {
            get;
            set;
        }
    }
}