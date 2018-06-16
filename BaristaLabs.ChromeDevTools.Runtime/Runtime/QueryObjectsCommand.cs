namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// QueryObjects
    /// </summary>
    public sealed class QueryObjectsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Runtime.queryObjects";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Identifier of the prototype to return objects for.
        /// </summary>
        [JsonProperty("prototypeObjectId")]
        public string PrototypeObjectId
        {
            get;
            set;
        }
        /// <summary>
        /// Symbolic group name that can be used to release the results.
        /// </summary>
        [JsonProperty("objectGroup", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ObjectGroup
        {
            get;
            set;
        }
    }

    public sealed class QueryObjectsCommandResponse : ICommandResponse<QueryObjectsCommand>
    {
        /// <summary>
        /// Array with objects.
        ///</summary>
        [JsonProperty("objects")]
        public RemoteObject Objects
        {
            get;
            set;
        }
    }
}