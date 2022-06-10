namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// SecurityIsolationStatus
    /// </summary>
    public sealed class SecurityIsolationStatus
    {
        /// <summary>
        /// coop
        ///</summary>
        [JsonProperty("coop", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CrossOriginOpenerPolicyStatus Coop
        {
            get;
            set;
        }
        /// <summary>
        /// coep
        ///</summary>
        [JsonProperty("coep", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CrossOriginEmbedderPolicyStatus Coep
        {
            get;
            set;
        }
    }
}