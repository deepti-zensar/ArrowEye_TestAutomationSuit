using SeleniumExtras.PageObjects;
using ArrowEye_Automation_Framework.Common;
using OpenQA.Selenium;
using System.Threading;

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

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'Card Holder Agreement')]")]
        public IWebElement CardHolderAgreement;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'Carrier Dynamic Info')]")]
        public IWebElement CarrierDynamicInfo;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'EMV Profile')]")]
        public IWebElement EMVProfile;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'FOC Dynamic Info')]")]
        public IWebElement FOCDynamicInfo;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 css-9l3uo3' and contains(text(),'Issuers')]")]
        public IWebElement issuers;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiSelect-select MuiSelect-outlined MuiInputBase-input MuiOutlinedInput-input css-qiwgdb' and contains(text(),'Search or Select')]")]
        public IWebElement SearchOrSelect;

        [FindsBy(How = How.XPath, Using = "(//td[@class='MuiTableCell-root MuiTableCell-body MuiTableCell-sizeMedium jss6 css-q34dxg'])[position()=1]")]
        public IWebElement AmazonPCL;

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
            Browser.Click(issuers);
        }

        public void NavigateToCSPSettings(string CSPSetting_SubMenuName)
        {
            Browser.Click(SearchOrSelect);
            Browser.Click(AmazonPCL);
            Browser.Click(clientGallery);
            Browser.Click(CSPSettings);
            switch (CSPSetting_SubMenuName)
            {
                case "BOCDynamicInfo":
                    Browser.Click(BOCDynamicInfo);
                    break;
                case "FOCDynamicInfo":
                    Browser.Click(FOCDynamicInfo);
                    break;
                case "CardHolderAgreement":
                    Browser.Click(CardHolderAgreement);
                    break;
                case "EMVProfile":
                    Browser.Click(EMVProfile);
                    break;
                case "CarrierDynamicInfo":
                    Browser.Click(CarrierDynamicInfo);
                    break;
            }
        }

        //public void NavigateToCSPSettings()
        //{
        //    Browser.Click(SearchOrSelect);
        //    Browser.Click(AmazonPCL);
        //    Browser.Click(clientGallery);
        //    Browser.Click(CSPSettings);
        //    Browser.Click(FOCDynamicInfo);
        //}

    }
}
