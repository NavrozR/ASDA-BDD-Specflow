using AsdaTest.Base;
using AsdaTest.Page;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace AsdaTest
{
    [Binding]
    [Scope(Tag ="AsdaDropdown")]
    public class AsdaDropdownSteps : AsdaSetup
    {
        public IWebDriver Browser;
        public AsdaDropdown Option;

        [Given(@"I have navigated to Asda home page")]
        public void GivenIHaveNavigatedToAsdaHomePage()
        {
            Browser = Driver;
            Option = new AsdaDropdown(Browser);
            Browser.Navigate().GoToUrl("https://www.asda.com/");

        }
        
        [Given(@"I have clicked on Groceries main page")]
        public void GivenIHaveClickedOnGroceriesMainPage()
        {
            Option.GroceriesMainClick();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }
        
        [Given(@"I have clicked on Groceries on Asda Groceries page")]
        public void GivenIHaveClickedOnGroceriesOnAsdaGroceriesPage()
        {
            Option.GroceriesSubClick();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }
        
        [When(@"I select Apples from the dropdown menu of Fruit")]
        public void WhenISelectApplesFromTheDropdownMenuOfFruit()
        {
            Option.FreshFoodClick();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            Option.FruitClick();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            Option.AppleClick();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            Option.BrandClick();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }
        
        [Then(@"I see page showing various Apples on sale")]
        public void ThenISeePageShowingVariousApplesOnSale()
        {
            //Option.VerifyApplePage();
            Option.VerifyPinkLadyApplePage();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

        }
    }
}
