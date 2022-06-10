namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Debug symbols available for a wasm script.
    /// </summary>
    public sealed class DebugSymbols
    {
        /// <summary>
        /// Type of the debug symbols.
        ///</summary>
        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }
        /// <summary>
        /// URL of the external symbol source.
        ///</summary>
        [JsonProperty("externalURL", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ExternalURL
        {
            get;
            set;
        }
    }
}