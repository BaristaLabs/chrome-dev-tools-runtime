namespace BaristaLabs.ChromeDevTools.Runtime.Performance
{
    using Newtonsoft.Json;

    /// <summary>
    /// Disable collecting and reporting metrics.
    /// </summary>
    public sealed class DisableCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Performance.disable";
        
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