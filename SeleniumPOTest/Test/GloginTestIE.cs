using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using SeleniumPOTest.Pages;
using System;

namespace SeleniumPOTest
{
    public class GloginTestIE
    {
        IWebDriver webDriver;
       

        [SetUp]

        public void IntBrowser()
        {
            webDriver = new InternetExplorerDriver();
            webDriver.Navigate().GoToUrl("https://www.dnvgl.com/");
            webDriver.FindElement(By.ClassName("the-header__login")).Click();
            webDriver.Manage().Window.Maximize();
                   }
                
        [Test]
        public void TestLoginIE()
        {
        HomePage ObjHomePage = new HomePage(webDriver);
        Login ObjLoginPage = new Login(webDriver);

        string LoginPageTitle = ObjLoginPage.LogIntoSys("mephistachio@gmail.com", "Qazxsw123");
        Assert.AreEqual("Sign In", LoginPageTitle);
        string homepageTitle = ObjHomePage.GetHomePageTitle();
        Assert.AreEqual("Working...", homepageTitle);
           
        new WebDriverWait(webDriver, TimeSpan.FromSeconds(3)).Until(x=>x.Url == "https://www.veracity.com/");
        Assert.AreEqual("https://www.veracity.com/", webDriver.Url);
           
                }

        public void BClose()
        {
        webDriver.Quit();
        }

    }
}
  