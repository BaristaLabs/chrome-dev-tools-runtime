namespace BaristaLabs.ChromeDevTools.Runtime.ServiceWorker
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the ServiceWorker domain to simplify the command interface.
    /// </summary>
    public class ServiceWorkerAdapter
    {
        private readonly ChromeSession m_session;
        
        public ServiceWorkerAdapter(ChromeSession session)
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
        /// 
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command ?? new EnableCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// 
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command ?? new DisableCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// 
        /// </summary>
        public async Task<UnregisterCommandResponse> Unregister(UnregisterCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<UnregisterCommand, UnregisterCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// 
        /// </summary>
        public async Task<UpdateRegistrationCommandResponse> UpdateRegistration(UpdateRegistrationCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<UpdateRegistrationCommand, UpdateRegistrationCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// 
        /// </summary>
        public async Task<StartWorkerCommandResponse> StartWorker(StartWorkerCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<StartWorkerCommand, StartWorkerCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// 
        /// </summary>
        public async Task<SkipWaitingCommandResponse> SkipWaiting(SkipWaitingCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SkipWaitingCommand, SkipWaitingCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// 
        /// </summary>
        public async Task<StopWorkerCommandResponse> StopWorker(StopWorkerCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<StopWorkerCommand, StopWorkerCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// 
        /// </summary>
        public async Task<InspectWorkerCommandResponse> InspectWorker(InspectWorkerCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<InspectWorkerCommand, InspectWorkerCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// 
        /// </summary>
        public async Task<SetForceUpdateOnPageLoadCommandResponse> SetForceUpdateOnPageLoad(SetForceUpdateOnPageLoadCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetForceUpdateOnPageLoadCommand, SetForceUpdateOnPageLoadCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// 
        /// </summary>
        public async Task<DeliverPushMessageCommandResponse> DeliverPushMessage(DeliverPushMessageCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DeliverPushMessageCommand, DeliverPushMessageCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// 
        /// </summary>
        public async Task<DispatchSyncEventCommandResponse> DispatchSyncEvent(DispatchSyncEventCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DispatchSyncEventCommand, DispatchSyncEventCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

        /// <summary>
        /// 
        /// </summary>
        public void SubscribeToWorkerRegistrationUpdatedEvent(Action<WorkerRegistrationUpdatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// 
        /// </summary>
        public void SubscribeToWorkerVersionUpdatedEvent(Action<WorkerVersionUpdatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// 
        /// </summary>
        public void SubscribeToWorkerErrorReportedEvent(Action<WorkerErrorReportedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    }
}