namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// This method tries to lookup and populate exception details for a
    /// JavaScript Error object.
    /// Note that the stackTrace portion of the resulting exceptionDetails will
    /// only be populated if the Runtime domain was enabled at the time when the
    /// Error was thrown.
    /// </summary>
    public sealed class GetExceptionDetailsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Runtime.getExceptionDetails";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// The error object for which to resolve the exception details.
        /// </summary>
        [JsonProperty("errorObjectId")]
        public string ErrorObjectId
        {
            get;
            set;
        }
    }

    public sealed class GetExceptionDetailsCommandResponse : ICommandResponse<GetExceptionDetailsCommand>
    {
        /// <summary>
        /// Gets or sets the exceptionDetails
        /// </summary>
        [JsonProperty("exceptionDetails", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ExceptionDetails ExceptionDetails
        {
            get;
            set;
        }
    }
}