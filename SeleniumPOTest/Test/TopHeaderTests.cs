using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using SeleniumPOTest.Pages;
using System;

namespace SeleniumPOTest
{
    public class GloginTest
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
        public void TestSectorsList()
        {
        
         }

        [Test]
       
        public void TestServisesDropDown()
        {
          
        }

        [Test]
     
        public void TestInsightsDropDown()
        {

        }


        [Test]

        public void TestAboutUsDropDown()
        {

        }
        public void BClose()
        {
        webDriver.Quit();
        }

    }
}
  