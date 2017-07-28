namespace BaristaLabs.ChromeDevTools.Runtime.Input
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Input domain to simplify the command interface.
    /// </summary>
    public class InputAdapter
    {
        private readonly ChromeSession m_session;
        
        public InputAdapter(ChromeSession session)
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
        /// Ignores input events (useful while auditing page).
        /// </summary>
        public async Task<SetIgnoreInputEventsCommandResponse> SetIgnoreInputEvents(SetIgnoreInputEventsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetIgnoreInputEventsCommand, SetIgnoreInputEventsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Dispatches a key event to the page.
        /// </summary>
        public async Task<DispatchKeyEventCommandResponse> DispatchKeyEvent(DispatchKeyEventCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DispatchKeyEventCommand, DispatchKeyEventCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Dispatches a mouse event to the page.
        /// </summary>
        public async Task<DispatchMouseEventCommandResponse> DispatchMouseEvent(DispatchMouseEventCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DispatchMouseEventCommand, DispatchMouseEventCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Dispatches a touch event to the page.
        /// </summary>
        public async Task<DispatchTouchEventCommandResponse> DispatchTouchEvent(DispatchTouchEventCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DispatchTouchEventCommand, DispatchTouchEventCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Emulates touch event from the mouse event parameters.
        /// </summary>
        public async Task<EmulateTouchFromMouseEventCommandResponse> EmulateTouchFromMouseEvent(EmulateTouchFromMouseEventCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EmulateTouchFromMouseEventCommand, EmulateTouchFromMouseEventCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Synthesizes a pinch gesture over a time period by issuing appropriate touch events.
        /// </summary>
        public async Task<SynthesizePinchGestureCommandResponse> SynthesizePinchGesture(SynthesizePinchGestureCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SynthesizePinchGestureCommand, SynthesizePinchGestureCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Synthesizes a scroll gesture over a time period by issuing appropriate touch events.
        /// </summary>
        public async Task<SynthesizeScrollGestureCommandResponse> SynthesizeScrollGesture(SynthesizeScrollGestureCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SynthesizeScrollGestureCommand, SynthesizeScrollGestureCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Synthesizes a tap gesture over a time period by issuing appropriate touch events.
        /// </summary>
        public async Task<SynthesizeTapGestureCommandResponse> SynthesizeTapGesture(SynthesizeTapGestureCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SynthesizeTapGestureCommand, SynthesizeTapGestureCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

    }
}