namespace BaristaLabs.ChromeDevTools.Runtime.WebAuthn
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enable the WebAuthn domain and start intercepting credential storage and
    /// retrieval with a virtual authenticator.
    /// </summary>
    public sealed class EnableCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "WebAuthn.enable";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class EnableCommandResponse : ICommandResponse<EnableCommand>
    {
    }
}