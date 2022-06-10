namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when opening document to write to.
    /// </summary>
    public sealed class DocumentOpenedEvent : IEvent
    {
        /// <summary>
        /// Frame object.
        /// </summary>
        [JsonProperty("frame")]
        public Frame Frame
        {
            get;
            set;
        }
    }
}