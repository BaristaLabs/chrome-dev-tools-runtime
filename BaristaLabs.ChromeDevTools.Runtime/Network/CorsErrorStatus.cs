namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// CorsErrorStatus
    /// </summary>
    public sealed class CorsErrorStatus
    {
        /// <summary>
        /// corsError
        ///</summary>
        [JsonProperty("corsError")]
        public CorsError CorsError
        {
            get;
            set;
        }
        /// <summary>
        /// failedParameter
        ///</summary>
        [JsonProperty("failedParameter")]
        public string FailedParameter
        {
            get;
            set;
        }
    }
}