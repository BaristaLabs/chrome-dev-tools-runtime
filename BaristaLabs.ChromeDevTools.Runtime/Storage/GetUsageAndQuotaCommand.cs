namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns usage and quota in bytes.
    /// </summary>
    public sealed class GetUsageAndQuotaCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Storage.getUsageAndQuota";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Security origin.
        /// </summary>
        [JsonProperty("origin")]
        public string Origin
        {
            get;
            set;
        }
    }

    public sealed class GetUsageAndQuotaCommandResponse : ICommandResponse<GetUsageAndQuotaCommand>
    {
        /// <summary>
        /// Storage usage (bytes).
        ///</summary>
        [JsonProperty("usage")]
        public double Usage
        {
            get;
            set;
        }
        /// <summary>
        /// Storage quota (bytes).
        ///</summary>
        [JsonProperty("quota")]
        public double Quota
        {
            get;
            set;
        }
        /// <summary>
        /// Storage usage per type (bytes).
        ///</summary>
        [JsonProperty("usageBreakdown")]
        public UsageForType[] UsageBreakdown
        {
            get;
            set;
        }
    }
}