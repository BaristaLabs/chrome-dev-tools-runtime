namespace BaristaLabs.ChromeDevTools.Runtime.HeadlessExperimental
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enables headless events for the target.
    /// </summary>
    public sealed class EnableCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "HeadlessExperimental.enable";
        
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