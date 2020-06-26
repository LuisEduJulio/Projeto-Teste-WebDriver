using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace Projeto_Teste_WebDriver.PAGE
{
    public class PageGoogle : PageAbstract
    {
        public PageGoogle(RemoteWebDriver driverFF) : base(driverFF)
        {
            this.NewDriverFF = driverFF;
        }

        public IWebElement InputGoogle() { return NewDriverFF.FindElement(By.CssSelector(".gLFyf")); }

        public IWebElement LinkSearch() { return NewDriverFF.FindElement(By.CssSelector("div.g:nth-child(1) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > a:nth-child(1) > h3:nth-child(2)")); }

    }
}
