namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// This issue tracks client hints related issues. It's used to deprecate old
    /// features, encourage the use of new ones, and provide general guidance.
    /// </summary>
    public sealed class ClientHintIssueDetails
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
        /// clientHintIssueReason
        ///</summary>
        [JsonProperty("clientHintIssueReason")]
        public ClientHintIssueReason ClientHintIssueReason
        {
            get;
            set;
        }
    }
}