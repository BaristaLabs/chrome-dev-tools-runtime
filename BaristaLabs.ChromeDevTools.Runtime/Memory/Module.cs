namespace BaristaLabs.ChromeDevTools.Runtime.Memory
{
    using Newtonsoft.Json;

    /// <summary>
    /// Executable module information
    /// </summary>
    public sealed class Module
    {
        /// <summary>
        /// Name of the module.
        ///</summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// UUID of the module.
        ///</summary>
        [JsonProperty("uuid")]
        public string Uuid
        {
            get;
            set;
        }
        /// <summary>
        /// Base address where the module is loaded into memory. Encoded as a decimal
        /// or hexadecimal (0x prefixed) string.
        ///</summary>
        [JsonProperty("baseAddress")]
        public string BaseAddress
        {
            get;
            set;
        }
        /// <summary>
        /// Size of the module in bytes.
        ///</summary>
        [JsonProperty("size")]
        public double Size
        {
            get;
            set;
        }
    }
}