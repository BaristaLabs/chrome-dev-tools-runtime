namespace BaristaLabs.ChromeDevTools.Runtime.DOMSnapshot
{
    using Newtonsoft.Json;

    /// <summary>
    /// A name/value pair.
    /// </summary>
    public sealed class NameValue
    {
        /// <summary>
        /// Attribute/property name.
        ///</summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// Attribute/property value.
        ///</summary>
        [JsonProperty("value")]
        public string Value
        {
            get;
            set;
        }
    }
}