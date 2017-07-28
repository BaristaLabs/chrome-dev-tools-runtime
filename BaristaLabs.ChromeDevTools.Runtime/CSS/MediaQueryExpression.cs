namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Media query expression descriptor.
    /// </summary>
    public sealed class MediaQueryExpression
    {
        /// <summary>
        /// Media query expression value.
        ///</summary>
        [JsonProperty("value")]
        public double Value
        {
            get;
            set;
        }
        /// <summary>
        /// Media query expression units.
        ///</summary>
        [JsonProperty("unit")]
        public string Unit
        {
            get;
            set;
        }
        /// <summary>
        /// Media query expression feature.
        ///</summary>
        [JsonProperty("feature")]
        public string Feature
        {
            get;
            set;
        }
        /// <summary>
        /// The associated range of the value text in the enclosing stylesheet (if available).
        ///</summary>
        [JsonProperty("valueRange", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SourceRange ValueRange
        {
            get;
            set;
        }
        /// <summary>
        /// Computed length of media query expression (if applicable).
        ///</summary>
        [JsonProperty("computedLength", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? ComputedLength
        {
            get;
            set;
        }
    }
}