namespace BaristaLabs.ChromeDevTools.Runtime.Log
{
    /// <summary>
    /// Log entry.
    /// </summary>
    public sealed class LogEntry
    {
    
        /// <summary>
        /// Log entry source.
        ///</summary>
        public string Source
        {
            get;
            set;
        }
    
        /// <summary>
        /// Log entry severity.
        ///</summary>
        public string Level
        {
            get;
            set;
        }
    
        /// <summary>
        /// Logged text.
        ///</summary>
        public string Text
        {
            get;
            set;
        }
    
        /// <summary>
        /// Timestamp when this entry was added.
        ///</summary>
        public double Timestamp
        {
            get;
            set;
        }
    
        /// <summary>
        /// URL of the resource if known.
        ///</summary>
        public string Url
        {
            get;
            set;
        }
    
        /// <summary>
        /// Line number in the resource.
        ///</summary>
        public long? LineNumber
        {
            get;
            set;
        }
    
        /// <summary>
        /// JavaScript stack trace.
        ///</summary>
        public BaristaLabs.ChromeDevTools.Runtime.Runtime.StackTrace StackTrace
        {
            get;
            set;
        }
    
        /// <summary>
        /// Identifier of the network request associated with this entry.
        ///</summary>
        public string NetworkRequestId
        {
            get;
            set;
        }
    
        /// <summary>
        /// Identifier of the worker associated with this entry.
        ///</summary>
        public string WorkerId
        {
            get;
            set;
        }
    
    }
}