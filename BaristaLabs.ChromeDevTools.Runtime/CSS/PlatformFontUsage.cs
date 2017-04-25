namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Information about amount of glyphs that were rendered with given font.
    /// </summary>
    public sealed class PlatformFontUsage
    {
        /// <summary>
        /// Font's family name reported by platform.
        ///</summary>
        [JsonProperty("familyName")]
        public string FamilyName
        {
            get;
            set;
        }
        /// <summary>
        /// Indicates if the font was downloaded or resolved locally.
        ///</summary>
        [JsonProperty("isCustomFont")]
        public bool IsCustomFont
        {
            get;
            set;
        }
        /// <summary>
        /// Amount of glyphs that were rendered with this font.
        ///</summary>
        [JsonProperty("glyphCount")]
        public double GlyphCount
        {
            get;
            set;
        }
    }
}