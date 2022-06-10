namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// Description of an isolated world.
    /// </summary>
    public sealed class ExecutionContextDescription
    {
        /// <summary>
        /// Unique id of the execution context. It can be used to specify in which execution context
        /// script evaluation should be performed.
        ///</summary>
        [JsonProperty("id")]
        public long Id
        {
            get;
            set;
        }
        /// <summary>
        /// Execution context origin.
        ///</summary>
        [JsonProperty("origin")]
        public string Origin
        {
            get;
            set;
        }
        /// <summary>
        /// Human readable name describing given context.
        ///</summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// A system-unique execution context identifier. Unlike the id, this is unique across
        /// multiple processes, so can be reliably used to identify specific context while backend
        /// performs a cross-process navigation.
        ///</summary>
        [JsonProperty("uniqueId")]
        public string UniqueId
        {
            get;
            set;
        }
        /// <summary>
        /// Embedder-specific auxiliary data.
        ///</summary>
        [JsonProperty("auxData", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object AuxData
        {
            get;
            set;
        }
    }
}