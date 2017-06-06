namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class BreakLocation
    {
    
        /// <summary>
        /// Script identifier as reported in the <code>Debugger.scriptParsed</code>.
        ///</summary>
        [JsonProperty("scriptId")]
        public string ScriptId
        {
            get;
            set;
        }
    
        /// <summary>
        /// Line number in the script (0-based).
        ///</summary>
        [JsonProperty("lineNumber")]
        public long LineNumber
        {
            get;
            set;
        }
    
        /// <summary>
        /// Column number in the script (0-based).
        ///</summary>
        [JsonProperty("columnNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? ColumnNumber
        {
            get;
            set;
        }
    
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type
        {
            get;
            set;
        }
    
    }
}