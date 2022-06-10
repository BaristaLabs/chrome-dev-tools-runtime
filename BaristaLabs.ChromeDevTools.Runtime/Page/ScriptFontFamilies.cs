namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Font families collection for a script.
    /// </summary>
    public sealed class ScriptFontFamilies
    {
        /// <summary>
        /// Name of the script which these font families are defined for.
        ///</summary>
        [JsonProperty("script")]
        public string Script
        {
            get;
            set;
        }
        /// <summary>
        /// Generic font families collection for the script.
        ///</summary>
        [JsonProperty("fontFamilies")]
        public FontFamilies FontFamilies
        {
            get;
            set;
        }
    }
}