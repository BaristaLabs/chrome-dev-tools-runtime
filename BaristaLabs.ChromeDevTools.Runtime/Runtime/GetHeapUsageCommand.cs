namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns the JavaScript heap usage.
    /// It is the total usage of the corresponding isolate not scoped to a particular Runtime.
    /// </summary>
    public sealed class GetHeapUsageCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Runtime.getHeapUsage";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class GetHeapUsageCommandResponse : ICommandResponse<GetHeapUsageCommand>
    {
        /// <summary>
        /// Used heap size in bytes.
        ///</summary>
        [JsonProperty("usedSize")]
        public double UsedSize
        {
            get;
            set;
        }
        /// <summary>
        /// Allocated heap size in bytes.
        ///</summary>
        [JsonProperty("totalSize")]
        public double TotalSize
        {
            get;
            set;
        }
    }
}