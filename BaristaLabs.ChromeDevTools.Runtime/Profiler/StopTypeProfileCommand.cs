namespace BaristaLabs.ChromeDevTools.Runtime.Profiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// Disable type profile. Disabling releases type profile data collected so far.
    /// </summary>
    public sealed class StopTypeProfileCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Profiler.stopTypeProfile";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class StopTypeProfileCommandResponse : ICommandResponse<StopTypeProfileCommand>
    {
    }
}