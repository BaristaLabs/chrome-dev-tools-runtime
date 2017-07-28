namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// Issued when new execution context is created.
    /// </summary>
    public sealed class ExecutionContextCreatedEvent : IEvent
    {
        /// <summary>
        /// A newly created execution context.
        /// </summary>
        [JsonProperty("context")]
        public ExecutionContextDescription Context
        {
            get;
            set;
        }
    }
}