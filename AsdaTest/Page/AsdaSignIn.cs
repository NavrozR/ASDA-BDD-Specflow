using FluentAssertions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsdaTest.Page
{
    public class AsdaSignIn
    {
        public IWebDriver Driver;

        public AsdaSignIn(IWebDriver Browser) 
        {
            Driver = Browser;
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Groceries")]
        public IWebElement GroceriesLink;

        [FindsBy(How = How.LinkText, Using = "Sign In")]
        public IWebElement SignInLink;

        [FindsBy(How = How.ClassName, Using = "email-phone-input")]
        public IWebElement Username;

        [FindsBy(How = How.ClassName, Using = "show-password  ")]
        public IWebElement Password;

        [FindsBy(How = How.CssSelector, Using = "#app > main > div > div > div > div > form > button")]
        public IWebElement SubmitButton;

        [FindsBy(How = How.ClassName, Using = "asda-logo ")]
        public IWebElement YouraccountverifyLink;


        string account = "ASDA";

        public void GroceriesClick() 
        {
            GroceriesLink.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }

        public void SignInClick()
        {
            SignInLink.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }

        public void EnterUserDetails()
        {
            Username.SendKeys("navrozrashyani@gmail.com");
            Password.SendKeys("Pa55word");
            SubmitButton.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }

        public void VerifyAccountPage()
        {
            YouraccountverifyLink.Text.Contains(account).Should().BeTrue();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }
    }

}
