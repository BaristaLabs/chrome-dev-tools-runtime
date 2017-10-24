namespace BaristaLabs.ChromeDevTools.Runtime.Memory
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class PrepareForLeakDetectionCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Memory.prepareForLeakDetection";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class PrepareForLeakDetectionCommandResponse : ICommandResponse<PrepareForLeakDetectionCommand>
    {
    }
}