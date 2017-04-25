namespace BaristaLabs.ChromeDevTools.Runtime.Profiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// Coverage data for a source range.
    /// </summary>
    public sealed class CoverageRange
    {
        /// <summary>
        /// JavaScript script line number (0-based) for the range start.
        ///</summary>
        [JsonProperty("startLineNumber")]
        public long StartLineNumber
        {
            get;
            set;
        }
        /// <summary>
        /// JavaScript script column number (0-based) for the range start.
        ///</summary>
        [JsonProperty("startColumnNumber")]
        public long StartColumnNumber
        {
            get;
            set;
        }
        /// <summary>
        /// JavaScript script line number (0-based) for the range end.
        ///</summary>
        [JsonProperty("endLineNumber")]
        public long EndLineNumber
        {
            get;
            set;
        }
        /// <summary>
        /// JavaScript script column number (0-based) for the range end.
        ///</summary>
        [JsonProperty("endColumnNumber")]
        public long EndColumnNumber
        {
            get;
            set;
        }
        /// <summary>
        /// Collected execution count of the source range.
        ///</summary>
        [JsonProperty("count")]
        public long Count
        {
            get;
            set;
        }
    }
}