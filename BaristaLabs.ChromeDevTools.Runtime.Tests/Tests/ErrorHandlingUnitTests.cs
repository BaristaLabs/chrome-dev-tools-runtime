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

            //Create a new session
            var sessionInfo = await RuntimeTestSetup.Chrome.CreateNewSession();
            ChromeSession session = null;
            try
            {
                session = new ChromeSession(sessionInfo.WebSocketDebuggerUrl);
                await session.Page.Navigate(new Page.NavigateCommand {
                    Url = "https://www.google.com"
                });

                //Simulate closing the tab, thus terminating the websockets connection.
                await RuntimeTestSetup.Chrome.CloseSession(sessionInfo);

                try
                {
                    //Try another navigation
                    await session.Page.Navigate(new Page.NavigateCommand
                    {
                        Url = "https://www.winamp.com"
                    });
                }
                catch(InvalidOperationException)
                {
                    //Catch the command response not recieved exception
                    exceptionThrown = true;
                }
                
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
