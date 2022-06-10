namespace BaristaLabs.ChromeDevTools.Runtime.Security
{
    using Newtonsoft.Json;

    /// <summary>
    /// The security state of the page changed.
    /// </summary>
    public sealed class VisibleSecurityStateChangedEvent : IEvent
    {
        /// <summary>
        /// Security state information about the page.
        /// </summary>
        [JsonProperty("visibleSecurityState")]
        public VisibleSecurityState VisibleSecurityState
        {
            get;
            set;
        }
    }
}