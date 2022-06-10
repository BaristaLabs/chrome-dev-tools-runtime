namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Removes all Trust Tokens issued by the provided issuerOrigin.
    /// Leaves other stored data, including the issuer's Redemption Records, intact.
    /// </summary>
    public sealed class ClearTrustTokensCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Storage.clearTrustTokens";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the issuerOrigin
        /// </summary>
        [JsonProperty("issuerOrigin")]
        public string IssuerOrigin
        {
            get;
            set;
        }
    }

    public sealed class ClearTrustTokensCommandResponse : ICommandResponse<ClearTrustTokensCommand>
    {
        /// <summary>
        /// True if any tokens were deleted, false otherwise.
        ///</summary>
        [JsonProperty("didDeleteTokens")]
        public bool DidDeleteTokens
        {
            get;
            set;
        }
    }
}