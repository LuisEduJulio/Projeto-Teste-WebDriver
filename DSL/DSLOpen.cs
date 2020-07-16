using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace Projeto_Teste_WebDriver.DSL
{
    public class DSLOpen
    {
        public static RemoteWebDriver driverFF;

        public static void VerifyHome()
        {
            string LabelPhone = new Page.PageOpen(driverFF).LabelPhone().Text;
            Assert.AreEqual(LabelPhone, "Call us now: 0123-456-789"); 
            string LabelAutomation = new Page.PageOpen(driverFF).LabelAutomation().Text;
            Assert.AreEqual(LabelAutomation, "Automation Practice Website");
            string LabelPractice = new Page.PageOpen(driverFF).LabelPractice().Text;
            Assert.AreEqual(LabelPractice, "Practice Selenium");
        }
        public static void Register(string email)
        {
            new Page.PageOpen(driverFF).ButtonSignIn().Click();
            new Page.PageOpen(driverFF).InputEmail().SendKeys(email);
            new Page.PageOpen(driverFF).ButtonRegister().Click();

        }

    }
}
