namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Data for a simple selector (these are delimited by commas in a selector list).
    /// </summary>
    public sealed class Value
    {
        /// <summary>
        /// Value text.
        ///</summary>
        [JsonProperty("text")]
        public string Text
        {
            get;
            set;
        }
        /// <summary>
        /// Value range in the underlying resource (if available).
        ///</summary>
        [JsonProperty("range", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SourceRange Range
        {
            get;
            set;
        }
    }
}