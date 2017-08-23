namespace BaristaLabs.ChromeDevTools.Runtime.DeviceOrientation
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the DeviceOrientation domain to simplify the command interface.
    /// </summary>
    public class DeviceOrientationAdapter
    {
        private readonly ChromeSession m_session;
        
        public DeviceOrientationAdapter(ChromeSession session)
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
        /// Overrides the Device Orientation.
        /// </summary>
        public async Task<SetDeviceOrientationOverrideCommandResponse> SetDeviceOrientationOverride(SetDeviceOrientationOverrideCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetDeviceOrientationOverrideCommand, SetDeviceOrientationOverrideCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Clears the overridden Device Orientation.
        /// </summary>
        public async Task<ClearDeviceOrientationOverrideCommandResponse> ClearDeviceOrientationOverride(ClearDeviceOrientationOverrideCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ClearDeviceOrientationOverrideCommand, ClearDeviceOrientationOverrideCommandResponse>(command ?? new ClearDeviceOrientationOverrideCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

    }
}