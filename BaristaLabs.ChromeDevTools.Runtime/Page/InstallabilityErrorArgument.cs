namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// InstallabilityErrorArgument
    /// </summary>
    public sealed class InstallabilityErrorArgument
    {
        /// <summary>
        /// Argument name (e.g. name:'minimum-icon-size-in-pixels').
        ///</summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// Argument value (e.g. value:'64').
        ///</summary>
        [JsonProperty("value")]
        public string Value
        {
            get;
            set;
        }
    }
}