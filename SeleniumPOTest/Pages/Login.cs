using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOTest.Pages
{
    class Login
    {
        IWebDriver webDriver;

        public Login(IWebDriver webDriver) => this.webDriver = webDriver;

        #region Objects
        public IWebElement EmailTextBox
        {
            get
            {
                return webDriver.FindElement(By.Id("userNameInput"));
            }
        }

        private IWebElement PwdBox
        {
            get
            {
                return webDriver.FindElement(By.Id("passwordInput"));
            }
        }

        private IWebElement LoginBtn
        {
            get
            {
                return webDriver.FindElement(By.Id("submitButton"));
            }
        }
        #endregion

        #region Methods

        public string LogIntoSys(string username, string password)
        {

            EmailTextBox.SendKeys(username);
            PwdBox.SendKeys(password);
            string LoginPageTitle = webDriver.Title;
            LoginBtn.Click();
            return LoginPageTitle;

        }




    } }
#endregion