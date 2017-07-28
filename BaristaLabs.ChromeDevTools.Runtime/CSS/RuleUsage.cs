namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// CSS coverage information.
    /// </summary>
    public sealed class RuleUsage
    {
        /// <summary>
        /// The css style sheet identifier (absent for user agent stylesheet and user-specified stylesheet rules) this rule came from.
        ///</summary>
        [JsonProperty("styleSheetId")]
        public string StyleSheetId
        {
            get;
            set;
        }
        /// <summary>
        /// Offset of the start of the rule (including selector) from the beginning of the stylesheet.
        ///</summary>
        [JsonProperty("startOffset")]
        public double StartOffset
        {
            get;
            set;
        }
        /// <summary>
        /// Offset of the end of the rule body from the beginning of the stylesheet.
        ///</summary>
        [JsonProperty("endOffset")]
        public double EndOffset
        {
            get;
            set;
        }
        /// <summary>
        /// Indicates whether the rule was actually used by some element in the page.
        ///</summary>
        [JsonProperty("used")]
        public bool Used
        {
            get;
            set;
        }
    }
}