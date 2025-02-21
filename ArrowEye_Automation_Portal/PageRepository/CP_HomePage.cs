using SeleniumExtras.PageObjects;
using ArrowEye_Automation_Framework.Common;
using OpenQA.Selenium;
using System.Threading;
using System.Collections.Generic;
using ArrowEye_Automation_Framework;
using System;
using OpenQA.Selenium.Interactions;
using static OpenQA.Selenium.BiDi.Modules.Script.RemoteValue;
using NUnit.Framework;

namespace ArrowEye_Automation_Portal.PageRepository
{
    public class CP_HomePage :TestBase
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

        [FindsBy(How = How.XPath, Using = "(//td[@class='MuiTableCell-root MuiTableCell-body MuiTableCell-sizeMedium jss6 css-q34dxg'])[position()=13]")]
        public IWebElement AmazonPCL;

        [FindsBy(How = How.XPath, Using = "//li[@id='subMenuItems']//p[contains(text(),'Issuers')]")]
        public IWebElement emvIssuers;

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

        [FindsBy(How = How.XPath, Using = "//li[@role='menuitem']//p[contains(text(),'Client Settings')]")]
        public IWebElement clientSettings;

        [FindsBy(How = How.XPath, Using = "//li[@id='subMenuItems']//p[contains(text(),'Default Proof Replacements')]")]
        public IWebElement clientSettingsDefaultProofReplacements;

        [FindsBy(How = How.XPath, Using = "//li[@id='subMenuItems']//p[contains(text(),'Mag Track Encodings')]")]
        public IWebElement clientSettingsMagTrackEncodings;

        [FindsBy(How = How.XPath, Using = "//li[@role='menuitem']//p[contains(text(),'Configuration Hierarchy')]")]
        public IWebElement configurationHierarchy;

        [FindsBy(How = How.XPath, Using = "//li[@role='menuitem']//p[contains(text(),'Products')]")]
        public IWebElement products;

        [FindsBy(How = How.XPath, Using = "//li[@id='subMenuItems']//p[contains(text(),'Pin Mailers')]")]
        public IWebElement productsPinMailers;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='menu']")]
        public IWebElement leftNavigationBar;

        [FindsBy(How = How.XPath, Using = "//ul[@role='menu']//li")]
        public IList<IWebElement> clientGalleryMenuOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[contains(@class,'MuiList-root MuiList-padding')]//p")]
        public IList<IWebElement> leftNavigationBarOptions { get; set; }

        public void ValidateHomePageTitle()
        {
            Thread.Sleep(5000);
            var elemnetvisible = homePageTitle.Displayed;
            if (elemnetvisible)
            {
                Browser.WaitForElement(SearchOrSelect, 10);
            }
            }

        public void SubmenuItems_display(IWebElement element)
        {
            IWebDriver _dr = Browser._Driver;
            element = _dr.FindElement(By.XPath("//li[@data-testid='nestedMenuItem']//p[contains(text(),'CSP Settings')]"));
            IWebElement listofsubmenuItems = _dr.FindElement(By.XPath("//li[@data-testid='nestedMenuItem']//p[contains(text(),'CSP Settings')]"));
            Actions abc= new Actions(_dr);
            abc.MoveToElement(element);
            abc.Click(listofsubmenuItems);
            abc.Build().Perform();

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
            CSPSettings_SubmenuItems(true);
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


        public void CSPSettings_SubmenuItems(System.Boolean CSPSetting_SubMenuName)
        {
            Browser.Click(CSPSettings);
            if (BOCDynamicInfo.Displayed&& CardHolderAgreement.Displayed && CarrierDynamicInfo.Displayed&& EMVProfile.Displayed&& FOCDynamicInfo.Displayed)
            {
                CSPSetting_SubMenuName = true;
            }
            else
            {
                Browser.Close();
            }
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
            NavigateToEMV();
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
        public void NavigateToClientSettings()
        {
            Browser.Click(SearchOrSelect);
            Browser.Click(AmazonPCL);
            Browser.Click(clientGallery);
            Browser.Click(clientSettings);
        }

        public void NavigateToClientSettingsSubmenu(string emvSubmenu)
        {
            NavigateToClientSettings();
            switch (emvSubmenu)
            {
                case "Default Proof Replacements":
                    Browser.Click(clientSettingsDefaultProofReplacements);
                    break;

                case "Mag Track Encodings":
                    Browser.Click(clientSettingsMagTrackEncodings);
                    break;

            }
        }

        public void NavigateToMenu(string menu)
        {
            Browser.Click(SearchOrSelect);
            Browser.Click(AmazonPCL);
            Browser.Click(clientGallery);
            switch (menu)
            {
                case "Configuration Hierarchy":
                    Browser.Click(configurationHierarchy);
                    break;

                case "Products":
                    Browser.Click(products);
                    break;

            }
        }

        public void NavigateToClientGallery()
        {
            Browser.Click(SearchOrSelect);
            Browser.Click(AmazonPCL);
            Browser.Click(clientGallery);            
        }

        public void NavigateToLeftBar()
        {
            Browser.Click(SearchOrSelect);
            Browser.Click(AmazonPCL);
            Browser.Click(leftNavigationBar);
            Thread.Sleep(2000);
        }

        public void NavigateToProductsSubmenu(string submenu)
        {
            NavigateToMenu("Products");
            switch (submenu)
            {
                case "Pin Mailers":
                    Browser.Click(productsPinMailers);
                    break;                

            }
        }


        public void ValidateClientGalleryOptions(string[] listOfOptions)
        {
            List<string> expectedListOfOptions = new List<string>(listOfOptions);
            List<string> actualListOfOptions = new List<string>();
            foreach (IWebElement actualOption in clientGalleryMenuOptions)
            {
                actualListOfOptions.Add(actualOption.Text);
            }            
            Assert.That(actualListOfOptions, Is.EquivalentTo(expectedListOfOptions));
        }

        public void ValidateLeftNavigationBarOptions(string[] listOfOptions)  
        {            
            List<string> expectedListOfOptions = new List<string>(listOfOptions);
            List<string> actualListOfOptions = new List<string>();
            foreach (IWebElement actualOption in leftNavigationBarOptions)
            {
                actualListOfOptions.Add(actualOption.Text);
            }
            Console.WriteLine(string.Join(", ",actualListOfOptions));
            Assert.That(actualListOfOptions, Is.EquivalentTo(expectedListOfOptions));
        }

    }
}
