using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsdaTest.Page
{
    public class AsdaDropdown
    {
        public IWebDriver Driver;

        public AsdaDropdown(IWebDriver Browser)
        {

            Driver = Browser;
            PageFactory.InitElements(Driver, this);

        }

        [FindsBy(How = How.LinkText, Using = "Groceries")]
        public IWebElement GroceriesMainLink;

        [FindsBy(How = How.ClassName, Using = "navigation-menu__text")]
        public IWebElement GroceriesSubLink;

        [FindsBy(How = How.ClassName, Using = "h-nav__item")]
        public IWebElement FreshFoodLink;

        [FindsBy(How = How.CssSelector, Using = "div.taxonomy-explore > ul > a:nth-child(1)")]
        public IWebElement FruitLink;

        [FindsBy(How = How.LinkText, Using = "Apples")]
        public IWebElement AppleLink;

        [FindsBy(How = How.ClassName, Using = "co-dropdown__select")]
        public IWebElement BrandLink;

        [FindsBy(How = How.ClassName, Using = "co-item__col1")]
        public IWebElement PinkLadyAppleVerifyLink;

        //[FindsBy(How = How.ClassName, Using = "layout__title")]
        //public IWebElement VerifyAppleLink;

        //String account = "Apples";
        String  PinkLadyUrl= "https://groceries.asda.com/aisle/fresh-food-bakery/fruit/apples/112449?facets=aisle%3A112449%3A0000%3A%3ABrand%3A112449%2B4294961777%3APink+Lady&nutrition=&sortBy=&page=0";

        public void GroceriesMainClick() 
        {
            GroceriesMainLink.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }
        public void GroceriesSubClick()
        {
            GroceriesSubLink.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }
        public void FreshFoodClick()
        {
            FreshFoodLink.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }
        public void FruitClick()
        {
            FruitLink.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }
        public void AppleClick()
        {
            AppleLink.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }
        //public void VerifyApplePage()
        //{
        //    VerifyAppleLink.Text.Contains(account).Should().BeTrue();
        //    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        //}
        public void BrandClick()
        {
            //var BrandLink = Driver.FindElement(By.ClassName("facet-section"));
            //BrandLink.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            var selectElement = new SelectElement(BrandLink);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            selectElement.SelectByIndex(4);
            Console.Read();
            
        }
        public void VerifyPinkLadyApplePage()
        {
            PinkLadyAppleVerifyLink.Text.Contains(PinkLadyUrl);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }


    }




}
