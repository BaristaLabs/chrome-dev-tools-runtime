namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Usage for a storage type.
    /// </summary>
    public sealed class UsageForType
    {
        /// <summary>
        /// Name of storage type.
        ///</summary>
        [JsonProperty("storageType")]
        public StorageType StorageType
        {
            get;
            set;
        }
        /// <summary>
        /// Storage usage (bytes).
        ///</summary>
        [JsonProperty("usage")]
        public double Usage
        {
            get;
            set;
        }
    }
}