namespace BaristaLabs.ChromeDevTools.Runtime.WebAuthn
{
    using Newtonsoft.Json;

    /// <summary>
    /// Adds the credential to the specified authenticator.
    /// </summary>
    public sealed class AddCredentialCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "WebAuthn.addCredential";
        
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
        /// Gets or sets the credential
        /// </summary>
        [JsonProperty("credential")]
        public Credential Credential
        {
            get;
            set;
        }
    }

    public sealed class AddCredentialCommandResponse : ICommandResponse<AddCredentialCommand>
    {
    }
}