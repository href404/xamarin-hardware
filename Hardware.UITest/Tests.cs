using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Hardware.UITest
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void ApplicationViewIsDisplayed()
        {
            // Ouvrir la console REPL
            //app.Repl();
            
            var results = app.WaitForElement(c => c.Marked("Package"));
            
            app.Screenshot("Application page");
            Assert.IsTrue(results.Any());
        }


        [Test]
        public void GoToEmailPage()
        {

            app.TapCoordinates(40, 73);
            app.Tap(x => x.Text("Email"));
            var results = app.WaitForElement(x => x.Text("Send email"));
            
            app.Screenshot("Email page");
            Assert.IsTrue(results.Any());
        }
    }
}
