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
        /// Grant specific permissions to the given origin and reject all others.
        /// </summary>
        public async Task<GrantPermissionsCommandResponse> GrantPermissions(GrantPermissionsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GrantPermissionsCommand, GrantPermissionsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Reset all permission management for all origins.
        /// </summary>
        public async Task<ResetPermissionsCommandResponse> ResetPermissions(ResetPermissionsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ResetPermissionsCommand, ResetPermissionsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Close browser gracefully.
        /// </summary>
        public async Task<CloseCommandResponse> Close(CloseCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<CloseCommand, CloseCommandResponse>(command ?? new CloseCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns version information.
        /// </summary>
        public async Task<GetVersionCommandResponse> GetVersion(GetVersionCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetVersionCommand, GetVersionCommandResponse>(command ?? new GetVersionCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns the command line switches for the browser process if, and only if
        /// --enable-automation is on the commandline.
        /// </summary>
        public async Task<GetBrowserCommandLineCommandResponse> GetBrowserCommandLine(GetBrowserCommandLineCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetBrowserCommandLineCommand, GetBrowserCommandLineCommandResponse>(command ?? new GetBrowserCommandLineCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Get Chrome histograms.
        /// </summary>
        public async Task<GetHistogramsCommandResponse> GetHistograms(GetHistogramsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetHistogramsCommand, GetHistogramsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Get a Chrome histogram by name.
        /// </summary>
        public async Task<GetHistogramCommandResponse> GetHistogram(GetHistogramCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetHistogramCommand, GetHistogramCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Get position and size of the browser window.
        /// </summary>
        public async Task<GetWindowBoundsCommandResponse> GetWindowBounds(GetWindowBoundsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetWindowBoundsCommand, GetWindowBoundsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
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

    }
}