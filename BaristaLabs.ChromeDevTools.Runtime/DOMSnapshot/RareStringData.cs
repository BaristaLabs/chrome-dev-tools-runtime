namespace BaristaLabs.ChromeDevTools.Runtime.DOMSnapshot
{
    using Newtonsoft.Json;

    /// <summary>
    /// Data that is only present on rare nodes.
    /// </summary>
    public sealed class RareStringData
    {
        /// <summary>
        /// index
        ///</summary>
        [JsonProperty("index")]
        public long[] Index
        {
            get;
            set;
        }
        /// <summary>
        /// value
        ///</summary>
        [JsonProperty("value")]
        public long[] Value
        {
            get;
            set;
        }
    }
}