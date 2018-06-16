namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns the isolate id.
    /// </summary>
    public sealed class GetIsolateIdCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Runtime.getIsolateId";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class GetIsolateIdCommandResponse : ICommandResponse<GetIsolateIdCommand>
    {
        /// <summary>
        /// The isolate id.
        ///</summary>
        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }
    }
}