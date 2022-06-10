namespace BaristaLabs.ChromeDevTools.Runtime.Media
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Media domain to simplify the command interface.
    /// </summary>
    public class MediaAdapter
    {
        private readonly ChromeSession m_session;
        
        public MediaAdapter(ChromeSession session)
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
        /// Enables the Media domain
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command ?? new EnableCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Disables the Media domain.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command ?? new DisableCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

        /// <summary>
        /// This can be called multiple times, and can be used to set / override /
        /// remove player properties. A null propValue indicates removal.
        /// </summary>
        public void SubscribeToPlayerPropertiesChangedEvent(Action<PlayerPropertiesChangedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Send events as a list, allowing them to be batched on the browser for less
        /// congestion. If batched, events must ALWAYS be in chronological order.
        /// </summary>
        public void SubscribeToPlayerEventsAddedEvent(Action<PlayerEventsAddedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Send a list of any messages that need to be delivered.
        /// </summary>
        public void SubscribeToPlayerMessagesLoggedEvent(Action<PlayerMessagesLoggedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Send a list of any errors that need to be delivered.
        /// </summary>
        public void SubscribeToPlayerErrorsRaisedEvent(Action<PlayerErrorsRaisedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Called whenever a player is created, or when a new agent joins and receives
        /// a list of active players. If an agent is restored, it will receive the full
        /// list of player ids and all events again.
        /// </summary>
        public void SubscribeToPlayersCreatedEvent(Action<PlayersCreatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    }
}