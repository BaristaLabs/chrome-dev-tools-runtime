namespace BaristaLabs.ChromeDevTools.Runtime.SystemInfo
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the SystemInfo domain to simplify the command interface.
    /// </summary>
    public class SystemInfoAdapter
    {
        private readonly ChromeSession m_session;
        
        public SystemInfoAdapter(ChromeSession session)
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
        /// Returns information about the system.
        /// </summary>
        public async Task<GetInfoCommandResponse> GetInfo(GetInfoCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetInfoCommand, GetInfoCommandResponse>(command ?? new GetInfoCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

    }
}