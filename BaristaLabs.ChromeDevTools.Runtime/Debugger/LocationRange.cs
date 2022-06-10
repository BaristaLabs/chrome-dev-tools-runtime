namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Location range within one script.
    /// </summary>
    public sealed class LocationRange
    {
        /// <summary>
        /// scriptId
        ///</summary>
        [JsonProperty("scriptId")]
        public string ScriptId
        {
            get;
            set;
        }
        /// <summary>
        /// start
        ///</summary>
        [JsonProperty("start")]
        public ScriptPosition Start
        {
            get;
            set;
        }
        /// <summary>
        /// end
        ///</summary>
        [JsonProperty("end")]
        public ScriptPosition End
        {
            get;
            set;
        }
    }
}