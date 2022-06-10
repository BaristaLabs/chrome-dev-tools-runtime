namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns the number of stored Trust Tokens per issuer for the
    /// current browsing context.
    /// </summary>
    public sealed class GetTrustTokensCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Storage.getTrustTokens";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class GetTrustTokensCommandResponse : ICommandResponse<GetTrustTokensCommand>
    {
        /// <summary>
        /// Gets or sets the tokens
        /// </summary>
        [JsonProperty("tokens")]
        public TrustTokens[] Tokens
        {
            get;
            set;
        }
    }
}