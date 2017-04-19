namespace BaristaLabs.ChromeDevTools.Runtime.Profiler
{
    using System;
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
        public async Task<EnableCommandResponse> Enable(EnableCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Changes CPU profiler sampling interval. Must be called before CPU profiles recording started.
        /// </summary>
        public async Task<SetSamplingIntervalCommandResponse> SetSamplingInterval(SetSamplingIntervalCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetSamplingIntervalCommand, SetSamplingIntervalCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<StartCommandResponse> Start(StartCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<StartCommand, StartCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<StopCommandResponse> Stop(StopCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<StopCommand, StopCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    

    
        /// <summary>
        /// Sent when new profile recodring is started using console.profile() call.
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