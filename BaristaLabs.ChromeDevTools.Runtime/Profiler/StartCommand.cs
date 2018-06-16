namespace BaristaLabs.ChromeDevTools.Runtime.Profiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// Start
    /// </summary>
    public sealed class StartCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Profiler.start";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class StartCommandResponse : ICommandResponse<StartCommand>
    {
    }
}