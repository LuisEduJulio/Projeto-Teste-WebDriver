using OpenQA.Selenium.Remote;

namespace Projeto_Teste_WebDriver.PAGE
{
    public class PageAbstract
    {
        protected RemoteWebDriver NewDriverFF;

        public PageAbstract(RemoteWebDriver driverFF)
        {
            this.NewDriverFF = driverFF;
            MaximinizeWindows();
        }

        private void MaximinizeWindows()
        {
            NewDriverFF.Manage().Window.Maximize();
        }
    }
}
