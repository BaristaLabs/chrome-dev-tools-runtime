namespace BaristaLabs.ChromeDevTools.Runtime.ApplicationCache
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the ApplicationCache domain to simplify the command interface.
    /// </summary>
    public class ApplicationCacheAdapter
    {
        private readonly ChromeSession m_session;
        
        public ApplicationCacheAdapter(ChromeSession session)
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
        /// Returns array of frame identifiers with manifest urls for each frame containing a document associated with some application cache.
        /// </summary>
        public async Task<GetFramesWithManifestsCommandResponse> GetFramesWithManifests(GetFramesWithManifestsCommand command)
        {
            return await m_session.SendCommand<GetFramesWithManifestsCommand, GetFramesWithManifestsCommandResponse>(command);
        }
    
        /// <summary>
        /// Enables application cache domain notifications.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command);
        }
    
        /// <summary>
        /// Returns manifest URL for document in the given frame.
        /// </summary>
        public async Task<GetManifestForFrameCommandResponse> GetManifestForFrame(GetManifestForFrameCommand command)
        {
            return await m_session.SendCommand<GetManifestForFrameCommand, GetManifestForFrameCommandResponse>(command);
        }
    
        /// <summary>
        /// Returns relevant application cache data for the document in given frame.
        /// </summary>
        public async Task<GetApplicationCacheForFrameCommandResponse> GetApplicationCacheForFrame(GetApplicationCacheForFrameCommand command)
        {
            return await m_session.SendCommand<GetApplicationCacheForFrameCommand, GetApplicationCacheForFrameCommandResponse>(command);
        }
    

    
        /// <summary>
        /// 
        /// </summary>
        public void SubscribeToApplicationCacheStatusUpdatedEvent(Action<ApplicationCacheStatusUpdatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public void SubscribeToNetworkStateUpdatedEvent(Action<NetworkStateUpdatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
    }
}