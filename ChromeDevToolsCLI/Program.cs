namespace ChromeDevToolsCLI
{
    using BaristaLabs.ChromeDevTools.Runtime;
    using Page = BaristaLabs.ChromeDevTools.Runtime.Page;
    using Runtime = BaristaLabs.ChromeDevTools.Runtime.Runtime;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    class Program
    {
        //Launch Chrome With
        //"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe" --remote-debugging-port=9223

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var sessions = GetSessions("http://localhost:9223/").GetAwaiter().GetResult();

            using (var session = new ChromeSession(sessions.Last()))
            {
                session.SendCommand<Page.EnableCommand, Page.EnableCommandResponse>(new Page.EnableCommand()).GetAwaiter().GetResult();

                session.Subscribe<Page.FrameNavigatedEvent>((e) =>
                {
                    Console.WriteLine($"Navigated to {e.Frame.Url}");
                });

                //Navigate to winamp.com
                var navigateResult = session.SendCommand<Page.NavigateCommand, Page.NavigateCommandResponse>(new Page.NavigateCommand
                {
                    Url = "http://www.winamp.com"
                }).GetAwaiter().GetResult();

                long executionContextId = -1;

                //Subscribe to the eval command and determine the execution context id to use which
                //correlates to the page we navigated to.
                session.Subscribe<Runtime.ExecutionContextCreatedEvent>((e) =>
                {
                    var auxData = e.Context.AuxData as JObject;
                    var frameId = auxData["frameId"].Value<string>();

                    if (e.Context.Origin == "http://www.winamp.com" && frameId == navigateResult.FrameId)
                    {
                        executionContextId = e.Context.Id;
                    }
                });

                //Enable the runtime so that execution context events are raised.
                var result1 = session.SendCommand<Runtime.EnableCommand, Runtime.EnableCommandResponse>(new Runtime.EnableCommand()).GetAwaiter().GetResult();

                //Evaluate a complex answer.
                var result2 = session.SendCommand<Runtime.EvaluateCommand, Runtime.EvaluateCommandResponse>(new Runtime.EvaluateCommand
                {
                    ContextId = executionContextId,
                    ObjectGroup = "test123",
                    Expression = "6*7",
                }).GetAwaiter().GetResult();

                Console.WriteLine(result2.Result.Description);
            }
        }

        public static async Task<string[]> GetSessions(string url)
        {
            var remoteSessionUrls = new List<string>();
            var webClient = new HttpClient();
            var uriBuilder = new UriBuilder(url);
            uriBuilder.Path = "/json";
            var remoteSessions = await webClient.GetStringAsync(uriBuilder.Uri);
            using (var stringReader = new StringReader(remoteSessions))
            using (var jsonReader = new JsonTextReader(stringReader))
            {
                 var sessionsObject = JToken.ReadFrom(jsonReader) as JArray;
                foreach (var sessionObject in sessionsObject)
                {
                    var webSocketDebuggerToken = sessionObject["webSocketDebuggerUrl"];
                    if (webSocketDebuggerToken != null)
                    {
                        remoteSessionUrls.Add(webSocketDebuggerToken.Value<string>());
                    }
                }
            }
            return remoteSessionUrls.ToArray();
        }
    }
}