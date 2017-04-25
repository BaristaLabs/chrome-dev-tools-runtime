namespace BaristaLabs.ChromeDevTools.Runtime.Log
{
    using Newtonsoft.Json;

    /// <summary>
    /// Issued when new message was logged.
    /// </summary>
    public sealed class EntryAddedEvent : IEvent
    {
        /// <summary>
        /// The entry.
        /// </summary>
        [JsonProperty("entry")]
        public LogEntry Entry
        {
            get;
            set;
        }
    }
}