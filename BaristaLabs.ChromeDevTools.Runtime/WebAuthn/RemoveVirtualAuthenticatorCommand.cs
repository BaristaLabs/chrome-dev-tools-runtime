namespace BaristaLabs.ChromeDevTools.Runtime.WebAuthn
{
    using Newtonsoft.Json;

    /// <summary>
    /// Removes the given authenticator.
    /// </summary>
    public sealed class RemoveVirtualAuthenticatorCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "WebAuthn.removeVirtualAuthenticator";
        
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
    }

    public sealed class RemoveVirtualAuthenticatorCommandResponse : ICommandResponse<RemoveVirtualAuthenticatorCommand>
    {
    }
}