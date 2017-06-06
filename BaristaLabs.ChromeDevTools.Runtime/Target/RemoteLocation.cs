namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class RemoteLocation
    {
    
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("host")]
        public string Host
        {
            get;
            set;
        }
    
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("port")]
        public long Port
        {
            get;
            set;
        }
    
    }
}