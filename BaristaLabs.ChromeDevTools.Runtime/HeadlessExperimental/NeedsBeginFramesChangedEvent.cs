namespace BaristaLabs.ChromeDevTools.Runtime.HeadlessExperimental
{
    using Newtonsoft.Json;

    /// <summary>
    /// Issued when the target starts or stops needing BeginFrames.
    /// Deprecated. Issue beginFrame unconditionally instead and use result from
    /// beginFrame to detect whether the frames were suppressed.
    /// </summary>
    public sealed class NeedsBeginFramesChangedEvent : IEvent
    {
        /// <summary>
        /// True if BeginFrames are needed, false otherwise.
        /// </summary>
        [JsonProperty("needsBeginFrames")]
        public bool NeedsBeginFrames
        {
            get;
            set;
        }
    }
}