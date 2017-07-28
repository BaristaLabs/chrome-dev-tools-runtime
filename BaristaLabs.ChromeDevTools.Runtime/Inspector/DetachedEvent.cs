namespace BaristaLabs.ChromeDevTools.Runtime.Inspector
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when remote debugging connection is about to be terminated. Contains detach reason.
    /// </summary>
    public sealed class DetachedEvent : IEvent
    {
        /// <summary>
        /// The reason why connection has been terminated.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason
        {
            get;
            set;
        }
    }
}