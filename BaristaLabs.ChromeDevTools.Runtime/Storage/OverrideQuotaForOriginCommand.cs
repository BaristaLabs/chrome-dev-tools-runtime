namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Override quota for the specified origin
    /// </summary>
    public sealed class OverrideQuotaForOriginCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Storage.overrideQuotaForOrigin";
        
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
        /// <summary>
        /// The quota size (in bytes) to override the original quota with.
        /// If this is called multiple times, the overridden quota will be equal to
        /// the quotaSize provided in the final call. If this is called without
        /// specifying a quotaSize, the quota will be reset to the default value for
        /// the specified origin. If this is called multiple times with different
        /// origins, the override will be maintained for each origin until it is
        /// disabled (called without a quotaSize).
        /// </summary>
        [JsonProperty("quotaSize", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? QuotaSize
        {
            get;
            set;
        }
    }

    public sealed class OverrideQuotaForOriginCommandResponse : ICommandResponse<OverrideQuotaForOriginCommand>
    {
    }
}