namespace BaristaLabs.ChromeDevTools.Runtime.Security
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Security domain to simplify the command interface.
    /// </summary>
    public class SecurityAdapter
    {
        private readonly ChromeSession m_session;
        
        public SecurityAdapter(ChromeSession session)
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
        /// Enables tracking security state changes.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Disables tracking security state changes.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Displays native dialog with the certificate details.
        /// </summary>
        public async Task<ShowCertificateViewerCommandResponse> ShowCertificateViewer(ShowCertificateViewerCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ShowCertificateViewerCommand, ShowCertificateViewerCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

        /// <summary>
        /// The security state of the page changed.
        /// </summary>
        public void SubscribeToSecurityStateChangedEvent(Action<SecurityStateChangedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    }
}