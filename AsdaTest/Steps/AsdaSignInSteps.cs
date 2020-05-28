using AsdaTest.Base;
using AsdaTest.Page;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace AsdaTest
{
    [Binding]
    [Scope(Tag="AsdaSignIn")]
    
    public class AsdaSignInSteps : AsdaSetup
    {
        public IWebDriver Browser;
        public AsdaSignIn SignIn;

        [Given(@"I have navigated to Asda home page")]
        public void GivenIHaveNavigatedToAsdaHomePage()
        {
            Browser = Driver;
            SignIn = new AsdaSignIn(Browser);
            Browser.Navigate().GoToUrl("https://www.asda.com/");
        
        }
        
        [Given(@"I have clicked on Groceries")]
        public void GivenIHaveClickedOnGroceries()
        {
            SignIn.GroceriesClick();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }
        
        [When(@"I click SignIn button")]
        public void WhenIClickSignInButton()
        {
            SignIn.SignInClick();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }

        [When(@"I have entered Username and Password as signin details")]
        public void WhenIHaveEnteredUsernameAndPasswordAsSigninDetails()
        {
            SignIn.EnterUserDetails();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }

        [Then(@"I should see my account page")]
        public void ThenIShouldSeeMyAccountPage()
        {
            SignIn.VerifyAccountPage();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }
    }
}
