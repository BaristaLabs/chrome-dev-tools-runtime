namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// The installability error
    /// </summary>
    public sealed class InstallabilityError
    {
        /// <summary>
        /// The error id (e.g. 'manifest-missing-suitable-icon').
        ///</summary>
        [JsonProperty("errorId")]
        public string ErrorId
        {
            get;
            set;
        }
        /// <summary>
        /// The list of error arguments (e.g. {name:'minimum-icon-size-in-pixels', value:'64'}).
        ///</summary>
        [JsonProperty("errorArguments")]
        public InstallabilityErrorArgument[] ErrorArguments
        {
            get;
            set;
        }
    }
}