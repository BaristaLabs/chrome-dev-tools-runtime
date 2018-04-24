namespace BaristaLabs.ChromeDevTools.Runtime.Memory
{
    using Newtonsoft.Json;

    /// <summary>
    /// Stop collecting native memory profile.
    /// </summary>
    public sealed class StopSamplingCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Memory.stopSampling";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class StopSamplingCommandResponse : ICommandResponse<StopSamplingCommand>
    {
    }
}