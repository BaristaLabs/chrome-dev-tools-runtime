namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// Issued when console API was called.
    /// </summary>
    public sealed class ConsoleAPICalledEvent : IEvent
    {
        /// <summary>
        /// Type of the call.
        /// </summary>
        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }
        /// <summary>
        /// Call arguments.
        /// </summary>
        [JsonProperty("args")]
        public RemoteObject[] Args
        {
            get;
            set;
        }
        /// <summary>
        /// Identifier of the context where the call was made.
        /// </summary>
        [JsonProperty("executionContextId")]
        public long ExecutionContextId
        {
            get;
            set;
        }
        /// <summary>
        /// Call timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        public double Timestamp
        {
            get;
            set;
        }
        /// <summary>
        /// Stack trace captured when the call was made.
        /// </summary>
        [JsonProperty("stackTrace", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public StackTrace StackTrace
        {
            get;
            set;
        }
    }
}