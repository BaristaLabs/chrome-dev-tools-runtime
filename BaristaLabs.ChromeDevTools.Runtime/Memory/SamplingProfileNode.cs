namespace BaristaLabs.ChromeDevTools.Runtime.Memory
{
    using Newtonsoft.Json;

    /// <summary>
    /// Heap profile sample.
    /// </summary>
    public sealed class SamplingProfileNode
    {
        /// <summary>
        /// Size of the sampled allocation.
        ///</summary>
        [JsonProperty("size")]
        public double Size
        {
            get;
            set;
        }
        /// <summary>
        /// Total bytes attributed to this sample.
        ///</summary>
        [JsonProperty("total")]
        public double Total
        {
            get;
            set;
        }
        /// <summary>
        /// Execution stack at the point of allocation.
        ///</summary>
        [JsonProperty("stack")]
        public string[] Stack
        {
            get;
            set;
        }
    }
}