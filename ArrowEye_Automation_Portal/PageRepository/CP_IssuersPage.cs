using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using ArrowEye_Automation_Framework.Common;
using System.Threading;
using Keys = OpenQA.Selenium.Keys;

namespace ArrowEye_Automation_Portal.PageRepository
{
    public class CP_IssuersPage
    {
        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 jss14 css-1rtfhzq' and contains(text(),'EMV Issuers')]")]
        public IWebElement emvIssuersText;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 css-9l3uo3' and contains(text(),' Add New ')]")]
        public IWebElement addNewIssuer;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 jss49 css-9l3uo3' and contains(text(),'New Issuer')]")]
        public IWebElement newIssuerDialogBox;

        [FindsBy(How = How.XPath, Using = "//input[@name='name']")]
        public IWebElement nameField;

        [FindsBy(How = How.XPath, Using = "//input[@name='cpvPvtNumber']")]
        public IWebElement cpvField;

        [FindsBy(How = How.XPath, Using = "//input[@name='notes']")]
        public IWebElement notesField;

        [FindsBy(How = How.XPath, Using = "//input[@id='approval-path-autocomplete']")]
        private IWebElement approvalPath;

        [FindsBy(How = How.XPath, Using = "//p[@id='approval-path-autocomplete' and @aria-controls='spproval-path-autocomplete-option-0']")]
        private IWebElement certifiedPath;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='cancelCSP']")]
        private IWebElement cancelButton;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='saveCSP']")]
        private IWebElement saveButton;

        public void ValidatePageTitle()
        {
            DriverUtil.IsElementPresent(emvIssuersText);
        }

        public void ValidateNewIssuerDialogBox()
        {
            DriverUtil.IsElementPresent(newIssuerDialogBox);
        }

        public void AddNewIssuer(string name, int cpv, string appPath, string notes)
        {
            Browser.Click(addNewIssuer);
            Browser.Click(cancelButton);
            Thread.Sleep(3000);
            Browser.Click(addNewIssuer);
            nameField.SendKeys(name);
            Thread.Sleep(1000);
            cpvField.SendKeys(cpv.ToString());
            Browser.Click(approvalPath);
            Thread.Sleep(2000);
            approvalPath.SendKeys(Keys.Down + Keys.Enter);

            switch (appPath)
            {
                case "Certified":
                    approvalPath.SendKeys(Keys.Down + Keys.Enter);
                    break;
                case "CNS":
                    approvalPath.SendKeys(Keys.Down + Keys.Down + Keys.Enter);
                    break;
                case "EasyPath":
                    approvalPath.SendKeys(Keys.Down + Keys.Down + Keys.Down + Keys.Enter);
                    break;
                case "PE":
                    approvalPath.SendKeys(Keys.Down + Keys.Down + Keys.Down + Keys.Down + Keys.Enter);
                    break;
            }

            notesField.SendKeys(notes);
            Browser.Click(saveButton);
            Thread.Sleep(5000);

        }

        




    }
}
