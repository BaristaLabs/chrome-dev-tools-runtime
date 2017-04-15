namespace BaristaLabs.ChromeDevTools.Runtime.Schema
{
    using System;
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
        /// Returns supported domains.
        /// </summary>
        public async Task<GetDomainsCommandResponse> GetDomains(GetDomainsCommand command)
        {
            return await m_session.SendCommand<GetDomainsCommand, GetDomainsCommandResponse>(command);
        }
    

    
    }
}