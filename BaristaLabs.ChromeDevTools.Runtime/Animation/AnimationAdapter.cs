namespace BaristaLabs.ChromeDevTools.Runtime.Animation
{
    using System;
    using System.Threading;
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
        /// Gets the ChromeSession associated with the adapter.
        /// </summary>
        public ChromeSession Session
        {
            get { return m_session; }
        }

        /// <summary>
        /// Enables animation domain notifications.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command ?? new EnableCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Disables animation domain notifications.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command ?? new DisableCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Gets the playback rate of the document timeline.
        /// </summary>
        public async Task<GetPlaybackRateCommandResponse> GetPlaybackRate(GetPlaybackRateCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetPlaybackRateCommand, GetPlaybackRateCommandResponse>(command ?? new GetPlaybackRateCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Sets the playback rate of the document timeline.
        /// </summary>
        public async Task<SetPlaybackRateCommandResponse> SetPlaybackRate(SetPlaybackRateCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetPlaybackRateCommand, SetPlaybackRateCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns the current time of the an animation.
        /// </summary>
        public async Task<GetCurrentTimeCommandResponse> GetCurrentTime(GetCurrentTimeCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetCurrentTimeCommand, GetCurrentTimeCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Sets the paused state of a set of animations.
        /// </summary>
        public async Task<SetPausedCommandResponse> SetPaused(SetPausedCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetPausedCommand, SetPausedCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Sets the timing of an animation node.
        /// </summary>
        public async Task<SetTimingCommandResponse> SetTiming(SetTimingCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetTimingCommand, SetTimingCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Seek a set of animations to a particular time within each animation.
        /// </summary>
        public async Task<SeekAnimationsCommandResponse> SeekAnimations(SeekAnimationsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SeekAnimationsCommand, SeekAnimationsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Releases a set of animations to no longer be manipulated.
        /// </summary>
        public async Task<ReleaseAnimationsCommandResponse> ReleaseAnimations(ReleaseAnimationsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ReleaseAnimationsCommand, ReleaseAnimationsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Gets the remote object of the Animation.
        /// </summary>
        public async Task<ResolveAnimationCommandResponse> ResolveAnimation(ResolveAnimationCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ResolveAnimationCommand, ResolveAnimationCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

        /// <summary>
        /// Event for each animation that has been created.
        /// </summary>
        public void SubscribeToAnimationCreatedEvent(Action<AnimationCreatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Event for animation that has been started.
        /// </summary>
        public void SubscribeToAnimationStartedEvent(Action<AnimationStartedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Event for when an animation has been cancelled.
        /// </summary>
        public void SubscribeToAnimationCanceledEvent(Action<AnimationCanceledEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    }
}