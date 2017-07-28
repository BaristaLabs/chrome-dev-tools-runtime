namespace BaristaLabs.ChromeDevTools.Runtime.HeapProfiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// Profile.
    /// </summary>
    public sealed class SamplingHeapProfile
    {
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("head")]
        public SamplingHeapProfileNode Head
        {
            get;
            set;
        }
    }
}