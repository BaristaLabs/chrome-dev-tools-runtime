namespace BaristaLabs.ChromeDevTools.Runtime.IndexedDB
{
    using Newtonsoft.Json;

    /// <summary>
    /// Key range.
    /// </summary>
    public sealed class KeyRange
    {
        /// <summary>
        /// Lower bound.
        ///</summary>
        [JsonProperty("lower", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Key Lower
        {
            get;
            set;
        }
        /// <summary>
        /// Upper bound.
        ///</summary>
        [JsonProperty("upper", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Key Upper
        {
            get;
            set;
        }
        /// <summary>
        /// If true lower bound is open.
        ///</summary>
        [JsonProperty("lowerOpen")]
        public bool LowerOpen
        {
            get;
            set;
        }
        /// <summary>
        /// If true upper bound is open.
        ///</summary>
        [JsonProperty("upperOpen")]
        public bool UpperOpen
        {
            get;
            set;
        }
    }
}