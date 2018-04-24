namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Properties of a web font: https://www.w3.org/TR/2008/REC-CSS2-20080411/fonts.html#font-descriptions
    /// </summary>
    public sealed class FontFace
    {
        /// <summary>
        /// The font-family.
        ///</summary>
        [JsonProperty("fontFamily")]
        public string FontFamily
        {
            get;
            set;
        }
        /// <summary>
        /// The font-style.
        ///</summary>
        [JsonProperty("fontStyle")]
        public string FontStyle
        {
            get;
            set;
        }
        /// <summary>
        /// The font-variant.
        ///</summary>
        [JsonProperty("fontVariant")]
        public string FontVariant
        {
            get;
            set;
        }
        /// <summary>
        /// The font-weight.
        ///</summary>
        [JsonProperty("fontWeight")]
        public string FontWeight
        {
            get;
            set;
        }
        /// <summary>
        /// The font-stretch.
        ///</summary>
        [JsonProperty("fontStretch")]
        public string FontStretch
        {
            get;
            set;
        }
        /// <summary>
        /// The unicode-range.
        ///</summary>
        [JsonProperty("unicodeRange")]
        public string UnicodeRange
        {
            get;
            set;
        }
        /// <summary>
        /// The src.
        ///</summary>
        [JsonProperty("src")]
        public string Src
        {
            get;
            set;
        }
        /// <summary>
        /// The resolved platform font family
        ///</summary>
        [JsonProperty("platformFontFamily")]
        public string PlatformFontFamily
        {
            get;
            set;
        }
    }
}