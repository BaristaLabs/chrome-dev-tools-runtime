namespace BaristaLabs.ChromeDevTools.Runtime.PerformanceTimeline
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the PerformanceTimeline domain to simplify the command interface.
    /// </summary>
    public class PerformanceTimelineAdapter
    {
        private readonly ChromeSession m_session;
        
        public PerformanceTimelineAdapter(ChromeSession session)
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
        /// Previously buffered events would be reported before method returns.
        /// See also: timelineEventAdded
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

        /// <summary>
        /// Sent when a performance timeline event is added. See reportPerformanceTimeline method.
        /// </summary>
        public void SubscribeToTimelineEventAddedEvent(Action<TimelineEventAddedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    }
}