namespace BaristaLabs.ChromeDevTools.Runtime.IO
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the IO domain to simplify the command interface.
    /// </summary>
    public class IOAdapter
    {
        private readonly ChromeSession m_session;
        
        public IOAdapter(ChromeSession session)
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
        /// Read a chunk of the stream
        /// </summary>
        public async Task<ReadCommandResponse> Read(ReadCommand command)
        {
            return await m_session.SendCommand<ReadCommand, ReadCommandResponse>(command);
        }
    
        /// <summary>
        /// Close the stream, discard any temporary backing storage.
        /// </summary>
        public async Task<CloseCommandResponse> Close(CloseCommand command)
        {
            return await m_session.SendCommand<CloseCommand, CloseCommandResponse>(command);
        }
    

    
    }
}