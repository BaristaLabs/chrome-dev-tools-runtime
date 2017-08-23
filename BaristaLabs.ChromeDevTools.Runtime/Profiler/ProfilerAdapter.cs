namespace BaristaLabs.ChromeDevTools.Runtime.Profiler
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Profiler domain to simplify the command interface.
    /// </summary>
    public class ProfilerAdapter
    {
        private readonly ChromeSession m_session;
        
        public ProfilerAdapter(ChromeSession session)
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
        /// Changes CPU profiler sampling interval. Must be called before CPU profiles recording started.
        /// </summary>
        public async Task<SetSamplingIntervalCommandResponse> SetSamplingInterval(SetSamplingIntervalCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetSamplingIntervalCommand, SetSamplingIntervalCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// 
        /// </summary>
        public async Task<StartCommandResponse> Start(StartCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<StartCommand, StartCommandResponse>(command ?? new StartCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// 
        /// </summary>
        public async Task<StopCommandResponse> Stop(StopCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<StopCommand, StopCommandResponse>(command ?? new StopCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Enable precise code coverage. Coverage data for JavaScript executed before enabling precise code coverage may be incomplete. Enabling prevents running optimized code and resets execution counters.
        /// </summary>
        public async Task<StartPreciseCoverageCommandResponse> StartPreciseCoverage(StartPreciseCoverageCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<StartPreciseCoverageCommand, StartPreciseCoverageCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Disable precise code coverage. Disabling releases unnecessary execution count records and allows executing optimized code.
        /// </summary>
        public async Task<StopPreciseCoverageCommandResponse> StopPreciseCoverage(StopPreciseCoverageCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<StopPreciseCoverageCommand, StopPreciseCoverageCommandResponse>(command ?? new StopPreciseCoverageCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Collect coverage data for the current isolate, and resets execution counters. Precise code coverage needs to have started.
        /// </summary>
        public async Task<TakePreciseCoverageCommandResponse> TakePreciseCoverage(TakePreciseCoverageCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<TakePreciseCoverageCommand, TakePreciseCoverageCommandResponse>(command ?? new TakePreciseCoverageCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Collect coverage data for the current isolate. The coverage data may be incomplete due to garbage collection.
        /// </summary>
        public async Task<GetBestEffortCoverageCommandResponse> GetBestEffortCoverage(GetBestEffortCoverageCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetBestEffortCoverageCommand, GetBestEffortCoverageCommandResponse>(command ?? new GetBestEffortCoverageCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

        /// <summary>
        /// Sent when new profile recording is started using console.profile() call.
        /// </summary>
        public void SubscribeToConsoleProfileStartedEvent(Action<ConsoleProfileStartedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// 
        /// </summary>
        public void SubscribeToConsoleProfileFinishedEvent(Action<ConsoleProfileFinishedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    }
}