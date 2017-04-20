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
        /// Gets the ChromeSession associated with the adapter.
        /// </summary>
        public ChromeSession Session
        {
            get { return m_session; }
        }

    
        /// <summary>
        /// Enables storage tracking, storage events will now be delivered to the client.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Disables storage tracking, prevents storage events from being sent to the client.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<ClearCommandResponse> Clear(ClearCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ClearCommand, ClearCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<GetDOMStorageItemsCommandResponse> GetDOMStorageItems(GetDOMStorageItemsCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetDOMStorageItemsCommand, GetDOMStorageItemsCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<SetDOMStorageItemCommandResponse> SetDOMStorageItem(SetDOMStorageItemCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetDOMStorageItemCommand, SetDOMStorageItemCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<RemoveDOMStorageItemCommandResponse> RemoveDOMStorageItem(RemoveDOMStorageItemCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<RemoveDOMStorageItemCommand, RemoveDOMStorageItemCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
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