namespace BaristaLabs.ChromeDevTools.Runtime.LayerTree
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the LayerTree domain to simplify the command interface.
    /// </summary>
    public class LayerTreeAdapter
    {
        private readonly ChromeSession m_session;
        
        public LayerTreeAdapter(ChromeSession session)
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
        /// Enables compositing tree inspection.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Disables compositing tree inspection.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Provides the reasons why the given layer was composited.
        /// </summary>
        public async Task<CompositingReasonsCommandResponse> CompositingReasons(CompositingReasonsCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<CompositingReasonsCommand, CompositingReasonsCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Returns the layer snapshot identifier.
        /// </summary>
        public async Task<MakeSnapshotCommandResponse> MakeSnapshot(MakeSnapshotCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<MakeSnapshotCommand, MakeSnapshotCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Returns the snapshot identifier.
        /// </summary>
        public async Task<LoadSnapshotCommandResponse> LoadSnapshot(LoadSnapshotCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<LoadSnapshotCommand, LoadSnapshotCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Releases layer snapshot captured by the back-end.
        /// </summary>
        public async Task<ReleaseSnapshotCommandResponse> ReleaseSnapshot(ReleaseSnapshotCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ReleaseSnapshotCommand, ReleaseSnapshotCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<ProfileSnapshotCommandResponse> ProfileSnapshot(ProfileSnapshotCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ProfileSnapshotCommand, ProfileSnapshotCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Replays the layer snapshot and returns the resulting bitmap.
        /// </summary>
        public async Task<ReplaySnapshotCommandResponse> ReplaySnapshot(ReplaySnapshotCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ReplaySnapshotCommand, ReplaySnapshotCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Replays the layer snapshot and returns canvas log.
        /// </summary>
        public async Task<SnapshotCommandLogCommandResponse> SnapshotCommandLog(SnapshotCommandLogCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SnapshotCommandLogCommand, SnapshotCommandLogCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    

    
        /// <summary>
        /// 
        /// </summary>
        public void SubscribeToLayerTreeDidChangeEvent(Action<LayerTreeDidChangeEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public void SubscribeToLayerPaintedEvent(Action<LayerPaintedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
    }
}