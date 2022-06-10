namespace BaristaLabs.ChromeDevTools.Runtime.WebAuthn
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sets whether User Verification succeeds or fails for an authenticator.
    /// The default is true.
    /// </summary>
    public sealed class SetUserVerifiedCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "WebAuthn.setUserVerified";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the authenticatorId
        /// </summary>
        [JsonProperty("authenticatorId")]
        public string AuthenticatorId
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the isUserVerified
        /// </summary>
        [JsonProperty("isUserVerified")]
        public bool IsUserVerified
        {
            get;
            set;
        }
    }

    public sealed class SetUserVerifiedCommandResponse : ICommandResponse<SetUserVerifiedCommand>
    {
    }
}