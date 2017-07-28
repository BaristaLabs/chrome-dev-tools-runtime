namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using Newtonsoft.Json;

    /// <summary>
    /// Issued when detached from target for any reason (including &lt;code&gt;detachFromTarget&lt;/code&gt; command).
    /// </summary>
    public sealed class DetachedFromTargetEvent : IEvent
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
    }
}