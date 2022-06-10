namespace BaristaLabs.ChromeDevTools.Runtime.Tracing
{
    using Newtonsoft.Json;

    /// <summary>
    /// Signals that tracing is stopped and there is no trace buffers pending flush, all data were
    /// delivered via dataCollected events.
    /// </summary>
    public sealed class TracingCompleteEvent : IEvent
    {
        /// <summary>
        /// Indicates whether some trace data is known to have been lost, e.g. because the trace ring
        /// buffer wrapped around.
        /// </summary>
        [JsonProperty("dataLossOccurred")]
        public bool DataLossOccurred
        {
            get;
            set;
        }
        /// <summary>
        /// A handle of the stream that holds resulting trace data.
        /// </summary>
        [JsonProperty("stream", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Stream
        {
            get;
            set;
        }
        /// <summary>
        /// Trace data format of returned stream.
        /// </summary>
        [JsonProperty("traceFormat", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public StreamFormat? TraceFormat
        {
            get;
            set;
        }
        /// <summary>
        /// Compression format of returned stream.
        /// </summary>
        [JsonProperty("streamCompression", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public StreamCompression? StreamCompression
        {
            get;
            set;
        }
    }
}