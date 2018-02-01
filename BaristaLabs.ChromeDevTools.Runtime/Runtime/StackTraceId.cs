namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// If <code>debuggerId</code> is set stack trace comes from another debugger and can be resolved there. This allows to track cross-debugger calls. See <code>Runtime.StackTrace</code> and <code>Debugger.paused</code> for usages.
    /// </summary>
    public sealed class StackTraceId
    {
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("debuggerId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string DebuggerId
        {
            get;
            set;
        }
    }
}