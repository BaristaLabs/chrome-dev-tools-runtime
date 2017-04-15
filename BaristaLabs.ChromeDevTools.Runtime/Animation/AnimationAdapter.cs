namespace BaristaLabs.ChromeDevTools.Runtime.Animation
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Animation domain to simplify the command interface.
    /// </summary>
    public class AnimationAdapter
    {
        private readonly ChromeSession m_session;
        
        public AnimationAdapter(ChromeSession session)
        {
            m_session = session ?? throw new ArgumentNullException(nameof(session));
        }

    
        /// <summary>
        /// Enables animation domain notifications.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command);
        }
    
        /// <summary>
        /// Disables animation domain notifications.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command);
        }
    
        /// <summary>
        /// Gets the playback rate of the document timeline.
        /// </summary>
        public async Task<GetPlaybackRateCommandResponse> GetPlaybackRate(GetPlaybackRateCommand command)
        {
            return await m_session.SendCommand<GetPlaybackRateCommand, GetPlaybackRateCommandResponse>(command);
        }
    
        /// <summary>
        /// Sets the playback rate of the document timeline.
        /// </summary>
        public async Task<SetPlaybackRateCommandResponse> SetPlaybackRate(SetPlaybackRateCommand command)
        {
            return await m_session.SendCommand<SetPlaybackRateCommand, SetPlaybackRateCommandResponse>(command);
        }
    
        /// <summary>
        /// Returns the current time of the an animation.
        /// </summary>
        public async Task<GetCurrentTimeCommandResponse> GetCurrentTime(GetCurrentTimeCommand command)
        {
            return await m_session.SendCommand<GetCurrentTimeCommand, GetCurrentTimeCommandResponse>(command);
        }
    
        /// <summary>
        /// Sets the paused state of a set of animations.
        /// </summary>
        public async Task<SetPausedCommandResponse> SetPaused(SetPausedCommand command)
        {
            return await m_session.SendCommand<SetPausedCommand, SetPausedCommandResponse>(command);
        }
    
        /// <summary>
        /// Sets the timing of an animation node.
        /// </summary>
        public async Task<SetTimingCommandResponse> SetTiming(SetTimingCommand command)
        {
            return await m_session.SendCommand<SetTimingCommand, SetTimingCommandResponse>(command);
        }
    
        /// <summary>
        /// Seek a set of animations to a particular time within each animation.
        /// </summary>
        public async Task<SeekAnimationsCommandResponse> SeekAnimations(SeekAnimationsCommand command)
        {
            return await m_session.SendCommand<SeekAnimationsCommand, SeekAnimationsCommandResponse>(command);
        }
    
        /// <summary>
        /// Releases a set of animations to no longer be manipulated.
        /// </summary>
        public async Task<ReleaseAnimationsCommandResponse> ReleaseAnimations(ReleaseAnimationsCommand command)
        {
            return await m_session.SendCommand<ReleaseAnimationsCommand, ReleaseAnimationsCommandResponse>(command);
        }
    
        /// <summary>
        /// Gets the remote object of the Animation.
        /// </summary>
        public async Task<ResolveAnimationCommandResponse> ResolveAnimation(ResolveAnimationCommand command)
        {
            return await m_session.SendCommand<ResolveAnimationCommand, ResolveAnimationCommandResponse>(command);
        }
    
    }
}