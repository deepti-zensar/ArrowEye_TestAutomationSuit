using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using ArrowEye_Automation_Framework;
using ArrowEye_Automation_Framework.Common;
using ArrowEye_Automation_Portal.PageRepository.Objects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V129.Overlay;
using OpenQA.Selenium.Support.UI;
using Org.BouncyCastle.Bcpg.OpenPgp;
using RandomString4Net;
using SeleniumExtras.PageObjects;
using static NPOI.SS.Format.CellNumberFormatter;
using static OpenQA.Selenium.BiDi.Modules.Script.RemoteValue;

namespace ArrowEye_Automation_Portal.PageRepository.EMV
  
{
    //https://arroweye-jira-cloud.atlassian.net/browse/CRP-4481
    public class Programs_CommonSetting_Page : TestBase
    {

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Search or Select')]")]
        public IWebElement SearchOrSelect;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'CLIENT GALLERY')]")]
        public IWebElement clientGallery;

        public static string clientGalleryItem = "//p[contains(text(),'{0}')]";


        public static string PclDynamic = "//td[contains(.,'{0}')]";

        public static string clientGalleryMenuItem = "//li[@data-testid='nestedMenuItem']//p[contains(text(),'{0}')]";

        public static string clientGallerySubMenuItem = "//li[@data-testid='subMenuItems']//p[contains(text(),'{0}')]";

        [FindsBy(How = How.XPath, Using = "//button[text()='Common Settings']")]
        private IWebElement commonsettingbtn;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Envelope Settings')]")]
        private IWebElement EnvelopSetting;

        public static string programfield = "//div[text()='{0}']";

        public static string programinputfield = "//input[@name='{0}']";

        private string tableCellPath = "//div[@data-rowindex='{0}']/div[@data-colindex='{1}']";

        public static string addNewButton = "//p[contains(text(),'{0}')]";

        public static string commonsettingfield = "//p[contains(text(),'{0}')]";

        public static string buttoncommonfield = "//button[contains(text(),'{0}')]";

        public static string labelcommonfield = "//label[text()='Program Name']";

        public static string returnAddressfield = "//input[@name='{0}']";

        public static string shippingandFeesfieldYes = "//input[@type='radio' and @name='{0}' and @value='yes']";

        public static string shippingandFeesfieldNo = "//input[@type='radio' and @name='{0}' and @value='no']";

        public static string shippingandFeesfields = "//label[text()='{0}']/following-sibling::div//input[contains(@class, 'MuiInputBase-input')]";

        public static string EnvelopeSettingsSealedCourtesyYes = "//input[@name='{0}' and @value='yes']";

        public static string EnvelopeSettingsSealedCourtesyNo = "//input[@name='{0}' and @value='no']";

        public static string EnvelopeSettingsSealedCourtesydropdowns = "//label[text()='{0}']/following-sibling::div//input[@type='text']";

        public static string MiscellaneousAmexYes = "//p[text()='{0}']/following-sibling::div//input[@name='amexMall' and @value='yes']";

        public static string MiscellaneousAmexNo = "//p[text()='{0}']/following-sibling::div//input[@name='amexMall' and @value='no']";

        public static string MiscellaneousSupplementaryYes = "//p[text()='{0}']/following-sibling::div//input[@name='supplementaryDataRequired' and @value='yes']";

        public static string MiscellaneousSupplementaryNo = "//p[text()='{0}']/following-sibling::div//input[@name='supplementaryDataRequired' and @value='yes']";

        public static string MiscellaneousSignaturePanelSpecial = "//label[text()='{0}']/following-sibling::div//input[@type='text']";

        public static string ConsigneeAddressFields = "//p[text()='Consignee Address']/ancestor::div//label[text()='{0}']/following-sibling::div//input";


        public static string returnaddresscountryfield1 = "(//label[text()='{0}']/following-sibling::div//input)[1]";
       


        [FindsBy(How = How.XPath, Using = "(//td[contains(.,'9005: Pier One')])[6]")]
        private IWebElement ordersPcl;

        [FindsBy(How = How.XPath, Using = "//input[@name='programName']")]
        private IWebElement ProgramNameInput;

        [FindsBy(How = How.XPath, Using = "//label/span/input[@name='returnServiceRequired']")]
        private IWebElement returnServiceRequiredCheckbox;

        [FindsBy(How = How.XPath, Using = "//label/span/input[@name='indicaRequired']")]
        private IWebElement indicaRequiredCheckbox;

        [FindsBy(How = How.XPath, Using = "//label/span/input[@name='addressOverrideEnabled']")]
        private IWebElement addressOverrideCheckbox;

        [FindsBy(How = How.XPath, Using = "//input[@name='addressOverrideEnabled' and @type='checkbox']")]
        private IWebElement addressOverride;

        [FindsBy(How = How.XPath, Using = "//input[@name='indicaRequired' and @type='checkbox']")]
        private IWebElement indicaRequired;

        [FindsBy(How = How.XPath, Using = "//input[@name='overrideReturnAddress' and @value='yes']")]
        private IWebElement yesRadioButton;

        [FindsBy(How = How.XPath, Using = "//input[@name='overrideReturnAddress' and @value='no']")]
        private IWebElement noRadioButton;

        [FindsBy(How = How.XPath, Using = "//input[@aria-autocomplete='list' and @role='combobox']")]
        private IWebElement countryInput;

        [FindsBy(How = How.XPath, Using = "//input[@id=':r48:']")]
        private IWebElement countrydropdown;

        [FindsBy(How = How.XPath, Using = "(//label[text()='Country']/following-sibling::div//input)[1]")]
        private IWebElement returnaddresscountryfield;

        [FindsBy(How = How.XPath, Using = "(//label[text()='Country']/following-sibling::div//input)[1]")]
        private IWebElement returnaddresscountrydropdown;

        [FindsBy(How = How.XPath, Using = "//div[@id='notistack-snackbar']")]
        private IWebElement sucessmessage;

        public void NavigateToProgramsCommonSettingHomepage()
        {
            DriverUtilities.Click(SearchOrSelect);
            Thread.Sleep(1000);
            // Browser.ClickDynamicElement(PclDynamic, "9006: Pier 2");
            DriverUtilities.Click(ordersPcl);
            DriverUtilities.Click(clientGallery);
            Browser.ClickDynamicElement(clientGalleryItem, "Programs");
            ValidateProgramsField();
            Thread.Sleep(1000);
            Browser.getDynamicElement(tableCellPath, "0", "1").Click();
            DriverUtilities.Click(commonsettingbtn);


        }

        public void ValidateProgramsField()
        {
            WebElement scriptIDELe = Browser.getDynamicElement(programfield, "Program ID");
            WebElement scriptNameEle = Browser.getDynamicElement(programfield, "Program Name");
            WebElement scriptDescriptionELe = Browser.getDynamicElement(programfield, "Status");
            WebElement scriptProfileNameELe = Browser.getDynamicElement(programfield, "Actions");
            Browser.getDynamicElement(addNewButton, "Add New");
        }



        public void VerifyCommonSettingPageSections()
        {
            commonsettingbtn.Click();
            //Main
            Browser.getDynamicElement(commonsettingfield, "Main");
            Browser.getDynamicElement(shippingandFeesfields, "Program Name");

            //Shipping And Fees
            Browser.getDynamicElement(commonsettingfield, "Shipping And Fees");
            Browser.getDynamicElement(shippingandFeesfieldYes, "isSpecialSort");
            Browser.getDynamicElement(shippingandFeesfieldNo, "isSpecialSort");
            Browser.getDynamicElement(shippingandFeesfields, "Default Ship Type");
            Browser.getDynamicElement(shippingandFeesfields, "Signature Required");
            // need to check in dropdown required field or not required field

            Browser.getDynamicElement(shippingandFeesfields, "Service Fee");
            Browser.getDynamicElement(shippingandFeesfields, "Description");

            //Envelope Settings
            WebElement EnvelopeSettingsELe = Browser.getDynamicElement(clientGalleryItem, "Envelope Settings");
         //   DriverUtilities.ScrollToElementUsingAction(EnvelopeSettingsELe);
            Browser.getDynamicElement(commonsettingfield, "Envelope Settings");
            Browser.getDynamicElement(EnvelopeSettingsSealedCourtesyYes, "envelopeSealed");
            Browser.getDynamicElement(EnvelopeSettingsSealedCourtesyNo, "envelopeSealed");
            Browser.getDynamicElement(EnvelopeSettingsSealedCourtesyYes, "courtesyEnvelopeAllowed");
            Browser.getDynamicElement(EnvelopeSettingsSealedCourtesyNo, "courtesyEnvelopeAllowed");
            Browser.getDynamicElement(EnvelopeSettingsSealedCourtesydropdowns, "Envelope Name");
            Browser.getDynamicElement(EnvelopeSettingsSealedCourtesydropdowns, "Envelope Bulk Order");
            Browser.getDynamicElement(EnvelopeSettingsSealedCourtesydropdowns, "Envelope DTC Order");



            //Return Address
            //Scenario 2B: Programs Comman Settings Parameters when user selects "Default and override with return address below as Yes and Requires Special Indicia as No "
            Browser.getDynamicElement(commonsettingfield, "Return Address");
            addressOverride.Click();   
            Browser.getDynamicElement(returnAddressfield, "name");
            Browser.getDynamicElement(returnAddressfield, "company");
            Browser.getDynamicElement(returnAddressfield, "telephone");
            Browser.getDynamicElement(returnAddressfield, "returnAddress1");
            Browser.getDynamicElement(returnAddressfield, "returnAddress2");
            Browser.getDynamicElement(returnAddressfield, "returnAddressCity");
            Browser.getDynamicElement(returnAddressfield, "returnAddressState");
            Browser.getDynamicElement(returnAddressfield, "returnAddressZipCode");
            Browser.getDynamicElement(returnaddresscountryfield1, "Country");
           

            if (returnaddresscountrydropdown.Displayed)
            {
                Console.WriteLine("The 'Country' field is a dropdown.");
            }
            else
            {
                Console.WriteLine("The 'Country' field is not a dropdown.");
            }

            RequiresSpecialIndiciaAsYes();



            //Miscellaneous
            Browser.getDynamicElement(commonsettingfield, "Miscellaneous");
            Browser.getDynamicElement(MiscellaneousAmexYes, "Amex Mall?");
            Browser.getDynamicElement(MiscellaneousAmexNo, "Amex Mall?");
            Browser.getDynamicElement(MiscellaneousSupplementaryYes, "Supplementary Data?");
            Browser.getDynamicElement(MiscellaneousSupplementaryNo, "Supplementary Data?");
            Browser.getDynamicElement(MiscellaneousSignaturePanelSpecial, "Signature Panel");
            Browser.getDynamicElement(MiscellaneousSignaturePanelSpecial, "Special Instructions");


            //Consignee Address
            Browser.getDynamicElement(commonsettingfield, "Consignee Address");
            Browser.getDynamicElement(ConsigneeAddressFields, "Name");
            Browser.getDynamicElement(ConsigneeAddressFields, "Company");
            Browser.getDynamicElement(ConsigneeAddressFields, "Telephone");
            Browser.getDynamicElement(ConsigneeAddressFields, "Address 1");
            Browser.getDynamicElement(ConsigneeAddressFields, "Address 2");
            Browser.getDynamicElement(ConsigneeAddressFields, "City");
            Browser.getDynamicElement(ConsigneeAddressFields, "State");
            Browser.getDynamicElement(ConsigneeAddressFields, "Zip Code");

            Browser.getDynamicElement(buttoncommonfield, "Cancel");
            Browser.getDynamicElement(buttoncommonfield, "Save Changes");




        }

        
        
       

        public void RequiresSpecialIndiciaAsYes()
        {
            //Scenario 2A: Programs Comman Settings Parameters when user selects "Requires Special Indicia as Yes"
            indicaRequired.Click();
            Thread.Sleep(1000);
            if (noRadioButton.Displayed && yesRadioButton.Displayed && countrydropdown.Displayed)
            {
                Console.WriteLine("Then a country dropwon and two <Radio buttons> will be displayed");

                Browser.getDynamicElement(returnAddressfield, "name");
                Browser.getDynamicElement(returnAddressfield, "company");
                Browser.getDynamicElement(returnAddressfield, "telephone");
                Browser.getDynamicElement(returnAddressfield, "returnAddress1");
                Browser.getDynamicElement(returnAddressfield, "returnAddress2");
                Browser.getDynamicElement(returnAddressfield, "returnAddressCity");
                Browser.getDynamicElement(returnAddressfield, "returnAddressState");
                Browser.getDynamicElement(returnAddressfield, "returnAddressZipCode");
                Browser.getDynamicElement(returnAddressfield, "returnAddressCountry");
             
            }

           }


        public void UpdateProgramSetting()
        {
            Browser.getDynamicElement(programinputfield, "programName").SendKeys("_Updated");
            Browser.getDynamicElement(buttoncommonfield, "Save Changes").Click();
            validatePopupMessage("programs updated ");

        }

        
            private void validatePopupMessage(string message)
            {
                Browser.WaitForElement(sucessmessage, 10);
                var UpdateSuccessMessage = sucessmessage.Text;
                Thread.Sleep(2000);
                var id = Browser.getDynamicElement(tableCellPath, "0", "1").Text;
                string idvalue = id.Replace(",", "");
                string expectedMessage = string.Format(message, idvalue);
                Assert.That(UpdateSuccessMessage, Does.Contain(expectedMessage));
            }
        





    }

   }


     
          
   