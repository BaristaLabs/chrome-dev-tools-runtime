namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// CSS rule collection for a single pseudo style.
    /// </summary>
    public sealed class PseudoElementMatches
    {
    
        /// <summary>
        /// Pseudo element type.
        ///</summary>
        [JsonProperty("pseudoType")]
        public DOM.PseudoType PseudoType
        {
            get;
            set;
        }
    
        /// <summary>
        /// Matches of CSS rules applicable to the pseudo style.
        ///</summary>
        [JsonProperty("matches")]
        public RuleMatch[] Matches
        {
            get;
            set;
        }
    
    }
}