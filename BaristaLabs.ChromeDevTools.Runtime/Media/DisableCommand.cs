namespace BaristaLabs.ChromeDevTools.Runtime.Media
{
    using Newtonsoft.Json;

    /// <summary>
    /// Disables the Media domain.
    /// </summary>
    public sealed class DisableCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Media.disable";
        
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