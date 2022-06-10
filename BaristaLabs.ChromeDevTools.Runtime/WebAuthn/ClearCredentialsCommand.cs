namespace BaristaLabs.ChromeDevTools.Runtime.WebAuthn
{
    using Newtonsoft.Json;

    /// <summary>
    /// Clears all the credentials from the specified device.
    /// </summary>
    public sealed class ClearCredentialsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "WebAuthn.clearCredentials";
        
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

    public sealed class ClearCredentialsCommandResponse : ICommandResponse<ClearCredentialsCommand>
    {
    }
}