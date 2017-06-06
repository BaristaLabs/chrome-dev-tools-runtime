namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class CSSComputedStyleProperty
    {
    
        /// <summary>
        /// Computed style property name.
        ///</summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
    
        /// <summary>
        /// Computed style property value.
        ///</summary>
        [JsonProperty("value")]
        public string Value
        {
            get;
            set;
        }
    
    }
}