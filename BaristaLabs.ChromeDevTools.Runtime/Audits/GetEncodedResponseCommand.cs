namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns the response body and size if it were re-encoded with the specified settings. Only
    /// applies to images.
    /// </summary>
    public sealed class GetEncodedResponseCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Audits.getEncodedResponse";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Identifier of the network request to get content for.
        /// </summary>
        [JsonProperty("requestId")]
        public string RequestId
        {
            get;
            set;
        }
        /// <summary>
        /// The encoding to use.
        /// </summary>
        [JsonProperty("encoding")]
        public string Encoding
        {
            get;
            set;
        }
        /// <summary>
        /// The quality of the encoding (0-1). (defaults to 1)
        /// </summary>
        [JsonProperty("quality", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? Quality
        {
            get;
            set;
        }
        /// <summary>
        /// Whether to only return the size information (defaults to false).
        /// </summary>
        [JsonProperty("sizeOnly", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? SizeOnly
        {
            get;
            set;
        }
    }

    public sealed class GetEncodedResponseCommandResponse : ICommandResponse<GetEncodedResponseCommand>
    {
        /// <summary>
        /// The encoded body as a base64 string. Omitted if sizeOnly is true.
        ///</summary>
        [JsonProperty("body", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public byte[] Body
        {
            get;
            set;
        }
        /// <summary>
        /// Size before re-encoding.
        ///</summary>
        [JsonProperty("originalSize")]
        public long OriginalSize
        {
            get;
            set;
        }
        /// <summary>
        /// Size after re-encoding.
        ///</summary>
        [JsonProperty("encodedSize")]
        public long EncodedSize
        {
            get;
            set;
        }
    }
}