namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// A descriptor of operation to mutate style declaration text.
    /// </summary>
    public sealed class StyleDeclarationEdit
    {
    
        /// <summary>
        /// The css style sheet identifier.
        ///</summary>
        [JsonProperty("styleSheetId")]
        public string StyleSheetId
        {
            get;
            set;
        }
    
        /// <summary>
        /// The range of the style text in the enclosing stylesheet.
        ///</summary>
        [JsonProperty("range")]
        public SourceRange Range
        {
            get;
            set;
        }
    
        /// <summary>
        /// New style text.
        ///</summary>
        [JsonProperty("text")]
        public string Text
        {
            get;
            set;
        }
    
    }
}