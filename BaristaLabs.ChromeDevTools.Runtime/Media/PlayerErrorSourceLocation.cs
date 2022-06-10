namespace BaristaLabs.ChromeDevTools.Runtime.Media
{
    using Newtonsoft.Json;

    /// <summary>
    /// Represents logged source line numbers reported in an error.
    /// NOTE: file and line are from chromium c++ implementation code, not js.
    /// </summary>
    public sealed class PlayerErrorSourceLocation
    {
        /// <summary>
        /// file
        ///</summary>
        [JsonProperty("file")]
        public string File
        {
            get;
            set;
        }
        /// <summary>
        /// line
        ///</summary>
        [JsonProperty("line")]
        public long Line
        {
            get;
            set;
        }
    }
}