namespace BaristaLabs.ChromeDevTools.Runtime.DOMSnapshot
{
    using Newtonsoft.Json;

    /// <summary>
    /// A subset of the full ComputedStyle as defined by the request whitelist.
    /// </summary>
    public sealed class ComputedStyle
    {
        /// <summary>
        /// Name/value pairs of computed style properties.
        ///</summary>
        [JsonProperty("properties")]
        public NameValue[] Properties
        {
            get;
            set;
        }
    }
}