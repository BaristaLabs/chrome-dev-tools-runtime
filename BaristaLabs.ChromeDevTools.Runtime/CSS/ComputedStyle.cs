namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// A subset of the full ComputedStyle as defined by the request whitelist.
    /// </summary>
    public sealed class ComputedStyle
    {
    
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("properties")]
        public CSSComputedStyleProperty[] Properties
        {
            get;
            set;
        }
    
    }
}