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
        /// Returns the response body and size if it were re-encoded with the specified settings. Only applies to images.
        /// </summary>
        public async Task<GetEncodedResponseCommandResponse> GetEncodedResponse(GetEncodedResponseCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetEncodedResponseCommand, GetEncodedResponseCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

    }
}