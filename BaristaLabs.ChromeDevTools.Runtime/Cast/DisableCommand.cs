namespace BaristaLabs.ChromeDevTools.Runtime.Cast
{
    using Newtonsoft.Json;

    /// <summary>
    /// Stops observing for sinks and issues.
    /// </summary>
    public sealed class DisableCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Cast.disable";
        
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