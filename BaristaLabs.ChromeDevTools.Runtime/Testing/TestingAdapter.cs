namespace BaristaLabs.ChromeDevTools.Runtime.Testing
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Testing domain to simplify the command interface.
    /// </summary>
    public class TestingAdapter
    {
        private readonly ChromeSession m_session;
        
        public TestingAdapter(ChromeSession session)
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
        /// Generates a report for testing.
        /// </summary>
        public async Task<GenerateTestReportCommandResponse> GenerateTestReport(GenerateTestReportCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GenerateTestReportCommand, GenerateTestReportCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

    }
}