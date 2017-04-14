namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Media query descriptor.
    /// </summary>
    public sealed class MediaQuery
    {
    
        /// <summary>
        /// Array of media query expressions.
        ///</summary>
        [JsonProperty("expressions")]
        public MediaQueryExpression[] Expressions
        {
            get;
            set;
        }
    
        /// <summary>
        /// Whether the media query condition is satisfied.
        ///</summary>
        [JsonProperty("active")]
        public bool Active
        {
            get;
            set;
        }
    
    }
}