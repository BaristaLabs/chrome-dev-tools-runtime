namespace BaristaLabs.ChromeDevTools.Runtime.HeapProfiler
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the HeapProfiler domain to simplify the command interface.
    /// </summary>
    public class HeapProfilerAdapter
    {
        private readonly ChromeSession m_session;
        
        public HeapProfilerAdapter(ChromeSession session)
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
        /// 
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<StartTrackingHeapObjectsCommandResponse> StartTrackingHeapObjects(StartTrackingHeapObjectsCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<StartTrackingHeapObjectsCommand, StartTrackingHeapObjectsCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<StopTrackingHeapObjectsCommandResponse> StopTrackingHeapObjects(StopTrackingHeapObjectsCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<StopTrackingHeapObjectsCommand, StopTrackingHeapObjectsCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<TakeHeapSnapshotCommandResponse> TakeHeapSnapshot(TakeHeapSnapshotCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<TakeHeapSnapshotCommand, TakeHeapSnapshotCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<CollectGarbageCommandResponse> CollectGarbage(CollectGarbageCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<CollectGarbageCommand, CollectGarbageCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<GetObjectByHeapObjectIdCommandResponse> GetObjectByHeapObjectId(GetObjectByHeapObjectIdCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetObjectByHeapObjectIdCommand, GetObjectByHeapObjectIdCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Enables console to refer to the node with given id via $x (see Command Line API for more details $x functions).
        /// </summary>
        public async Task<AddInspectedHeapObjectCommandResponse> AddInspectedHeapObject(AddInspectedHeapObjectCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<AddInspectedHeapObjectCommand, AddInspectedHeapObjectCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<GetHeapObjectIdCommandResponse> GetHeapObjectId(GetHeapObjectIdCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetHeapObjectIdCommand, GetHeapObjectIdCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<StartSamplingCommandResponse> StartSampling(StartSamplingCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<StartSamplingCommand, StartSamplingCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<StopSamplingCommandResponse> StopSampling(StopSamplingCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<StopSamplingCommand, StopSamplingCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    

    
        /// <summary>
        /// 
        /// </summary>
        public void SubscribeToAddHeapSnapshotChunkEvent(Action<AddHeapSnapshotChunkEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public void SubscribeToResetProfilesEvent(Action<ResetProfilesEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public void SubscribeToReportHeapSnapshotProgressEvent(Action<ReportHeapSnapshotProgressEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// If heap objects tracking has been started then backend regulary sends a current value for last seen object id and corresponding timestamp. If the were changes in the heap since last event then one or more heapStatsUpdate events will be sent before a new lastSeenObjectId event.
        /// </summary>
        public void SubscribeToLastSeenObjectIdEvent(Action<LastSeenObjectIdEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// If heap objects tracking has been started then backend may send update for one or more fragments
        /// </summary>
        public void SubscribeToHeapStatsUpdateEvent(Action<HeapStatsUpdateEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
    }
}