namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// Issued when unhandled exception was revoked.
    /// </summary>
    public sealed class ExceptionRevokedEvent : IEvent
    {
        /// <summary>
        /// Reason describing why exception was revoked.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason
        {
            get;
            set;
        }
        /// <summary>
        /// The id of revoked exception, as reported in &lt;code&gt;exceptionUnhandled&lt;/code&gt;.
        /// </summary>
        [JsonProperty("exceptionId")]
        public long ExceptionId
        {
            get;
            set;
        }
    }
}