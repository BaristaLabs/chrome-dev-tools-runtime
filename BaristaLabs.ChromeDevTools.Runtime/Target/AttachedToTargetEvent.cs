namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using Newtonsoft.Json;

    /// <summary>
    /// Issued when attached to target because of auto-attach or &lt;code&gt;attachToTarget&lt;/code&gt; command.
    /// </summary>
    public sealed class AttachedToTargetEvent : IEvent
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
        /// <summary>
        /// Gets or sets the waitingForDebugger
        /// </summary>
        [JsonProperty("waitingForDebugger")]
        public bool WaitingForDebugger
        {
            get;
            set;
        }
    }
}