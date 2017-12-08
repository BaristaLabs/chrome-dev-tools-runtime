namespace BaristaLabs.ChromeDevTools.Runtime.HeadlessExperimental
{
    using Newtonsoft.Json;

    /// <summary>
    /// Disables headless events for the target.
    /// </summary>
    public sealed class DisableCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "HeadlessExperimental.disable";
        
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