namespace BaristaLabs.ChromeDevTools.Runtime.Tests.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    [TestClass]
    public class ErrorHandlingUnitTests
    {
        [TestMethod]
        public async Task AssertWSErrorExceptionCanBeCaught()
        {
            bool exceptionThrown = false;

            //Create a new chrome instance
            var chrome = Chrome.OpenChrome(9226);
            var sessionInfo = await chrome.CreateNewSession();
            ChromeSession session = null;
            try
            {
                session = new ChromeSession(sessionInfo.WebSocketDebuggerUrl);
                await session.Page.Navigate(new Page.NavigateCommand {
                    Url = "https://www.google.com"
                });

                //Dispose of the chrome process, thus killing it.
                chrome.Dispose();

                //Wait a bit to ensure that the chrome process has been terminated.
                Thread.Sleep(2000);

                //Try another navigation -- this will raise the socket exception
                await session.Page.Navigate(new Page.NavigateCommand
                {
                    Url = "https://www.winamp.com"
                });
            }
            catch(System.Net.Sockets.SocketException)
            {
                exceptionThrown = true;
            }
            finally
            {
                //Ensure the session is disposed
                if (session != null)
                {
                    session.Dispose();
                }
            }

            Assert.IsTrue(exceptionThrown);
        }
    }
}
