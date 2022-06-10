namespace BaristaLabs.ChromeDevTools.Runtime.HeapProfiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// A single sample from a sampling profile.
    /// </summary>
    public sealed class SamplingHeapProfileSample
    {
        /// <summary>
        /// Allocation size in bytes attributed to the sample.
        ///</summary>
        [JsonProperty("size")]
        public double Size
        {
            get;
            set;
        }
        /// <summary>
        /// Id of the corresponding profile tree node.
        ///</summary>
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
        /// <summary>
        /// Time-ordered sample ordinal number. It is unique across all profiles retrieved
        /// between startSampling and stopSampling.
        ///</summary>
        [JsonProperty("ordinal")]
        public double Ordinal
        {
            get;
            set;
        }
    }
}