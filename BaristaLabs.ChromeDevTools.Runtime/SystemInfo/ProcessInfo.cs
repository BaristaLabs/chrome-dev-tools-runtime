namespace BaristaLabs.ChromeDevTools.Runtime.SystemInfo
{
    using Newtonsoft.Json;

    /// <summary>
    /// Represents process info.
    /// </summary>
    public sealed class ProcessInfo
    {
        /// <summary>
        /// Specifies process type.
        ///</summary>
        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }
        /// <summary>
        /// Specifies process id.
        ///</summary>
        [JsonProperty("id")]
        public long Id
        {
            get;
            set;
        }
        /// <summary>
        /// Specifies cumulative CPU usage in seconds across all threads of the
        /// process since the process start.
        ///</summary>
        [JsonProperty("cpuTime")]
        public double CpuTime
        {
            get;
            set;
        }
    }
}