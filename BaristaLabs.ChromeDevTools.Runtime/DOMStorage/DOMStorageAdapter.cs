namespace BaristaLabs.ChromeDevTools.Runtime.DOMStorage
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the DOMStorage domain to simplify the command interface.
    /// </summary>
    public class DOMStorageAdapter
    {
        private readonly ChromeSession m_session;
        
        public DOMStorageAdapter(ChromeSession session)
        {
            m_session = session ?? throw new ArgumentNullException(nameof(session));
        }

    
        /// <summary>
        /// Enables storage tracking, storage events will now be delivered to the client.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command);
        }
    
        /// <summary>
        /// Disables storage tracking, prevents storage events from being sent to the client.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<GetDOMStorageItemsCommandResponse> GetDOMStorageItems(GetDOMStorageItemsCommand command)
        {
            return await m_session.SendCommand<GetDOMStorageItemsCommand, GetDOMStorageItemsCommandResponse>(command);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<SetDOMStorageItemCommandResponse> SetDOMStorageItem(SetDOMStorageItemCommand command)
        {
            return await m_session.SendCommand<SetDOMStorageItemCommand, SetDOMStorageItemCommandResponse>(command);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<RemoveDOMStorageItemCommandResponse> RemoveDOMStorageItem(RemoveDOMStorageItemCommand command)
        {
            return await m_session.SendCommand<RemoveDOMStorageItemCommand, RemoveDOMStorageItemCommandResponse>(command);
        }
    

    
        /// <summary>
        /// 
        /// </summary>
        public void SubscribeToDomStorageItemsClearedEvent(Action<DomStorageItemsClearedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public void SubscribeToDomStorageItemRemovedEvent(Action<DomStorageItemRemovedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public void SubscribeToDomStorageItemAddedEvent(Action<DomStorageItemAddedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public void SubscribeToDomStorageItemUpdatedEvent(Action<DomStorageItemUpdatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
    }
}