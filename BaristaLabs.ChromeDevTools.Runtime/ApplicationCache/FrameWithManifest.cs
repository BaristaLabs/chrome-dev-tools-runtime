namespace BaristaLabs.ChromeDevTools.Runtime.ApplicationCache
{
    using Newtonsoft.Json;

    /// <summary>
    /// Frame identifier - manifest URL pair.
    /// </summary>
    public sealed class FrameWithManifest
    {
    
        /// <summary>
        /// Frame identifier.
        ///</summary>
        [JsonProperty("frameId")]
        public string FrameId
        {
            get;
            set;
        }
    
        /// <summary>
        /// Manifest URL.
        ///</summary>
        [JsonProperty("manifestURL")]
        public string ManifestURL
        {
            get;
            set;
        }
    
        /// <summary>
        /// Application cache status.
        ///</summary>
        [JsonProperty("status")]
        public long Status
        {
            get;
            set;
        }
    
    }
}