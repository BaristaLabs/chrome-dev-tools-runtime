namespace BaristaLabs.ChromeDevTools.Runtime.WebAuthn
{
    using Newtonsoft.Json;

    /// <summary>
    /// Removes a credential from the authenticator.
    /// </summary>
    public sealed class RemoveCredentialCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "WebAuthn.removeCredential";
        
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

    public sealed class RemoveCredentialCommandResponse : ICommandResponse<RemoveCredentialCommand>
    {
    }
}