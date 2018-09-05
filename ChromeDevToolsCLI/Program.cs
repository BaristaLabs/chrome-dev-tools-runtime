namespace ChromeDevToolsRuntimeCLI
{
    using BaristaLabs.ChromeDevTools.Runtime;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Page = BaristaLabs.ChromeDevTools.Runtime.Page;
    using Runtime = BaristaLabs.ChromeDevTools.Runtime.Runtime;

    class Program
    {
        //Launch Chrome With
        //"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe" --remote-debugging-port=9223

        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var sessions = await GetSessions("http://localhost:9223/");

            using (var session = new ChromeSession(sessions.First(s => s.Type == "page").WebSocketDebuggerUrl))
            {
                //Get the frame resource tree
                var resource = await session.Page.GetResourceTree(new Page.GetResourceTreeCommand());

                //Navigate to winamp.com
                var navigateResult = await session.Page.Navigate(new Page.NavigateCommand
                {
                    Url = "http://www.amazon.com"
                });

                long executionContextId = -1;
                var s = new SemaphoreSlim(0, 1);

                //Subscribe to the eval command and determine the execution context id to use which
                //correlates to the page we navigated to.
                session.Runtime.SubscribeToExecutionContextCreatedEvent((e) =>
                {
                    var auxData = e.Context.AuxData as JObject;
                    var frameId = auxData["frameId"].Value<string>();

                    if (e.Context.Origin == "https://www.amazon.com" && frameId == navigateResult.FrameId)
                    {
                        executionContextId = e.Context.Id;
                        s.Release();
                    }
                });

                //Enable the runtime so that execution context events are raised.
                var result1 = await session.Runtime.Enable(new Runtime.EnableCommand());

                await s.WaitAsync();

                //Evaluate a complex answer.
                var result2 = await session.Runtime.Evaluate(new Runtime.EvaluateCommand
                {
                    ContextId = executionContextId,
                    ObjectGroup = "test123",
                    Expression = "6*7"
                });

                Console.WriteLine(result2.Result.Description);

                // New in Chrome 69, get a DOM snapshot.
                var result3 = await session.DOMSnapshot.CaptureSnapshot(new BaristaLabs.ChromeDevTools.Runtime.DOMSnapshot.CaptureSnapshotCommand()
                {
                    ComputedStyles = new string[0]
                });
            }
        }

        public static async Task<ICollection<ChromeSessionInfo>> GetSessions(string chromeUrl)
        {
            using (var webClient = new HttpClient())
            {
                webClient.BaseAddress = new Uri(chromeUrl);
                var remoteSessions = await webClient.GetStringAsync("/json");
                return JsonConvert.DeserializeObject<ICollection<ChromeSessionInfo>>(remoteSessions);
            }
        }
    }
}