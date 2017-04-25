namespace BaristaLabs.ChromeDevTools.Runtime.Log
{
    using Newtonsoft.Json;

    /// <summary>
    /// Disables log domain, prevents further log entries from being reported to the client.
    /// </summary>
    public sealed class DisableCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Log.disable";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class DisableCommandResponse : ICommandResponse<DisableCommand>
    {
    }
}