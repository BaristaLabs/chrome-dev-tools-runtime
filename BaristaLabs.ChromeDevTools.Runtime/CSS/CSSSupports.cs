namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// CSS Supports at-rule descriptor.
    /// </summary>
    public sealed class CSSSupports
    {
        /// <summary>
        /// Supports rule text.
        ///</summary>
        [JsonProperty("text")]
        public string Text
        {
            get;
            set;
        }
        /// <summary>
        /// Whether the supports condition is satisfied.
        ///</summary>
        [JsonProperty("active")]
        public bool Active
        {
            get;
            set;
        }
        /// <summary>
        /// The associated rule header range in the enclosing stylesheet (if
        /// available).
        ///</summary>
        [JsonProperty("range", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SourceRange Range
        {
            get;
            set;
        }
        /// <summary>
        /// Identifier of the stylesheet containing this object (if exists).
        ///</summary>
        [JsonProperty("styleSheetId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string StyleSheetId
        {
            get;
            set;
        }
    }
}