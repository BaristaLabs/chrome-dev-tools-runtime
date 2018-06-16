namespace BaristaLabs.ChromeDevTools.Runtime.Memory
{
    using Newtonsoft.Json;

    /// <summary>
    /// Array of heap profile samples.
    /// </summary>
    public sealed class SamplingProfile
    {
        /// <summary>
        /// samples
        ///</summary>
        [JsonProperty("samples")]
        public SamplingProfileNode[] Samples
        {
            get;
            set;
        }
    }
}