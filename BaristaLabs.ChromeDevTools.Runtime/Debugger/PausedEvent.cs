namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when the virtual machine stopped on breakpoint or exception or any other stop criteria.
    /// </summary>
    public sealed class PausedEvent : IEvent
    {
        /// <summary>
        /// Call stack the virtual machine stopped on.
        /// </summary>
        [JsonProperty("callFrames")]
        public CallFrame[] CallFrames
        {
            get;
            set;
        }
        /// <summary>
        /// Pause reason.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason
        {
            get;
            set;
        }
        /// <summary>
        /// Object containing break-specific auxiliary properties.
        /// </summary>
        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Data
        {
            get;
            set;
        }
        /// <summary>
        /// Hit breakpoints IDs
        /// </summary>
        [JsonProperty("hitBreakpoints", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string[] HitBreakpoints
        {
            get;
            set;
        }
        /// <summary>
        /// Async stack trace, if any.
        /// </summary>
        [JsonProperty("asyncStackTrace", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Runtime.StackTrace AsyncStackTrace
        {
            get;
            set;
        }
    }
}