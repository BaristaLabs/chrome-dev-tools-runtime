namespace BaristaLabs.ChromeDevTools.Runtime.Browser
{
    using Newtonsoft.Json;

    /// <summary>
    /// Definition of PermissionDescriptor defined in the Permissions API:
    /// https://w3c.github.io/permissions/#dictdef-permissiondescriptor.
    /// </summary>
    public sealed class PermissionDescriptor
    {
        /// <summary>
        /// Name of permission.
        /// See https://cs.chromium.org/chromium/src/third_party/blink/renderer/modules/permissions/permission_descriptor.idl for valid permission names.
        ///</summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// For "midi" permission, may also specify sysex control.
        ///</summary>
        [JsonProperty("sysex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Sysex
        {
            get;
            set;
        }
        /// <summary>
        /// For "push" permission, may specify userVisibleOnly.
        /// Note that userVisibleOnly = true is the only currently supported type.
        ///</summary>
        [JsonProperty("userVisibleOnly", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? UserVisibleOnly
        {
            get;
            set;
        }
        /// <summary>
        /// For "clipboard" permission, may specify allowWithoutSanitization.
        ///</summary>
        [JsonProperty("allowWithoutSanitization", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? AllowWithoutSanitization
        {
            get;
            set;
        }
        /// <summary>
        /// For "camera" permission, may specify panTiltZoom.
        ///</summary>
        [JsonProperty("panTiltZoom", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? PanTiltZoom
        {
            get;
            set;
        }
    }
}