namespace BaristaLabs.ChromeDevTools.Runtime.Profiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// Coverage data for a JavaScript function.
    /// </summary>
    public sealed class FunctionCoverage
    {
        /// <summary>
        /// JavaScript function name.
        ///</summary>
        [JsonProperty("functionName")]
        public string FunctionName
        {
            get;
            set;
        }
        /// <summary>
        /// Source ranges inside the function with coverage data.
        ///</summary>
        [JsonProperty("ranges")]
        public CoverageRange[] Ranges
        {
            get;
            set;
        }
    }
}