namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// ClientSecurityState
    /// </summary>
    public sealed class ClientSecurityState
    {
        /// <summary>
        /// initiatorIsSecureContext
        ///</summary>
        [JsonProperty("initiatorIsSecureContext")]
        public bool InitiatorIsSecureContext
        {
            get;
            set;
        }
        /// <summary>
        /// initiatorIPAddressSpace
        ///</summary>
        [JsonProperty("initiatorIPAddressSpace")]
        public IPAddressSpace InitiatorIPAddressSpace
        {
            get;
            set;
        }
        /// <summary>
        /// privateNetworkRequestPolicy
        ///</summary>
        [JsonProperty("privateNetworkRequestPolicy")]
        public PrivateNetworkRequestPolicy PrivateNetworkRequestPolicy
        {
            get;
            set;
        }
    }
}