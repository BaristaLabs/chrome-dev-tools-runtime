﻿namespace BaristaLabs.ChromeDevTools
{
    using Newtonsoft.Json;

    public sealed class ChromeSessionError
    {

        [JsonProperty("code")]
        public string Code
        {
            get;
            set;
        }

        [JsonProperty("message")]
        public string Message
        {
            get;
            set;
        }

        [JsonProperty("data")]
        public string Data
        {
            get;
            set;
        }
    }
}
