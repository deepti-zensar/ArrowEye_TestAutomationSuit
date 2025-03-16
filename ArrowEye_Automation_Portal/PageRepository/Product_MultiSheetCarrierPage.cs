using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using ArrowEye_Automation_Framework;
using ArrowEye_Automation_Framework.Common;
using ArrowEye_Automation_Portal.PageRepository.Objects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RandomString4Net;
using SeleniumExtras.PageObjects;

namespace ArrowEye_Automation_Portal.PageRepository

{

    public class Product_MultiSheetCarrierPage : TestBase
    {

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Search or Select')]")]
        public IWebElement SearchOrSelect;

        public static string PclDynamic = "//td[contains(.,'{0}')]";

        public static string clientGallery = "//p[contains(.,'{0}')]";

        public static string clientGallerySubMenuItem = "//li[@data-testid='subMenuItems']//p[contains(text(),'{0}')]";

        public static string clientGalleryMenuItem = "//li[@data-testid='nestedMenuItem']//p[contains(text(),'{0}')]";

        public static string printsettingsfield = "//div[text()='{0}']";

        public static string addNewButton = "//p[contains(text(),'{0}')]";


        public static string popupheaderText = "//p[text()='{0}']";

        public static string addbtn = "//button[text()='{0}']";

        public static string inputfield = "//input[@name='{0}']";

        public static string carriertitle = "//input[@data-testid='{0}']";

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='dropInput']")]
        public IWebElement fileUpload;

        [FindsBy(How = How.XPath, Using = "(//td[@class='MuiTableCell-root MuiTableCell-body MuiTableCell-sizeMedium jss6 css-q34dxg'])[position()=15]")]
         public IWebElement AmazonPCL;

        [FindsBy(How = How.XPath, Using = "//input[@name='forConsumerOrder']")]
        public IWebElement consumersiteinput;

        [FindsBy(How = How.XPath, Using = "//input[@name='isEnabled' and @value='1']")]
        public IWebElement turnedoninput;

        [FindsBy(How = How.XPath, Using = "//input[@name='isEnabled' and @value='0']")]
        public IWebElement turnedoffinput;


        [FindsBy(How = How.XPath, Using = "//input[@name='plasticAffixLocation' and @value='R2']")]
        public IWebElement setaffixlocationinput;

        private string searchInput = "(//div[@aria-rowindex='{0}']//input)[{0}]";

        private string tableCellPath = "//div[@data-rowindex='{0}']/div[@data-colindex='{1}']";

        [FindsBy(How = How.XPath, Using = "//input[@role='combobox']")]
        public IWebElement dropdowninput;

        [FindsBy(How = How.XPath, Using = " //input[@id='Client product map ID']")]
        public IWebElement clientproductmapidinput;

        [FindsBy(How = How.XPath, Using = "//button[strong[text()='Submit']]")]
        public IWebElement submitbtn;

        [FindsBy(How = How.XPath, Using = "//div[@id='notistack-snackbar']")]
        private IWebElement sucessmessage;

        [FindsBy(How = How.XPath, Using = "(//p[@class='MuiTypography-root MuiTypography-body2 css-let8z9'])[1]")]
        private IWebElement recordeditem;

        [FindsBy(How = How.XPath, Using = "//*[@data-testid='InfoOutlinedIcon']")]
        public IWebElement infoIcon;

        [FindsBy(How = How.XPath, Using = "//div[@role='tooltip']/div")]
        public IWebElement infoIconText;

