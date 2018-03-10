namespace BaristaLabs.ChromeDevTools.Runtime.DOMSnapshot
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the DOMSnapshot domain to simplify the command interface.
    /// </summary>
    public class DOMSnapshotAdapter
    {
        private readonly ChromeSession m_session;
        
        public DOMSnapshotAdapter(ChromeSession session)
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
        /// Returns a document snapshot, including the full DOM tree of the root node (including iframes,
        /// template contents, and imported documents) in a flattened array, as well as layout and
        /// white-listed computed style information for the nodes. Shadow DOM in the returned DOM tree is
        /// flattened.
        /// </summary>
        public async Task<GetSnapshotCommandResponse> GetSnapshot(GetSnapshotCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetSnapshotCommand, GetSnapshotCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

    }
}