using ArrowEye_Automation_Framework.Common;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace ArrowEye_Automation_Portal.PageRepository
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

        [FindsBy(How = How.XPath, Using = "//span[text()='Remember me']")]
        private IWebElement rememberMeText;

        [FindsBy(How = How.XPath, Using = "//div[@data-testid='clientPortal']")]
        private IWebElement loginPageHeading;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Forgot Password?')]")]
        private IWebElement forgotPasswordLink;

        [FindsBy(How = How.XPath, Using = "//form[@data-testid='login-form']//p")]
        private IWebElement unsuccessfulLoginMsg;

        [FindsBy(How = How.XPath, Using = "//*[@data-testid='VisibilityOffIcon']")]
        private IWebElement showPassword;

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

        public void validateLoginPage()
        {
            Assert.That(loginPageHeading.Displayed, Is.True);
            Assert.That(loginPageText.Displayed, Is.True);
            Assert.That(usernameField.Displayed, Is.True);
            Assert.That(passwordField.Displayed, Is.True);
            Assert.That(loginButton.Displayed, Is.True);
            Assert.That(rememberMeCheckbox.Enabled, Is.True);
            Assert.That(rememberMeText.Displayed, Is.True);
            Assert.That(forgotPasswordLink.Displayed, Is.True);
        }

        public void ValidateUnsuccessfulLogin()
        {
            Browser.WaitForElement(unsuccessfulLoginMsg,5);
            Assert.That(unsuccessfulLoginMsg.Displayed, Is.True);
            Assert.That(unsuccessfulLoginMsg.Text, Is.EqualTo("This Client Portal account doesn't exist.Please contact your CSS representative for help."));
        }

        public void viewPasswordLogIn(string username, string password)
        {
            ClearLoginFields();
            usernameField.SendKeys(username);
            passwordField.SendKeys(password);
            Assert.That(passwordField.GetAttributeValue("type"), Is.EqualTo("password"));
            Browser.Click(showPassword);
            Assert.That(passwordField.GetAttributeValue("type"), Is.EqualTo("text"));
            Assert.That(passwordField.GetAttributeValue("value"), Is.EqualTo(password));
        }

    }
}
