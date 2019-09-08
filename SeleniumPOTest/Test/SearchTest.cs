using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumPOTest.Pages;
using System;
namespace SeleniumPOTest.Test
{
    class SearchTest
    {
        IWebDriver webDriver;

        [SetUp]

        public void IntBrowser()
        {
            webDriver = new FirefoxDriver();
            webDriver.Navigate().GoToUrl("https://www.dnvgl.com/");
            webDriver.Manage().Window.Maximize();
           

        }

        [Test]
        //positive
        public void SearchTestFF()
        {
            HomePage objSearch = new HomePage(webDriver);
           objSearch.SearchBtn.Click();
            var searchResult = objSearch.SearchgBox("2019");
            Assert.AreEqual(5, searchResult.Count);
           
        }
        [Test]
        //negative test
        public void SearchNegative()
        {
            HomePage objSearch = new HomePage(webDriver);
            objSearch.SearchBtn.Click();
            var searchResult = objSearch.SearchgBox("#@)!$0");
            Assert.AreEqual(0, searchResult.Count);

        }
    }
}
