namespace BaristaLabs.ChromeDevTools.Runtime.WebAuthn
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns all the credentials stored in the given virtual authenticator.
    /// </summary>
    public sealed class GetCredentialsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "WebAuthn.getCredentials";
        
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

    public sealed class GetCredentialsCommandResponse : ICommandResponse<GetCredentialsCommand>
    {
        /// <summary>
        /// Gets or sets the credentials
        /// </summary>
        [JsonProperty("credentials")]
        public Credential[] Credentials
        {
            get;
            set;
        }
    }
}