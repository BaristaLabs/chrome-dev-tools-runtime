namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// Information about the frame affected by an inspector issue.
    /// </summary>
    public sealed class AffectedFrame
    {
        /// <summary>
        /// frameId
        ///</summary>
        [JsonProperty("frameId")]
        public string FrameId
        {
            get;
            set;
        }
    }
}