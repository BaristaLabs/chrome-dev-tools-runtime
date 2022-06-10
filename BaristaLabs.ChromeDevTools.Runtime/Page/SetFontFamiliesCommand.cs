namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Set generic font families.
    /// </summary>
    public sealed class SetFontFamiliesCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.setFontFamilies";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Specifies font families to set. If a font family is not specified, it won't be changed.
        /// </summary>
        [JsonProperty("fontFamilies")]
        public FontFamilies FontFamilies
        {
            get;
            set;
        }
        /// <summary>
        /// Specifies font families to set for individual scripts.
        /// </summary>
        [JsonProperty("forScripts", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ScriptFontFamilies[] ForScripts
        {
            get;
            set;
        }
    }

    public sealed class SetFontFamiliesCommandResponse : ICommandResponse<SetFontFamiliesCommand>
    {
    }
}