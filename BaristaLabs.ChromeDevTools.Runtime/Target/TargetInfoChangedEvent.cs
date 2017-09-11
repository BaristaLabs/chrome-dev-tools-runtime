namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using Newtonsoft.Json;

    /// <summary>
    /// Issued when some information about a target has changed. This only happens between &lt;code&gt;targetCreated&lt;/code&gt; and &lt;code&gt;targetDestroyed&lt;/code&gt;.
    /// </summary>
    public sealed class TargetInfoChangedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the targetInfo
        /// </summary>
        [JsonProperty("targetInfo")]
        public TargetInfo TargetInfo
        {
            get;
            set;
        }
    }
}