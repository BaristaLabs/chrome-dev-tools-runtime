namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ShorthandEntry
    {
    
        /// <summary>
        /// Shorthand name.
        ///</summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
    
        /// <summary>
        /// Shorthand value.
        ///</summary>
        [JsonProperty("value")]
        public string Value
        {
            get;
            set;
        }
    
        /// <summary>
        /// Whether the property has "!important" annotation (implies <code>false</code> if absent).
        ///</summary>
        [JsonProperty("important", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Important
        {
            get;
            set;
        }
    
    }
}