using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace Projeto_Teste_WebDriver.DSL
{
    public class DSLGoogle
    {
        public static RemoteWebDriver driverFF;
       
        public static void VerifyLogoGoogle(string searchGoogle)
        {
            new PAGE.PageGoogle(driverFF).InputGoogle().Click();
            new PAGE.PageGoogle(driverFF).InputGoogle().SendKeys(Keys.Enter);
            new PAGE.PageGoogle(driverFF).InputGoogle().SendKeys(searchGoogle);
            new PAGE.PageGoogle(driverFF).InputGoogle().SendKeys(Keys.Enter);
        }

        public static void VerifySearch()
        {
            string verifyStringSearch =  new PAGE.PageGoogle(driverFF).LinkSearch().Text;
            Assert.AreEqual(verifyStringSearch, "Facebook – entre ou cadastre-se");
        }

    }
}
