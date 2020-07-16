using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using Projeto_Teste_WebDriver.PAGE;

namespace Projeto_Teste_WebDriver.Page
{
    public class PageOpen : PageAbstract
    {
        public PageOpen(RemoteWebDriver driverFF) : base(driverFF)
        {
            this.NewDriverFF = driverFF;
        }
        //Label
        public IWebElement LabelPhone() { return NewDriverFF.FindElement(By.CssSelector(".shop-phone")); }
        public IWebElement LabelAutomation() { return NewDriverFF.FindElement(By.CssSelector("#editorial_block_center > h1:nth-child(3)")); }
        public IWebElement LabelPractice() { return NewDriverFF.FindElement(By.CssSelector("#editorial_block_center > h2:nth-child(4)")); }
        //Button
        public IWebElement ButtonSignIn() { return NewDriverFF.FindElement(By.CssSelector(".login")); }
        public IWebElement ButtonRegister() { return NewDriverFF.FindElement(By.CssSelector("#SubmitCreate")); }
        //Input
        public IWebElement InputEmail() { return NewDriverFF.FindElement(By.CssSelector("#email_create")); }

       

    }
}
