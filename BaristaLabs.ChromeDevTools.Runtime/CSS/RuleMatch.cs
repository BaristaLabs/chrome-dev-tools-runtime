namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Match data for a CSS rule.
    /// </summary>
    public sealed class RuleMatch
    {
        /// <summary>
        /// CSS rule in the match.
        ///</summary>
        [JsonProperty("rule")]
        public CSSRule Rule
        {
            get;
            set;
        }
        /// <summary>
        /// Matching selector indices in the rule's selectorList selectors (0-based).
        ///</summary>
        [JsonProperty("matchingSelectors")]
        public long[] MatchingSelectors
        {
            get;
            set;
        }
    }
}