namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Information about font variation axes for variable fonts
    /// </summary>
    public sealed class FontVariationAxis
    {
        /// <summary>
        /// The font-variation-setting tag (a.k.a. "axis tag").
        ///</summary>
        [JsonProperty("tag")]
        public string Tag
        {
            get;
            set;
        }
        /// <summary>
        /// Human-readable variation name in the default language (normally, "en").
        ///</summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// The minimum value (inclusive) the font supports for this tag.
        ///</summary>
        [JsonProperty("minValue")]
        public double MinValue
        {
            get;
            set;
        }
        /// <summary>
        /// The maximum value (inclusive) the font supports for this tag.
        ///</summary>
        [JsonProperty("maxValue")]
        public double MaxValue
        {
            get;
            set;
        }
        /// <summary>
        /// The default value.
        ///</summary>
        [JsonProperty("defaultValue")]
        public double DefaultValue
        {
            get;
            set;
        }
    }
}