using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System.Threading;

namespace Projeto_Teste_WebDriver
{
    [TestClass]
    public class Test
    {

        static RemoteWebDriver driveFF;

        #region Config
        string url = "https://www.google.com.br";
        string seacrhGoogle = "Facebook";
        #endregion

        [TestInitialize]
        public void Setup()
        {
            driveFF = new FirefoxDriver();
            driveFF.Navigate().GoToUrl(url);
            Thread.Sleep(6000);
            DSL.DSLGoogle.driverFF = driveFF;
        }

        [TestMethod]
        public void TestGoogle()
        {
            DSL.DSLGoogle.VerifyLogoGoogle(seacrhGoogle);
            Thread.Sleep(2000);
            DSL.DSLGoogle.VerifySearch();
        }

        [TestCleanup]
        public void FinallyTest()
        {
            Thread.Sleep(2000);
            driveFF.Close();

            Thread.Sleep(500);
            driveFF.Quit();
        }

    }
}
