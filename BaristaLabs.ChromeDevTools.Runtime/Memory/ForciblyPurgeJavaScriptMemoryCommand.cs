namespace BaristaLabs.ChromeDevTools.Runtime.Memory
{
    using Newtonsoft.Json;

    /// <summary>
    /// Simulate OomIntervention by purging V8 memory.
    /// </summary>
    public sealed class ForciblyPurgeJavaScriptMemoryCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Memory.forciblyPurgeJavaScriptMemory";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class ForciblyPurgeJavaScriptMemoryCommandResponse : ICommandResponse<ForciblyPurgeJavaScriptMemoryCommand>
    {
    }
}