        [FindsBy(How = How.XPath, Using = "//div[@data-testid='uploading']")]
        public IWebElement uploadingStatus;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='Remove']")]
        public IWebElement removePDFButton;

        [FindsBy(How = How.XPath, Using = "(//span[strong[text()='EDIT']])[1]")]
        public IWebElement editbtn;

        [FindsBy(How = How.XPath, Using = "//*[@data-testid='addEditComponent']/p")]
        private IWebElement editCarrierLabel;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search..']")]
        public IWebElement Searchitem;


        [FindsBy(How = How.XPath, Using = "//button[strong[text()='Delete']]")]
        public IWebElement deleteitem;

        [FindsBy(How = How.XPath, Using = "//p[text()='Delete']")]
        public IWebElement deleteBoxDeleteBtn;

        [FindsBy(How = How.XPath, Using = "//div[@role='dialog']//h2")]
        private IWebElement deleteBoxLabel;


        private string fieldLabelele = "//label[text()='{0}']/following-sibling::p";

       


        public void NavigateToMultiSheetLetterCarrierPage()
        {
            Thread.Sleep(3000);
            DriverUtilities.Click(SearchOrSelect);
            Thread.Sleep(1000);
           // DriverUtilities.Click(AmazonPCL);
            Browser.ClickDynamicElement(PclDynamic, "9006: Pier 2");

            Browser.ClickDynamicElement(clientGallery, "CLIENT GALLERY");
            Browser.ClickDynamicElement(clientGalleryMenuItem, "Products");
            Browser.ClickDynamicElement(clientGallerySubMenuItem, "Multi Sheet Letter Carriers");
           


        }



        public void AddNewMultiSheetLettersCarriers(string Text)
        {
            Thread.Sleep(1000);
            Browser.ClickDynamicElement(addbtn, "Add New");
            Thread.Sleep(2000);
            Assert.That(infoIcon.Displayed, Is.True);
            Browser.Click(infoIcon);
            Browser.WaitForElement(infoIconText, 2);
            Assert.That(infoIconText.Text, Is.EqualTo("Only upload PDF file."));
            //Upload PDF
            fileUpload.SendKeys(@"C:\Users\PJain\Downloads\MultiSheetCarriersDemoFile.pdf");

            //Validate uploading status

            Browser.WaitForElement(uploadingStatus, 10);
            Assert.That(uploadingStatus.Displayed, Is.True);

            //Remove PDF and reupload
            Browser.WaitForElement(removePDFButton, 20);
            Browser.Click(removePDFButton);
            Thread.Sleep(2000);
            fileUpload.SendKeys(@"C:\Users\PJain\Downloads\MultiSheetCarriersDemoFile.pdf");
            Browser.WaitForElement(removePDFButton, 20);
            Browser.getDynamicElement(inputfield, "title").SendKeys(Text);
            Browser.getDynamicElement(inputfield, "description").SendKeys("automationtesting");
            ToggleCheckbox(consumersiteinput, true);
            DriverUtilities.Click(turnedoffinput);
            DriverUtilities.Click(setaffixlocationinput);
            Browser.SelectAllDropdowns();
            clientproductmapidinput.SendKeys("67890");
            Thread.Sleep(5000);
            submitbtn.Click();
            //validatePopupMessage("Multi Sheet Letter Carrier {0} Added Successfully.");


        }
        public void EditMultiSheetLettersCarriers(string Text)
        {
            AddNewMultiSheetLettersCarriers(Text);
            Browser.Click(editbtn);
            Browser.WaitForElement(editCarrierLabel, 10);
            Browser.Click(removePDFButton);
            Thread.Sleep(2000);
            fileUpload.SendKeys(@"C:\Users\PJain\Downloads\MultiSheetCarriersDemoFile.pdf");
            Browser.WaitForElement(removePDFButton, 20);
            //Remove PDF and reupload
            Browser.Click(removePDFButton);
            Thread.Sleep(2000);
            fileUpload.SendKeys(@"C:\Users\PJain\Downloads\MultiSheetCarriersDemoFile.pdf");
            Browser.WaitForElement(removePDFButton, 20);
            Thread.Sleep(1000);
            Browser.getDynamicElement(carriertitle, "Carriertitle").SendKeys("updated");
            Thread.Sleep(1000);
            Browser.getDynamicElement(inputfield, "description").SendKeys("updated");
            Browser.SelectAllDropdowns();
           
            clientproductmapidinput.SendKeys("344555");
            Thread.Sleep(5000);
            submitbtn.Click();
            validatePopupMessage("Multi Sheet Letter Carrier {0} Updated Successfully.");

        }

        public void DeleteMultiSheetLettersCarriers(string Text)
        {
            AddNewMultiSheetLettersCarriers(Text);
            Thread.Sleep(3000);
          //  var id = recordeditem.Text;
            Searchitem.SendKeys(Text);
            Browser.Click(editbtn);
            Browser.Click(deleteitem);
            Thread.Sleep(2000);
            Browser.WaitForElement(deleteBoxLabel, 10);
            Assert.That(deleteBoxLabel.Text, Is.EqualTo("Delete Multi Sheet Letter Carrier"));
            Browser.Click(deleteBoxDeleteBtn);
            //Browser.WaitForElement(sucessmessage, 10);
            //var Updatesuccessmessage = sucessmessage.Text;
       

            //string idvalue = id.Replace(",", "");
            //Assert.That(Updatesuccessmessage, Does.Contain("BCSS Configuration " + idvalue + " Deleted Successfully."));
        }


        public void ValidateMultiSheetLettersCarriers(string Text)
        {
            Thread.Sleep(1000);
            Browser.ClickDynamicElement(addbtn, "Add New");
            submitbtn.Click();
            ValidateMandatoryFields();

        }
        public void ValidateMandatoryFields()
        {


            submitbtn.Click();

            WebElement ErrorValue = Browser.getDynamicElement(fieldLabelele, "Please enter carrier Title.");
            var ErrorText =ErrorValue.GetText();
            Assert.That(ErrorText, Does.Contain("Please enter carrier Title."));

          
            Assert.That(GetValidationMessage("Carrier description"), Is.EqualTo("Please enter carrier Description").IgnoreCase);
            Assert.That(GetValidationMessage("Part of"), Is.EqualTo("Please select if carrier is Part of Consumer or Corporate").IgnoreCase);
            Assert.That(GetValidationMessage("Carrier status"), Is.EqualTo("Please select a Carrier Status").IgnoreCase);
            Assert.That(GetValidationMessage("Set affix location"), Is.EqualTo("Please set an Affix Location").IgnoreCase);
     
        }

        private string GetValidationMessage(string fieldLabel)
        {
            try
            {
                return fieldLabelele;

            }
            catch (NoSuchElementException)
            {
                return string.Empty;
            }
        }







        public void ToggleCheckbox(IWebElement checkbox, bool check)
        {
            if (checkbox.Selected != check)
            {
                checkbox.Click();
            }
        }

        private void validatePopupMessage(String message)
        {
            Browser.WaitForElement(sucessmessage, 20);
            var UpdateSuccessMessage = sucessmessage.Text;
            Thread.Sleep(5000);

            var id = recordeditem.Text;
            string idvalue = id.Replace(",", "");
            string expectedMessage = String.Format(message, idvalue);
            Assert.That(UpdateSuccessMessage, Does.Contain(expectedMessage));
        }










    }
}