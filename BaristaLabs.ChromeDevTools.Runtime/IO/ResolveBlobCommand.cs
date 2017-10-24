namespace BaristaLabs.ChromeDevTools.Runtime.IO
{
    using Newtonsoft.Json;

    /// <summary>
    /// Return UUID of Blob object specified by a remote object id.
    /// </summary>
    public sealed class ResolveBlobCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "IO.resolveBlob";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Object id of a Blob object wrapper.
        /// </summary>
        [JsonProperty("objectId")]
        public string ObjectId
        {
            get;
            set;
        }
    }

    public sealed class ResolveBlobCommandResponse : ICommandResponse<ResolveBlobCommand>
    {
        /// <summary>
        /// UUID of the specified Blob.
        ///</summary>
        [JsonProperty("uuid")]
        public string Uuid
        {
            get;
            set;
        }
    }
}