namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// Details for a issue arising from an SAB being instantiated in, or
    /// transferred to a context that is not cross-origin isolated.
    /// </summary>
    public sealed class SharedArrayBufferIssueDetails
    {
        /// <summary>
        /// sourceCodeLocation
        ///</summary>
        [JsonProperty("sourceCodeLocation")]
        public SourceCodeLocation SourceCodeLocation
        {
            get;
            set;
        }
        /// <summary>
        /// isWarning
        ///</summary>
        [JsonProperty("isWarning")]
        public bool IsWarning
        {
            get;
            set;
        }
        /// <summary>
        /// type
        ///</summary>
        [JsonProperty("type")]
        public SharedArrayBufferIssueType Type
        {
            get;
            set;
        }
    }
}