namespace BaristaLabs.ChromeDevTools.Runtime.Tracing
{
    using System;
    using System.Threading;
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
        public async Task<StartCommandResponse> Start(StartCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<StartCommand, StartCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Stop trace events collection.
        /// </summary>
        public async Task<EndCommandResponse> End(EndCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EndCommand, EndCommandResponse>(command ?? new EndCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Gets supported tracing categories.
        /// </summary>
        public async Task<GetCategoriesCommandResponse> GetCategories(GetCategoriesCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetCategoriesCommand, GetCategoriesCommandResponse>(command ?? new GetCategoriesCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Request a global memory dump.
        /// </summary>
        public async Task<RequestMemoryDumpCommandResponse> RequestMemoryDump(RequestMemoryDumpCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<RequestMemoryDumpCommand, RequestMemoryDumpCommandResponse>(command ?? new RequestMemoryDumpCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Record a clock sync marker in the trace.
        /// </summary>
        public async Task<RecordClockSyncMarkerCommandResponse> RecordClockSyncMarker(RecordClockSyncMarkerCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<RecordClockSyncMarkerCommand, RecordClockSyncMarkerCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
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