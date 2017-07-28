namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// CSS property declaration data.
    /// </summary>
    public sealed class CSSProperty
    {
        /// <summary>
        /// The property name.
        ///</summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// The property value.
        ///</summary>
        [JsonProperty("value")]
        public string Value
        {
            get;
            set;
        }
        /// <summary>
        /// Whether the property has &quot;!important&quot; annotation (implies &lt;code&gt;false&lt;/code&gt; if absent).
        ///</summary>
        [JsonProperty("important", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Important
        {
            get;
            set;
        }
        /// <summary>
        /// Whether the property is implicit (implies &lt;code&gt;false&lt;/code&gt; if absent).
        ///</summary>
        [JsonProperty("implicit", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Implicit
        {
            get;
            set;
        }
        /// <summary>
        /// The full property text as specified in the style.
        ///</summary>
        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Text
        {
            get;
            set;
        }
        /// <summary>
        /// Whether the property is understood by the browser (implies &lt;code&gt;true&lt;/code&gt; if absent).
        ///</summary>
        [JsonProperty("parsedOk", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? ParsedOk
        {
            get;
            set;
        }
        /// <summary>
        /// Whether the property is disabled by the user (present for source-based properties only).
        ///</summary>
        [JsonProperty("disabled", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Disabled
        {
            get;
            set;
        }
        /// <summary>
        /// The entire property range in the enclosing style declaration (if available).
        ///</summary>
        [JsonProperty("range", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SourceRange Range
        {
            get;
            set;
        }
    }
}