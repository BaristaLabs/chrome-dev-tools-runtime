namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Location in the source code.
    /// </summary>
    public sealed class ScriptPosition
    {
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("lineNumber")]
        public long LineNumber
        {
            get;
            set;
        }
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("columnNumber")]
        public long ColumnNumber
        {
            get;
            set;
        }
    }
}