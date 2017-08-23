namespace BaristaLabs.ChromeDevTools.Runtime.Schema
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Schema domain to simplify the command interface.
    /// </summary>
    public class SchemaAdapter
    {
        private readonly ChromeSession m_session;
        
        public SchemaAdapter(ChromeSession session)
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
        /// Returns supported domains.
        /// </summary>
        public async Task<GetDomainsCommandResponse> GetDomains(GetDomainsCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetDomainsCommand, GetDomainsCommandResponse>(command ?? new GetDomainsCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

    }
}