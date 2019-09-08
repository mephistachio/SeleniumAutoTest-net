using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using System.Collections.Generic;
using OpenQA.Selenium.Interactions;

namespace SeleniumPOTest.Pages
{
    class HomePage
    {
        IWebDriver webDriver;
        public HomePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        #region Objects
        public IWebElement SearchBtn
        {
            get
            {
                Actions action = new Actions(webDriver);
                action.MoveToElement(webDriver.FindElement(By.CssSelector("button.the-header__panel-toggle:nth-child(4)")));
                webDriver.FindElement(By.CssSelector("button.the-header__panel-toggle:nth-child(4)")).Click();
                return SearchBox;
            }
        }
        public IWebElement SearchBox
        {
            get
            {
                return webDriver.FindElement(By.Id("search-input"));
            }
        }

        public IWebElement SearchSbmtBtn
        {
            get
            {
                return webDriver.FindElement(By.ClassName("search-field__btn"));
            }
        }


        #endregion
        #region Methods
        public string GetHomePageTitle()
        {
            string HomePageTitle = webDriver.Title;
            return HomePageTitle;
        }


        public ICollection<IWebElement> SearchgBox(string search)
        {

            SearchBox.SendKeys(search + Keys.Enter);
           // SearchSbmtBtn.Click();
            var searchResults = webDriver.FindElements(By.TagName("article"));
            return searchResults;

        }
        #endregion



    }
}
