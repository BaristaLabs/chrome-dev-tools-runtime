namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Selector list data.
    /// </summary>
    public sealed class SelectorList
    {
    
        /// <summary>
        /// Selectors in the list.
        ///</summary>
        [JsonProperty("selectors")]
        public Value[] Selectors
        {
            get;
            set;
        }
    
        /// <summary>
        /// Rule selector text.
        ///</summary>
        [JsonProperty("text")]
        public string Text
        {
            get;
            set;
        }
    
    }
}