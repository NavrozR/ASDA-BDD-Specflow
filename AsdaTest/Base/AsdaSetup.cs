using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace AsdaTest.Base
{
    public class AsdaSetup
    {
        public IWebDriver Driver;

        [BeforeScenario]

        public void BeforeScenario()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
        }

        [AfterScenario]

        public void AfterScenario() 
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}
