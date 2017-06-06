namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// CSS rule representation.
    /// </summary>
    public sealed class CSSRule
    {
    
        /// <summary>
        /// The css style sheet identifier (absent for user agent stylesheet and user-specified stylesheet rules) this rule came from.
        ///</summary>
        [JsonProperty("styleSheetId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string StyleSheetId
        {
            get;
            set;
        }
    
        /// <summary>
        /// Rule selector data.
        ///</summary>
        [JsonProperty("selectorList")]
        public SelectorList SelectorList
        {
            get;
            set;
        }
    
        /// <summary>
        /// Parent stylesheet's origin.
        ///</summary>
        [JsonProperty("origin")]
        public StyleSheetOrigin Origin
        {
            get;
            set;
        }
    
        /// <summary>
        /// Associated style declaration.
        ///</summary>
        [JsonProperty("style")]
        public CSSStyle Style
        {
            get;
            set;
        }
    
        /// <summary>
        /// Media list array (for rules involving media queries). The array enumerates media queries starting with the innermost one, going outwards.
        ///</summary>
        [JsonProperty("media", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CSSMedia[] Media
        {
            get;
            set;
        }
    
    }
}