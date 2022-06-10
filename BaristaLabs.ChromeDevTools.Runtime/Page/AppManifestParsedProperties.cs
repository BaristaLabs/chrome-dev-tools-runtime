namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Parsed app manifest properties.
    /// </summary>
    public sealed class AppManifestParsedProperties
    {
        /// <summary>
        /// Computed scope value
        ///</summary>
        [JsonProperty("scope")]
        public string Scope
        {
            get;
            set;
        }
    }
}