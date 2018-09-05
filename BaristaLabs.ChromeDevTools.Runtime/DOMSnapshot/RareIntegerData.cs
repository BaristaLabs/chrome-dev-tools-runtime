namespace BaristaLabs.ChromeDevTools.Runtime.DOMSnapshot
{
    using Newtonsoft.Json;

    /// <summary>
    /// RareIntegerData
    /// </summary>
    public sealed class RareIntegerData
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