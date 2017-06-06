namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Inherited CSS rule collection from ancestor node.
    /// </summary>
    public sealed class InheritedStyleEntry
    {
    
        /// <summary>
        /// The ancestor node's inline style, if any, in the style inheritance chain.
        ///</summary>
        [JsonProperty("inlineStyle", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CSSStyle InlineStyle
        {
            get;
            set;
        }
    
        /// <summary>
        /// Matches of CSS rules matching the ancestor node in the style inheritance chain.
        ///</summary>
        [JsonProperty("matchedCSSRules")]
        public RuleMatch[] MatchedCSSRules
        {
            get;
            set;
        }
    
    }
}