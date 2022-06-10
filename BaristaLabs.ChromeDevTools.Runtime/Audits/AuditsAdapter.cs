namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Audits domain to simplify the command interface.
    /// </summary>
    public class AuditsAdapter
    {
        private readonly ChromeSession m_session;
        
        public AuditsAdapter(ChromeSession session)
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
        /// Returns the response body and size if it were re-encoded with the specified settings. Only
        /// applies to images.
        /// </summary>
        public async Task<GetEncodedResponseCommandResponse> GetEncodedResponse(GetEncodedResponseCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetEncodedResponseCommand, GetEncodedResponseCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Disables issues domain, prevents further issues from being reported to the client.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command ?? new DisableCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Enables issues domain, sends the issues collected so far to the client by means of the
        /// `issueAdded` event.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command ?? new EnableCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Runs the contrast check for the target page. Found issues are reported
        /// using Audits.issueAdded event.
        /// </summary>
        public async Task<CheckContrastCommandResponse> CheckContrast(CheckContrastCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<CheckContrastCommand, CheckContrastCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

        /// <summary>
        /// issueAdded
        /// </summary>
        public void SubscribeToIssueAddedEvent(Action<IssueAddedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    }
}