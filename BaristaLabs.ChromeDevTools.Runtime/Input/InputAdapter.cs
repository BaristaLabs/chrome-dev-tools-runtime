namespace BaristaLabs.ChromeDevTools.Runtime.Input
{
    using System;
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
        /// Dispatches a key event to the page.
        /// </summary>
        public async Task<DispatchKeyEventCommandResponse> DispatchKeyEvent(DispatchKeyEventCommand command)
        {
            return await m_session.SendCommand<DispatchKeyEventCommand, DispatchKeyEventCommandResponse>(command);
        }
    
        /// <summary>
        /// Dispatches a mouse event to the page.
        /// </summary>
        public async Task<DispatchMouseEventCommandResponse> DispatchMouseEvent(DispatchMouseEventCommand command)
        {
            return await m_session.SendCommand<DispatchMouseEventCommand, DispatchMouseEventCommandResponse>(command);
        }
    
        /// <summary>
        /// Dispatches a touch event to the page.
        /// </summary>
        public async Task<DispatchTouchEventCommandResponse> DispatchTouchEvent(DispatchTouchEventCommand command)
        {
            return await m_session.SendCommand<DispatchTouchEventCommand, DispatchTouchEventCommandResponse>(command);
        }
    
        /// <summary>
        /// Emulates touch event from the mouse event parameters.
        /// </summary>
        public async Task<EmulateTouchFromMouseEventCommandResponse> EmulateTouchFromMouseEvent(EmulateTouchFromMouseEventCommand command)
        {
            return await m_session.SendCommand<EmulateTouchFromMouseEventCommand, EmulateTouchFromMouseEventCommandResponse>(command);
        }
    
        /// <summary>
        /// Synthesizes a pinch gesture over a time period by issuing appropriate touch events.
        /// </summary>
        public async Task<SynthesizePinchGestureCommandResponse> SynthesizePinchGesture(SynthesizePinchGestureCommand command)
        {
            return await m_session.SendCommand<SynthesizePinchGestureCommand, SynthesizePinchGestureCommandResponse>(command);
        }
    
        /// <summary>
        /// Synthesizes a scroll gesture over a time period by issuing appropriate touch events.
        /// </summary>
        public async Task<SynthesizeScrollGestureCommandResponse> SynthesizeScrollGesture(SynthesizeScrollGestureCommand command)
        {
            return await m_session.SendCommand<SynthesizeScrollGestureCommand, SynthesizeScrollGestureCommandResponse>(command);
        }
    
        /// <summary>
        /// Synthesizes a tap gesture over a time period by issuing appropriate touch events.
        /// </summary>
        public async Task<SynthesizeTapGestureCommandResponse> SynthesizeTapGesture(SynthesizeTapGestureCommand command)
        {
            return await m_session.SendCommand<SynthesizeTapGestureCommand, SynthesizeTapGestureCommandResponse>(command);
        }
    
    }
}