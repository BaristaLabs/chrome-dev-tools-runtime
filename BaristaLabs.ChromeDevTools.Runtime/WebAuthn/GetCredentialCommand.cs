namespace BaristaLabs.ChromeDevTools.Runtime.WebAuthn
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns a single credential stored in the given virtual authenticator that
    /// matches the credential ID.
    /// </summary>
    public sealed class GetCredentialCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "WebAuthn.getCredential";
        
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
        /// Gets or sets the credentialId
        /// </summary>
        [JsonProperty("credentialId")]
        public byte[] CredentialId
        {
            get;
            set;
        }
    }

    public sealed class GetCredentialCommandResponse : ICommandResponse<GetCredentialCommand>
    {
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
}