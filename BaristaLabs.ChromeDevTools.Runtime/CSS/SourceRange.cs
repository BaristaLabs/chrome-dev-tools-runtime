namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Text range within a resource. All numbers are zero-based.
    /// </summary>
    public sealed class SourceRange
    {
    
        /// <summary>
        /// Start line of range.
        ///</summary>
        [JsonProperty("startLine")]
        public long StartLine
        {
            get;
            set;
        }
    
        /// <summary>
        /// Start column of range (inclusive).
        ///</summary>
        [JsonProperty("startColumn")]
        public long StartColumn
        {
            get;
            set;
        }
    
        /// <summary>
        /// End line of range
        ///</summary>
        [JsonProperty("endLine")]
        public long EndLine
        {
            get;
            set;
        }
    
        /// <summary>
        /// End column of range (exclusive).
        ///</summary>
        [JsonProperty("endColumn")]
        public long EndColumn
        {
            get;
            set;
        }
    
    }
}