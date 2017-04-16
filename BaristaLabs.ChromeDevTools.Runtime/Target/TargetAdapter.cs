namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Target domain to simplify the command interface.
    /// </summary>
    public class TargetAdapter
    {
        private readonly ChromeSession m_session;
        
        public TargetAdapter(ChromeSession session)
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
        /// Controls whether to discover available targets and notify via <code>targetCreated/targetDestroyed</code> events.
        /// </summary>
        public async Task<SetDiscoverTargetsCommandResponse> SetDiscoverTargets(SetDiscoverTargetsCommand command)
        {
            return await m_session.SendCommand<SetDiscoverTargetsCommand, SetDiscoverTargetsCommandResponse>(command);
        }
    
        /// <summary>
        /// Controls whether to automatically attach to new targets which are considered to be related to this one. When turned on, attaches to all existing related targets as well. When turned off, automatically detaches from all currently attached targets.
        /// </summary>
        public async Task<SetAutoAttachCommandResponse> SetAutoAttach(SetAutoAttachCommand command)
        {
            return await m_session.SendCommand<SetAutoAttachCommand, SetAutoAttachCommandResponse>(command);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<SetAttachToFramesCommandResponse> SetAttachToFrames(SetAttachToFramesCommand command)
        {
            return await m_session.SendCommand<SetAttachToFramesCommand, SetAttachToFramesCommandResponse>(command);
        }
    
        /// <summary>
        /// Enables target discovery for the specified locations, when <code>setDiscoverTargets</code> was set to <code>true</code>.
        /// </summary>
        public async Task<SetRemoteLocationsCommandResponse> SetRemoteLocations(SetRemoteLocationsCommand command)
        {
            return await m_session.SendCommand<SetRemoteLocationsCommand, SetRemoteLocationsCommandResponse>(command);
        }
    
        /// <summary>
        /// Sends protocol message to the target with given id.
        /// </summary>
        public async Task<SendMessageToTargetCommandResponse> SendMessageToTarget(SendMessageToTargetCommand command)
        {
            return await m_session.SendCommand<SendMessageToTargetCommand, SendMessageToTargetCommandResponse>(command);
        }
    
        /// <summary>
        /// Returns information about a target.
        /// </summary>
        public async Task<GetTargetInfoCommandResponse> GetTargetInfo(GetTargetInfoCommand command)
        {
            return await m_session.SendCommand<GetTargetInfoCommand, GetTargetInfoCommandResponse>(command);
        }
    
        /// <summary>
        /// Activates (focuses) the target.
        /// </summary>
        public async Task<ActivateTargetCommandResponse> ActivateTarget(ActivateTargetCommand command)
        {
            return await m_session.SendCommand<ActivateTargetCommand, ActivateTargetCommandResponse>(command);
        }
    
        /// <summary>
        /// Closes the target. If the target is a page that gets closed too.
        /// </summary>
        public async Task<CloseTargetCommandResponse> CloseTarget(CloseTargetCommand command)
        {
            return await m_session.SendCommand<CloseTargetCommand, CloseTargetCommandResponse>(command);
        }
    
        /// <summary>
        /// Attaches to the target with given id.
        /// </summary>
        public async Task<AttachToTargetCommandResponse> AttachToTarget(AttachToTargetCommand command)
        {
            return await m_session.SendCommand<AttachToTargetCommand, AttachToTargetCommandResponse>(command);
        }
    
        /// <summary>
        /// Detaches from the target with given id.
        /// </summary>
        public async Task<DetachFromTargetCommandResponse> DetachFromTarget(DetachFromTargetCommand command)
        {
            return await m_session.SendCommand<DetachFromTargetCommand, DetachFromTargetCommandResponse>(command);
        }
    
        /// <summary>
        /// Creates a new empty BrowserContext. Similar to an incognito profile but you can have more than one.
        /// </summary>
        public async Task<CreateBrowserContextCommandResponse> CreateBrowserContext(CreateBrowserContextCommand command)
        {
            return await m_session.SendCommand<CreateBrowserContextCommand, CreateBrowserContextCommandResponse>(command);
        }
    
        /// <summary>
        /// Deletes a BrowserContext, will fail of any open page uses it.
        /// </summary>
        public async Task<DisposeBrowserContextCommandResponse> DisposeBrowserContext(DisposeBrowserContextCommand command)
        {
            return await m_session.SendCommand<DisposeBrowserContextCommand, DisposeBrowserContextCommandResponse>(command);
        }
    
        /// <summary>
        /// Creates a new page.
        /// </summary>
        public async Task<CreateTargetCommandResponse> CreateTarget(CreateTargetCommand command)
        {
            return await m_session.SendCommand<CreateTargetCommand, CreateTargetCommandResponse>(command);
        }
    
        /// <summary>
        /// Retrieves a list of available targets.
        /// </summary>
        public async Task<GetTargetsCommandResponse> GetTargets(GetTargetsCommand command)
        {
            return await m_session.SendCommand<GetTargetsCommand, GetTargetsCommandResponse>(command);
        }
    

    
        /// <summary>
        /// Issued when a possible inspection target is created.
        /// </summary>
        public void SubscribeToTargetCreatedEvent(Action<TargetCreatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Issued when a target is destroyed.
        /// </summary>
        public void SubscribeToTargetDestroyedEvent(Action<TargetDestroyedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Issued when attached to target because of auto-attach or <code>attachToTarget</code> command.
        /// </summary>
        public void SubscribeToAttachedToTargetEvent(Action<AttachedToTargetEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Issued when detached from target for any reason (including <code>detachFromTarget</code> command).
        /// </summary>
        public void SubscribeToDetachedFromTargetEvent(Action<DetachedFromTargetEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
        /// <summary>
        /// Notifies about new protocol message from attached target.
        /// </summary>
        public void SubscribeToReceivedMessageFromTargetEvent(Action<ReceivedMessageFromTargetEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
    }
}