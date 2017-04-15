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
        /// Enables compositing tree inspection.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command);
        }
    
        /// <summary>
        /// Disables compositing tree inspection.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command);
        }
    
        /// <summary>
        /// Provides the reasons why the given layer was composited.
        /// </summary>
        public async Task<CompositingReasonsCommandResponse> CompositingReasons(CompositingReasonsCommand command)
        {
            return await m_session.SendCommand<CompositingReasonsCommand, CompositingReasonsCommandResponse>(command);
        }
    
        /// <summary>
        /// Returns the layer snapshot identifier.
        /// </summary>
        public async Task<MakeSnapshotCommandResponse> MakeSnapshot(MakeSnapshotCommand command)
        {
            return await m_session.SendCommand<MakeSnapshotCommand, MakeSnapshotCommandResponse>(command);
        }
    
        /// <summary>
        /// Returns the snapshot identifier.
        /// </summary>
        public async Task<LoadSnapshotCommandResponse> LoadSnapshot(LoadSnapshotCommand command)
        {
            return await m_session.SendCommand<LoadSnapshotCommand, LoadSnapshotCommandResponse>(command);
        }
    
        /// <summary>
        /// Releases layer snapshot captured by the back-end.
        /// </summary>
        public async Task<ReleaseSnapshotCommandResponse> ReleaseSnapshot(ReleaseSnapshotCommand command)
        {
            return await m_session.SendCommand<ReleaseSnapshotCommand, ReleaseSnapshotCommandResponse>(command);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<ProfileSnapshotCommandResponse> ProfileSnapshot(ProfileSnapshotCommand command)
        {
            return await m_session.SendCommand<ProfileSnapshotCommand, ProfileSnapshotCommandResponse>(command);
        }
    
        /// <summary>
        /// Replays the layer snapshot and returns the resulting bitmap.
        /// </summary>
        public async Task<ReplaySnapshotCommandResponse> ReplaySnapshot(ReplaySnapshotCommand command)
        {
            return await m_session.SendCommand<ReplaySnapshotCommand, ReplaySnapshotCommandResponse>(command);
        }
    
        /// <summary>
        /// Replays the layer snapshot and returns canvas log.
        /// </summary>
        public async Task<SnapshotCommandLogCommandResponse> SnapshotCommandLog(SnapshotCommandLogCommand command)
        {
            return await m_session.SendCommand<SnapshotCommandLogCommand, SnapshotCommandLogCommandResponse>(command);
        }
    
    }
}