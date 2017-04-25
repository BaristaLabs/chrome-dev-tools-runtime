namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Accessibility domain to simplify the command interface.
    /// </summary>
    public class AccessibilityAdapter
    {
        private readonly ChromeSession m_session;
        
        public AccessibilityAdapter(ChromeSession session)
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
        /// Fetches the accessibility node and partial accessibility tree for this DOM node, if it exists.
        /// </summary>
        public async Task<GetPartialAXTreeCommandResponse> GetPartialAXTree(GetPartialAXTreeCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetPartialAXTreeCommand, GetPartialAXTreeCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

    }
}