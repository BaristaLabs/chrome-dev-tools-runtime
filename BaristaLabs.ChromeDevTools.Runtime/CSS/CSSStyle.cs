namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// CSS style representation.
    /// </summary>
    public sealed class CSSStyle
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
        /// CSS properties in the style.
        ///</summary>
        [JsonProperty("cssProperties")]
        public CSSProperty[] CssProperties
        {
            get;
            set;
        }
        /// <summary>
        /// Computed values for all shorthands found in the style.
        ///</summary>
        [JsonProperty("shorthandEntries")]
        public ShorthandEntry[] ShorthandEntries
        {
            get;
            set;
        }
        /// <summary>
        /// Style declaration text (if available).
        ///</summary>
        [JsonProperty("cssText", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string CssText
        {
            get;
            set;
        }
        /// <summary>
        /// Style declaration range in the enclosing stylesheet (if available).
        ///</summary>
        [JsonProperty("range", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SourceRange Range
        {
            get;
            set;
        }
    }
}