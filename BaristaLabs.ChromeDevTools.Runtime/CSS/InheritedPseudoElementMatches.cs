namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Inherited pseudo element matches from pseudos of an ancestor node.
    /// </summary>
    public sealed class InheritedPseudoElementMatches
    {
        /// <summary>
        /// Matches of pseudo styles from the pseudos of an ancestor node.
        ///</summary>
        [JsonProperty("pseudoElements")]
        public PseudoElementMatches[] PseudoElements
        {
            get;
            set;
        }
    }
}