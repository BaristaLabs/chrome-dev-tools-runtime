namespace BaristaLabs.ChromeDevTools.Runtime.WebAuthn
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the WebAuthn domain to simplify the command interface.
    /// </summary>
    public class WebAuthnAdapter
    {
        private readonly ChromeSession m_session;
        
        public WebAuthnAdapter(ChromeSession session)
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
        /// Enable the WebAuthn domain and start intercepting credential storage and
        /// retrieval with a virtual authenticator.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command ?? new EnableCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Disable the WebAuthn domain.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command ?? new DisableCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Creates and adds a virtual authenticator.
        /// </summary>
        public async Task<AddVirtualAuthenticatorCommandResponse> AddVirtualAuthenticator(AddVirtualAuthenticatorCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<AddVirtualAuthenticatorCommand, AddVirtualAuthenticatorCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Removes the given authenticator.
        /// </summary>
        public async Task<RemoveVirtualAuthenticatorCommandResponse> RemoveVirtualAuthenticator(RemoveVirtualAuthenticatorCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<RemoveVirtualAuthenticatorCommand, RemoveVirtualAuthenticatorCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Adds the credential to the specified authenticator.
        /// </summary>
        public async Task<AddCredentialCommandResponse> AddCredential(AddCredentialCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<AddCredentialCommand, AddCredentialCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns a single credential stored in the given virtual authenticator that
        /// matches the credential ID.
        /// </summary>
        public async Task<GetCredentialCommandResponse> GetCredential(GetCredentialCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetCredentialCommand, GetCredentialCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns all the credentials stored in the given virtual authenticator.
        /// </summary>
        public async Task<GetCredentialsCommandResponse> GetCredentials(GetCredentialsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetCredentialsCommand, GetCredentialsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Removes a credential from the authenticator.
        /// </summary>
        public async Task<RemoveCredentialCommandResponse> RemoveCredential(RemoveCredentialCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<RemoveCredentialCommand, RemoveCredentialCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Clears all the credentials from the specified device.
        /// </summary>
        public async Task<ClearCredentialsCommandResponse> ClearCredentials(ClearCredentialsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ClearCredentialsCommand, ClearCredentialsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Sets whether User Verification succeeds or fails for an authenticator.
        /// The default is true.
        /// </summary>
        public async Task<SetUserVerifiedCommandResponse> SetUserVerified(SetUserVerifiedCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetUserVerifiedCommand, SetUserVerifiedCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Sets whether tests of user presence will succeed immediately (if true) or fail to resolve (if false) for an authenticator.
        /// The default is true.
        /// </summary>
        public async Task<SetAutomaticPresenceSimulationCommandResponse> SetAutomaticPresenceSimulation(SetAutomaticPresenceSimulationCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetAutomaticPresenceSimulationCommand, SetAutomaticPresenceSimulationCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

    }
}