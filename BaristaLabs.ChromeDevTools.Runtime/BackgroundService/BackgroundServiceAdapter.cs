namespace BaristaLabs.ChromeDevTools.Runtime.BackgroundService
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the BackgroundService domain to simplify the command interface.
    /// </summary>
    public class BackgroundServiceAdapter
    {
        private readonly ChromeSession m_session;
        
        public BackgroundServiceAdapter(ChromeSession session)
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
        /// Enables event updates for the service.
        /// </summary>
        public async Task<StartObservingCommandResponse> StartObserving(StartObservingCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<StartObservingCommand, StartObservingCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Disables event updates for the service.
        /// </summary>
        public async Task<StopObservingCommandResponse> StopObserving(StopObservingCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<StopObservingCommand, StopObservingCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Set the recording state for the service.
        /// </summary>
        public async Task<SetRecordingCommandResponse> SetRecording(SetRecordingCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetRecordingCommand, SetRecordingCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Clears all stored data for the service.
        /// </summary>
        public async Task<ClearEventsCommandResponse> ClearEvents(ClearEventsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ClearEventsCommand, ClearEventsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

        /// <summary>
        /// Called when the recording state for the service has been updated.
        /// </summary>
        public void SubscribeToRecordingStateChangedEvent(Action<RecordingStateChangedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Called with all existing backgroundServiceEvents when enabled, and all new
        /// events afterwards if enabled and recording.
        /// </summary>
        public void SubscribeToBackgroundServiceEventReceivedEvent(Action<BackgroundServiceEventReceivedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    }
}