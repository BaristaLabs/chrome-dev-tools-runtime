namespace BaristaLabs.ChromeDevTools.Runtime.DOMDebugger
{
    using System;
    using System.Threading;
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
        public async Task<SetDOMBreakpointCommandResponse> SetDOMBreakpoint(SetDOMBreakpointCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetDOMBreakpointCommand, SetDOMBreakpointCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Removes DOM breakpoint that was set using &lt;code&gt;setDOMBreakpoint&lt;/code&gt;.
        /// </summary>
        public async Task<RemoveDOMBreakpointCommandResponse> RemoveDOMBreakpoint(RemoveDOMBreakpointCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<RemoveDOMBreakpointCommand, RemoveDOMBreakpointCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Sets breakpoint on particular DOM event.
        /// </summary>
        public async Task<SetEventListenerBreakpointCommandResponse> SetEventListenerBreakpoint(SetEventListenerBreakpointCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetEventListenerBreakpointCommand, SetEventListenerBreakpointCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Removes breakpoint on particular DOM event.
        /// </summary>
        public async Task<RemoveEventListenerBreakpointCommandResponse> RemoveEventListenerBreakpoint(RemoveEventListenerBreakpointCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<RemoveEventListenerBreakpointCommand, RemoveEventListenerBreakpointCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Sets breakpoint on particular native event.
        /// </summary>
        public async Task<SetInstrumentationBreakpointCommandResponse> SetInstrumentationBreakpoint(SetInstrumentationBreakpointCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetInstrumentationBreakpointCommand, SetInstrumentationBreakpointCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Removes breakpoint on particular native event.
        /// </summary>
        public async Task<RemoveInstrumentationBreakpointCommandResponse> RemoveInstrumentationBreakpoint(RemoveInstrumentationBreakpointCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<RemoveInstrumentationBreakpointCommand, RemoveInstrumentationBreakpointCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Sets breakpoint on XMLHttpRequest.
        /// </summary>
        public async Task<SetXHRBreakpointCommandResponse> SetXHRBreakpoint(SetXHRBreakpointCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetXHRBreakpointCommand, SetXHRBreakpointCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Removes breakpoint from XMLHttpRequest.
        /// </summary>
        public async Task<RemoveXHRBreakpointCommandResponse> RemoveXHRBreakpoint(RemoveXHRBreakpointCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<RemoveXHRBreakpointCommand, RemoveXHRBreakpointCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns event listeners of the given object.
        /// </summary>
        public async Task<GetEventListenersCommandResponse> GetEventListeners(GetEventListenersCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetEventListenersCommand, GetEventListenersCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

    }
}