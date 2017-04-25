namespace BaristaLabs.ChromeDevTools.Runtime.Database
{
    using Newtonsoft.Json;

    /// <summary>
    /// Database error.
    /// </summary>
    public sealed class Error
    {
        /// <summary>
        /// Error message.
        ///</summary>
        [JsonProperty("message")]
        public string Message
        {
            get;
            set;
        }
        /// <summary>
        /// Error code.
        ///</summary>
        [JsonProperty("code")]
        public long Code
        {
            get;
            set;
        }
    }
}