namespace BaristaLabs.ChromeDevTools.Runtime.Profiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// Collect type profile.
    /// </summary>
    public sealed class TakeTypeProfileCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Profiler.takeTypeProfile";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class TakeTypeProfileCommandResponse : ICommandResponse<TakeTypeProfileCommand>
    {
        /// <summary>
        /// Type profile for all scripts since startTypeProfile() was turned on.
        ///</summary>
        [JsonProperty("result")]
        public ScriptTypeProfile[] Result
        {
            get;
            set;
        }
    }
}