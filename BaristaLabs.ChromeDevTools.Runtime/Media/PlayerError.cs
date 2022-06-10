namespace BaristaLabs.ChromeDevTools.Runtime.Media
{
    using Newtonsoft.Json;

    /// <summary>
    /// Corresponds to kMediaError
    /// </summary>
    public sealed class PlayerError
    {
        /// <summary>
        /// errorType
        ///</summary>
        [JsonProperty("errorType")]
        public string ErrorType
        {
            get;
            set;
        }
        /// <summary>
        /// Code is the numeric enum entry for a specific set of error codes, such
        /// as PipelineStatusCodes in media/base/pipeline_status.h
        ///</summary>
        [JsonProperty("code")]
        public long Code
        {
            get;
            set;
        }
        /// <summary>
        /// A trace of where this error was caused / where it passed through.
        ///</summary>
        [JsonProperty("stack")]
        public PlayerErrorSourceLocation[] Stack
        {
            get;
            set;
        }
        /// <summary>
        /// Errors potentially have a root cause error, ie, a DecoderError might be
        /// caused by an WindowsError
        ///</summary>
        [JsonProperty("cause")]
        public PlayerError[] Cause
        {
            get;
            set;
        }
        /// <summary>
        /// Extra data attached to an error, such as an HRESULT, Video Codec, etc.
        ///</summary>
        [JsonProperty("data")]
        public object Data
        {
            get;
            set;
        }
    }
}