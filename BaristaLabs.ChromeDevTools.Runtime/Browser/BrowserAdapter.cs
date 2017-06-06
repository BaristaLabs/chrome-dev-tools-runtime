namespace BaristaLabs.ChromeDevTools.Runtime.Browser
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Browser domain to simplify the command interface.
    /// </summary>
    public class BrowserAdapter
    {
        private readonly ChromeSession m_session;
        
        public BrowserAdapter(ChromeSession session)
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
        /// Get the browser window that contains the devtools target.
        /// </summary>
        public async Task<GetWindowForTargetCommandResponse> GetWindowForTarget(GetWindowForTargetCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetWindowForTargetCommand, GetWindowForTargetCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Set position and/or size of the browser window.
        /// </summary>
        public async Task<SetWindowBoundsCommandResponse> SetWindowBounds(SetWindowBoundsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetWindowBoundsCommand, SetWindowBoundsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Get position and size of the browser window.
        /// </summary>
        public async Task<GetWindowBoundsCommandResponse> GetWindowBounds(GetWindowBoundsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetWindowBoundsCommand, GetWindowBoundsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    

    
    }
}