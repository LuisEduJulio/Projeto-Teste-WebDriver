using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System.Threading;

namespace Projeto_Teste_WebDriver.Teste
{
    [TestClass]
    public class TestOpen
    {
        static RemoteWebDriver driveFF;

        #region Config
        string url = "http://automationpractice.com/index.php";
        string email = "Seu email";
        #endregion

        [TestInitialize]
        public void Setup()
        {
            driveFF = new FirefoxDriver();
            driveFF.Navigate().GoToUrl(url);
            Thread.Sleep(6000);
            DSL.DSLOpen.driverFF = driveFF;
        }

        [TestMethod]
        public void TestEnterPage()
        {
            DSL.DSLOpen.VerifyHome();
            Thread.Sleep(2000);
        }
        [TestMethod]
        public void TestRegister()
        {
            DSL.DSLOpen.Register(email);
            Thread.Sleep(2000);
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
