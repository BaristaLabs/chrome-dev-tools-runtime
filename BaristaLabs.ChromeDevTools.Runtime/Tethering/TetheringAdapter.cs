namespace BaristaLabs.ChromeDevTools.Runtime.Tethering
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Tethering domain to simplify the command interface.
    /// </summary>
    public class TetheringAdapter
    {
        private readonly ChromeSession m_session;
        
        public TetheringAdapter(ChromeSession session)
        {
            m_session = session ?? throw new ArgumentNullException(nameof(session));
        }

    
        /// <summary>
        /// Request browser port binding.
        /// </summary>
        public async Task<BindCommandResponse> Bind(BindCommand command)
        {
            return await m_session.SendCommand<BindCommand, BindCommandResponse>(command);
        }
    
        /// <summary>
        /// Request browser port unbinding.
        /// </summary>
        public async Task<UnbindCommandResponse> Unbind(UnbindCommand command)
        {
            return await m_session.SendCommand<UnbindCommand, UnbindCommandResponse>(command);
        }
    
    }
}