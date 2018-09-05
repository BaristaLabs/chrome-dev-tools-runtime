namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Clears seeded compilation cache.
    /// </summary>
    public sealed class ClearCompilationCacheCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.clearCompilationCache";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class ClearCompilationCacheCommandResponse : ICommandResponse<ClearCompilationCacheCommand>
    {
    }
}