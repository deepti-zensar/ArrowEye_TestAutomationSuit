using SeleniumExtras.PageObjects;
using ArrowEye_Automation_Framework.Common;
using OpenQA.Selenium;
using System.Threading;
using ArrowEye_Automation_Portal.Tests.Feature.CSP_Settings;

namespace ArrowEye_Automation_Portal.PageRepository
{
    public class CP_HomePage
    {
        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 css-9l3uo3']")]
        public IWebElement homePageTitle;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 css-1051h91' and contains(text(),'CLIENT GALLERY') and @data-testid='secondNested']")]
        public IWebElement clientGallery;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 css-18ahme0' and contains(text(),'EMV')]")]
        public IWebElement emv;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='nestedMenuItem']//p[contains(text(),'CSP Settings')]")]
        public IWebElement CSPSettings;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'BOC Dynamic Info')]")]
        public IWebElement BOCDynamicInfo;

        [FindsBy(How = How.XPath, Using = "//li[@id='subMenuItems']//p[contains(text(),'Issuers')]")]
        public IWebElement emvIssuers;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiSelect-select MuiSelect-outlined MuiInputBase-input MuiOutlinedInput-input css-qiwgdb' and contains(text(),'Search or Select')]")]
        public IWebElement SearchOrSelect;

        [FindsBy(How = How.XPath, Using = "(//td[@class='MuiTableCell-root MuiTableCell-body MuiTableCell-sizeMedium jss6 css-q34dxg'])[position()=1]")]
        public IWebElement AmazonPCL;

        [FindsBy(How = How.XPath, Using = "//li[@id='subMenuItems']//p[contains(text(),'Authentications')]")]
        public IWebElement emvAuthentications;

        [FindsBy(How = How.XPath, Using = "//li[@id='subMenuItems']//p[contains(text(),'Card Profiles')]")]
        public IWebElement emvCardProfiles;

        [FindsBy(How = How.XPath, Using = "//li[@id='subMenuItems']//p[contains(text(),'Configurations')]")]
        public IWebElement emvConfigurations;

        [FindsBy(How = How.XPath, Using = "//li[@id='subMenuItems']//p[contains(text(),'Scripts')]")]
        public IWebElement emvScripts;

        [FindsBy(How = How.XPath, Using = "//li[@id='subMenuItems']//p[contains(text(),'Modules')]")]
        public IWebElement emvModules;


        public void ValidateHomePageTitle()
        {
            Thread.Sleep(5000);
            var elemnetvisible = homePageTitle.Displayed;
        }

        public void NavigateToIssuers()
        {
            Browser.Click(SearchOrSelect);
            Browser.Click(AmazonPCL);
            Browser.Click(clientGallery);
            Browser.Click(emv);
            Browser.Click(emvIssuers);
        }

        public void NavigateToCSPSettings()
        {
            Browser.Click(SearchOrSelect);
            Browser.Click(AmazonPCL);
            Browser.Click(clientGallery);
            Browser.Click(CSPSettings);
            Browser.Click(BOCDynamicInfo);
        }

        public void NavigateToEMV()
        {
            Browser.Click(SearchOrSelect);
            Browser.Click(AmazonPCL);
            Browser.Click(clientGallery);
            Browser.Click(emv);            
        }

        public void NavigateToEMVSubmenu(string emvSubmenu)
        {
            Browser.Click(SearchOrSelect);
            Browser.Click(AmazonPCL);
            Browser.Click(clientGallery);
            Browser.Click(emv);
            switch (emvSubmenu)
            {
                case "Authentications":
                    Browser.Click(emvAuthentications);
                    break;
                case "Card Profiles":
                    Browser.Click(emvCardProfiles);
                    break;
                case "Configurations":
                    Browser.Click(emvConfigurations);
                    break;
                case "Issuers":
                    Browser.Click(emvIssuers);
                    break;
                case "Scripts":
                    Browser.Click(emvScripts);
                    break;
                case "Modules":
                    Browser.Click(emvModules);
                    break;
            }            
        }

    }
}
