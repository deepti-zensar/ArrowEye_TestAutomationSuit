using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using ArrowEye_ClientPortal_Automation.Common;
using OpenQA.Selenium;


namespace ArrowEye_ClientPortal_Automation.PageRepository
{
    public class CP_LoginPage
    {
        [FindsBy(How = How.XPath, Using = "//h5[@id='logincsp']")]
        public IWebElement loginPageText;

        [FindsBy(How = How.XPath, Using = "//input[@id='username']")]
        private IWebElement usernameField;

        [FindsBy(How = How.XPath, Using = "//input[@id='password']")]
        private IWebElement passwordField;

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement loginButton;

        [FindsBy(How = How.XPath, Using = "//input[@value='remember']")]
        private IWebElement rememberMeCheckbox;

        public bool IsAt()
        {
            return Browser.Title.Contains("Login");

        }

        private void ClearLoginFields()
        {
            usernameField.Clear();
            passwordField.Clear();
        }

        public void LogIn(string username, string password)
        {
            ClearLoginFields();
            usernameField.SendKeys(username);
            passwordField.SendKeys(password);
            Browser.Click(rememberMeCheckbox);
            Browser.Click(loginButton);
        }

    }
}
