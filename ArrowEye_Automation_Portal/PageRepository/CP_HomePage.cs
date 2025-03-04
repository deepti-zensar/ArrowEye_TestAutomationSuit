using SeleniumExtras.PageObjects;
using ArrowEye_Automation_Framework.Common;
using OpenQA.Selenium;
using System.Threading;
using System.Collections.Generic;
using ArrowEye_Automation_Framework;
using System;
using OpenQA.Selenium.Interactions;
using static OpenQA.Selenium.BiDi.Modules.Script.RemoteValue;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

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

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='nestedMenuItem']//p[contains(text(),'Client Settings')]")]
        public IWebElement ClientSettings;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='nestedMenuItem']//p[contains(text(),'Products')]")]
        public IWebElement Products;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'BOC Dynamic Info')]")]
        public IWebElement BOCDynamicInfo;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'Bank ID Numbers')]")]
        public IWebElement BankIdNumbers;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'Standard Carriers')]")]
        public IWebElement StandardCarrier;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'Card Holder Agreement')]")]
        public IWebElement CardHolderAgreement;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'Carrier Dynamic Info')]")]
        public IWebElement CarrierDynamicInfo;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'EMV Profile')]")]
        public IWebElement EMVProfile;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'FOC Dynamic Info')]")]
        public IWebElement FOCDynamicInfo;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'BCSS Configurations')]")]
        public IWebElement BCSSConfigurations;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'Client Profiles')]")]
        public IWebElement ClientProfiles;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'Default Proof Replacements')]")]
        public IWebElement DefaultProofReplacements;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'Embosser Field Maps')]")]
        public IWebElement EmbosserFieldMaps;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'General Settings')]")]
        public IWebElement GeneralSettings;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'Hot Stamps')]")]
        public IWebElement HotStamps;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'Inventory Configuration')]")]
        public IWebElement InventoryConfiguration;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'Issuing Banks')]")]
        public IWebElement IssuingBanks;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'Mag Track Encodings')]")]
        public IWebElement MagTrackEncodings;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'Configure Client')]")]
        public IWebElement ConfigureClient;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'Number Generators')]")]
        public IWebElement NumberGenerators;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'Platforms & Products')]")]
        public IWebElement Platforms_Products;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'Print Tags')]")]
        public IWebElement PrintTags;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'Print Settings')]")]
        public IWebElement PrintSettings;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'Publishing Policies')]")]
        public IWebElement PublishingPolicies;


        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'Retailer Client Configurations')]")]
        public IWebElement RetailerClient_Configurations;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'Retailer Profiles')]")]
        public IWebElement RetailerProfiles;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'Ship Types')]")]
        public IWebElement ShipTypes;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'SOP Adhoc Key-Values')]")]
        public IWebElement SOPAdhocKeyValues;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'SOP Configurations')]")]
        public IWebElement SOPConfigurations;


        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 css-9l3uo3' and contains(text(),'Issuers')]")]
        public IWebElement issuers;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiSelect-select MuiSelect-outlined MuiInputBase-input MuiOutlinedInput-input css-qiwgdb' and contains(text(),'Search or Select')]")]
        public IWebElement SearchOrSelect;

        [FindsBy(How = How.XPath, Using = "(//td[@class='MuiTableCell-root MuiTableCell-body MuiTableCell-sizeMedium jss6 css-q34dxg'])[position()=13]")]
        public IWebElement AmazonPCL;

        public void ValidateHomePageTitle()
        {
            Thread.Sleep(5000);
            var elemnetvisible = homePageTitle.Displayed;
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


        public void NavigateToClientSettings(string ClientSetting_SubMenuName)
        {
            Browser.Click(SearchOrSelect);
            Browser.Click(AmazonPCL);
            Browser.Click(clientGallery);
            Browser.Click(ClientSettings);
            
            switch (ClientSetting_SubMenuName)
            {
                
                case "BankIDNumbers":
                    Browser.Click(BankIdNumbers);
                    break;
                case "BCSSConfigurations":
                    Browser.Click(BCSSConfigurations);
                    break;
                case "ClientProfiles":
                    Browser.Click(ClientProfiles);
                    break;
                case "DefaultProofReplacements":
                    Browser.Click(DefaultProofReplacements);
                    break;
                case "EmbosserFieldMaps":
                    Browser.Click(EmbosserFieldMaps);
                    break;

                case "GeneralSettings":
                    Browser.Click(GeneralSettings);
                    break;
                case "HotStamps":
                    Browser.Click(HotStamps);
                    break;
                case "InventoryConfiguration":
                    Browser.Click(InventoryConfiguration);
                    break;
                case "IssuingBanks":
                    Browser.Click(IssuingBanks);
                    break;
                case "MagTrackEncodings":
                    Browser.Click(MagTrackEncodings);
                    break;

                case "ConfigureClient":
                    Browser.Click(ConfigureClient);
                    break;
                case "Platforms_Products":
                    Browser.Click(Platforms_Products);
                    break;
                case "PrintTags":
                    Browser.Click(PrintTags);
                    break;
                case "PrintSettings":
                    Browser.Click(PrintSettings);
                    break;
                case "PublishingPolicies":
                    Browser.Click(PublishingPolicies);
                    break;

                case "RetailerClient_Configurations":
                    Browser.Click(RetailerClient_Configurations);
                    break;
                case "RetailerProfiles":
                    Browser.Click(RetailerProfiles);
                    break;
                case "ShipTypes":
                    Browser.Click(ShipTypes);
                    break;

                case "SOPAdhocKeyValues":
                    Browser.Click(SOPAdhocKeyValues);
                    break;
                case "SOPConfigurations":
                    Browser.Click(SOPConfigurations);
                    break;

            }
        }


        public void NavigateToProducts(string ClientSetting_SubMenuName)
        {
            Browser.Click(SearchOrSelect);
            Browser.Click(AmazonPCL);
            Browser.Click(clientGallery);
            Browser.Click(Products);

            switch (ClientSetting_SubMenuName)
            {

                case "StandardCarriers":
                    Browser.Click(StandardCarrier);
                    break;

            }
        }


        public void CSPSettings_SubmenuItems(bool CSPSetting_SubMenuName)
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



    }
}
