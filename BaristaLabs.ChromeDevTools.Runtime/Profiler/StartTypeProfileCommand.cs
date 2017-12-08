namespace BaristaLabs.ChromeDevTools.Runtime.Profiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enable type profile.
    /// </summary>
    public sealed class StartTypeProfileCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Profiler.startTypeProfile";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class StartTypeProfileCommandResponse : ICommandResponse<StartTypeProfileCommand>
    {
    }
}