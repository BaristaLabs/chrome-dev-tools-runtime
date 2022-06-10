namespace BaristaLabs.ChromeDevTools.Runtime.EventBreakpoints
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the EventBreakpoints domain to simplify the command interface.
    /// </summary>
    public class EventBreakpointsAdapter
    {
        private readonly ChromeSession m_session;
        
        public EventBreakpointsAdapter(ChromeSession session)
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

    }
}