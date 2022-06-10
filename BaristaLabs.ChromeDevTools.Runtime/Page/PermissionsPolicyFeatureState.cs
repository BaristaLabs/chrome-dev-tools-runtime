namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// PermissionsPolicyFeatureState
    /// </summary>
    public sealed class PermissionsPolicyFeatureState
    {
        /// <summary>
        /// feature
        ///</summary>
        [JsonProperty("feature")]
        public PermissionsPolicyFeature Feature
        {
            get;
            set;
        }
        /// <summary>
        /// allowed
        ///</summary>
        [JsonProperty("allowed")]
        public bool Allowed
        {
            get;
            set;
        }
        /// <summary>
        /// locator
        ///</summary>
        [JsonProperty("locator", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PermissionsPolicyBlockLocator Locator
        {
            get;
            set;
        }
    }
}