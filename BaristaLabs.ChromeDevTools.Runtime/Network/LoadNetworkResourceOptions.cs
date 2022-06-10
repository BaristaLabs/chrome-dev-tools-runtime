namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// An options object that may be extended later to better support CORS,
    /// CORB and streaming.
    /// </summary>
    public sealed class LoadNetworkResourceOptions
    {
        /// <summary>
        /// disableCache
        ///</summary>
        [JsonProperty("disableCache")]
        public bool DisableCache
        {
            get;
            set;
        }
        /// <summary>
        /// includeCredentials
        ///</summary>
        [JsonProperty("includeCredentials")]
        public bool IncludeCredentials
        {
            get;
            set;
        }
    }
}