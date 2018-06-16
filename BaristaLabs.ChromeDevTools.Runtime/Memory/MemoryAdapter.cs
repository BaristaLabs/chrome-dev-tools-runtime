namespace BaristaLabs.ChromeDevTools.Runtime.Memory
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Memory domain to simplify the command interface.
    /// </summary>
    public class MemoryAdapter
    {
        private readonly ChromeSession m_session;
        
        public MemoryAdapter(ChromeSession session)
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
        /// getDOMCounters
        /// </summary>
        public async Task<GetDOMCountersCommandResponse> GetDOMCounters(GetDOMCountersCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetDOMCountersCommand, GetDOMCountersCommandResponse>(command ?? new GetDOMCountersCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// prepareForLeakDetection
        /// </summary>
        public async Task<PrepareForLeakDetectionCommandResponse> PrepareForLeakDetection(PrepareForLeakDetectionCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<PrepareForLeakDetectionCommand, PrepareForLeakDetectionCommandResponse>(command ?? new PrepareForLeakDetectionCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Enable/disable suppressing memory pressure notifications in all processes.
        /// </summary>
        public async Task<SetPressureNotificationsSuppressedCommandResponse> SetPressureNotificationsSuppressed(SetPressureNotificationsSuppressedCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetPressureNotificationsSuppressedCommand, SetPressureNotificationsSuppressedCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Simulate a memory pressure notification in all processes.
        /// </summary>
        public async Task<SimulatePressureNotificationCommandResponse> SimulatePressureNotification(SimulatePressureNotificationCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SimulatePressureNotificationCommand, SimulatePressureNotificationCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Start collecting native memory profile.
        /// </summary>
        public async Task<StartSamplingCommandResponse> StartSampling(StartSamplingCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<StartSamplingCommand, StartSamplingCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Stop collecting native memory profile.
        /// </summary>
        public async Task<StopSamplingCommandResponse> StopSampling(StopSamplingCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<StopSamplingCommand, StopSamplingCommandResponse>(command ?? new StopSamplingCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Retrieve native memory allocations profile
        /// collected since renderer process startup.
        /// </summary>
        public async Task<GetAllTimeSamplingProfileCommandResponse> GetAllTimeSamplingProfile(GetAllTimeSamplingProfileCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetAllTimeSamplingProfileCommand, GetAllTimeSamplingProfileCommandResponse>(command ?? new GetAllTimeSamplingProfileCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Retrieve native memory allocations profile
        /// collected since browser process startup.
        /// </summary>
        public async Task<GetBrowserSamplingProfileCommandResponse> GetBrowserSamplingProfile(GetBrowserSamplingProfileCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetBrowserSamplingProfileCommand, GetBrowserSamplingProfileCommandResponse>(command ?? new GetBrowserSamplingProfileCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Retrieve native memory allocations profile collected since last
        /// `startSampling` call.
        /// </summary>
        public async Task<GetSamplingProfileCommandResponse> GetSamplingProfile(GetSamplingProfileCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetSamplingProfileCommand, GetSamplingProfileCommandResponse>(command ?? new GetSamplingProfileCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

    }
}