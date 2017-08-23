namespace ChromeDevToolsRuntimeCLI
{
    using Newtonsoft.Json;

    public class ChromeSessionInfo
    {
        [JsonProperty("description")]
        public string Description
        {
            get;
            set;
        }

        [JsonProperty("devtoolsFrontendUrl")]
        public string DevToolsFrontendUrl
        {
            get;
            set;
        }

        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }

        [JsonProperty("title")]
        public string Title
        {
            get;
            set;
        }

        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }

        [JsonProperty("webSocketDebuggerUrl")]
        public string WebSocketDebuggerUrl
        {
            get;
            set;
        }
    }
}
