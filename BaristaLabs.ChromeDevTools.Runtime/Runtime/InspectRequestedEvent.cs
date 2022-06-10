namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// Issued when object should be inspected (for example, as a result of inspect() command line API
    /// call).
    /// </summary>
    public sealed class InspectRequestedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the object
        /// </summary>
        [JsonProperty("object")]
        public RemoteObject Object
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the hints
        /// </summary>
        [JsonProperty("hints")]
        public object Hints
        {
            get;
            set;
        }
        /// <summary>
        /// Identifier of the context where the call was made.
        /// </summary>
        [JsonProperty("executionContextId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? ExecutionContextId
        {
            get;
            set;
        }
    }
}