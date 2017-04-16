namespace BaristaLabs.ChromeDevTools.Runtime.Tracing
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Tracing domain to simplify the command interface.
    /// </summary>
    public class TracingAdapter
    {
        private readonly ChromeSession m_session;
        
        public TracingAdapter(ChromeSession session)
        {
            m_session = session ?? throw new ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Gets the ChromeSession associated with the adapter.
        /// </summary>
        public ChromeSession Session
        {
            get { return m_session; }
        }

    
        /// <summary>
        /// Start trace events collection.
        /// </summary>
        public async Task<StartCommandResponse> Start(StartCommand command)
        {
            return await m_session.SendCommand<StartCommand, StartCommandResponse>(command);
        }
    
        /// <summary>
        /// Stop trace events collection.
        /// </summary>
        public async Task<EndCommandResponse> End(EndCommand command)
        {
            return await m_session.SendCommand<EndCommand, EndCommandResponse>(command);
        }
    
        /// <summary>
        /// Gets supported tracing categories.
        /// </summary>
        public async Task<GetCategoriesCommandResponse> GetCategories(GetCategoriesCommand command)
        {
            return await m_session.SendCommand<GetCategoriesCommand, GetCategoriesCommandResponse>(command);
        }
    
        /// <summary>
        /// Request a global memory dump.
        /// </summary>
        public async Task<RequestMemoryDumpCommandResponse> RequestMemoryDump(RequestMemoryDumpCommand command)
        {
            return await m_session.SendCommand<RequestMemoryDumpCommand, RequestMemoryDumpCommandResponse>(command);
        }
    
        /// <summary>
        /// Record a clock sync marker in the trace.
        /// </summary>
        public async Task<RecordClockSyncMarkerCommandResponse> RecordClockSyncMarker(RecordClockSyncMarkerCommand command)
        {
            return await m_session.SendCommand<RecordClockSyncMarkerCommand, RecordClockSyncMarkerCommandResponse>(command);
        }
    

    
        /// <summary>
        /// Contains an bucket of collected trace events. When tracing is stopped collected events will be send as a sequence of dataCollected events followed by tracingComplete event.
        /// </summary>
        public void SubscribeToDataCollectedEvent(Action<DataCollectedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Signals that tracing is stopped and there is no trace buffers pending flush, all data were delivered via dataCollected events.
        /// </summary>
        public void SubscribeToTracingCompleteEvent(Action<TracingCompleteEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public void SubscribeToBufferUsageEvent(Action<BufferUsageEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
    }
}