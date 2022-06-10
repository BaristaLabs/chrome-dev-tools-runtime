namespace BaristaLabs.ChromeDevTools.Runtime.HeadlessExperimental
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the HeadlessExperimental domain to simplify the command interface.
    /// </summary>
    public class HeadlessExperimentalAdapter
    {
        private readonly ChromeSession m_session;
        
        public HeadlessExperimentalAdapter(ChromeSession session)
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
        /// Sends a BeginFrame to the target and returns when the frame was completed. Optionally captures a
        /// screenshot from the resulting frame. Requires that the target was created with enabled
        /// BeginFrameControl. Designed for use with --run-all-compositor-stages-before-draw, see also
        /// https://goo.gl/3zHXhB for more background.
        /// </summary>
        public async Task<BeginFrameCommandResponse> BeginFrame(BeginFrameCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<BeginFrameCommand, BeginFrameCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Disables headless events for the target.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command ?? new DisableCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Enables headless events for the target.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command ?? new EnableCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

        /// <summary>
        /// Issued when the target starts or stops needing BeginFrames.
        /// Deprecated. Issue beginFrame unconditionally instead and use result from
        /// beginFrame to detect whether the frames were suppressed.
        /// </summary>
        public void SubscribeToNeedsBeginFramesChangedEvent(Action<NeedsBeginFramesChangedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    }
}