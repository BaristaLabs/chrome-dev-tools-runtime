namespace BaristaLabs.ChromeDevTools.Runtime.DOMDebugger
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the DOMDebugger domain to simplify the command interface.
    /// </summary>
    public class DOMDebuggerAdapter
    {
        private readonly ChromeSession m_session;
        
        public DOMDebuggerAdapter(ChromeSession session)
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
        /// Sets breakpoint on particular operation with DOM.
        /// </summary>
        public async Task<SetDOMBreakpointCommandResponse> SetDOMBreakpoint(SetDOMBreakpointCommand command)
        {
            return await m_session.SendCommand<SetDOMBreakpointCommand, SetDOMBreakpointCommandResponse>(command);
        }
    
        /// <summary>
        /// Removes DOM breakpoint that was set using <code>setDOMBreakpoint</code>.
        /// </summary>
        public async Task<RemoveDOMBreakpointCommandResponse> RemoveDOMBreakpoint(RemoveDOMBreakpointCommand command)
        {
            return await m_session.SendCommand<RemoveDOMBreakpointCommand, RemoveDOMBreakpointCommandResponse>(command);
        }
    
        /// <summary>
        /// Sets breakpoint on particular DOM event.
        /// </summary>
        public async Task<SetEventListenerBreakpointCommandResponse> SetEventListenerBreakpoint(SetEventListenerBreakpointCommand command)
        {
            return await m_session.SendCommand<SetEventListenerBreakpointCommand, SetEventListenerBreakpointCommandResponse>(command);
        }
    
        /// <summary>
        /// Removes breakpoint on particular DOM event.
        /// </summary>
        public async Task<RemoveEventListenerBreakpointCommandResponse> RemoveEventListenerBreakpoint(RemoveEventListenerBreakpointCommand command)
        {
            return await m_session.SendCommand<RemoveEventListenerBreakpointCommand, RemoveEventListenerBreakpointCommandResponse>(command);
        }
    
        /// <summary>
        /// Sets breakpoint on particular native event.
        /// </summary>
        public async Task<SetInstrumentationBreakpointCommandResponse> SetInstrumentationBreakpoint(SetInstrumentationBreakpointCommand command)
        {
            return await m_session.SendCommand<SetInstrumentationBreakpointCommand, SetInstrumentationBreakpointCommandResponse>(command);
        }
    
        /// <summary>
        /// Removes breakpoint on particular native event.
        /// </summary>
        public async Task<RemoveInstrumentationBreakpointCommandResponse> RemoveInstrumentationBreakpoint(RemoveInstrumentationBreakpointCommand command)
        {
            return await m_session.SendCommand<RemoveInstrumentationBreakpointCommand, RemoveInstrumentationBreakpointCommandResponse>(command);
        }
    
        /// <summary>
        /// Sets breakpoint on XMLHttpRequest.
        /// </summary>
        public async Task<SetXHRBreakpointCommandResponse> SetXHRBreakpoint(SetXHRBreakpointCommand command)
        {
            return await m_session.SendCommand<SetXHRBreakpointCommand, SetXHRBreakpointCommandResponse>(command);
        }
    
        /// <summary>
        /// Removes breakpoint from XMLHttpRequest.
        /// </summary>
        public async Task<RemoveXHRBreakpointCommandResponse> RemoveXHRBreakpoint(RemoveXHRBreakpointCommand command)
        {
            return await m_session.SendCommand<RemoveXHRBreakpointCommand, RemoveXHRBreakpointCommandResponse>(command);
        }
    
        /// <summary>
        /// Returns event listeners of the given object.
        /// </summary>
        public async Task<GetEventListenersCommandResponse> GetEventListeners(GetEventListenersCommand command)
        {
            return await m_session.SendCommand<GetEventListenersCommand, GetEventListenersCommandResponse>(command);
        }
    

    
    }
}