﻿using System;
using System.IO;
using System.Threading;
using ArrowEye_Automation_Framework;
using ArrowEye_Automation_Framework.Common;
using ArrowEye_Automation_Portal.PageRepository.Objects;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace ArrowEye_Automation_Portal.PageRepository

{
    public class CS_BCSS_ConfigurationPage : TestBase
    {
        public static string PclDynamic = "//td[contains(.,'{0}')]";

        public static string clientGallery = "//p[contains(.,'{0}')]";

        public static string clientGallerySubMenuItem = "//li[@data-testid='subMenuItems']//p[contains(text(),'{0}')]";

        public static string clientGalleryMenuItem = "//li[@data-testid='nestedMenuItem']//p[contains(text(),'{0}')]";

        public static string bcssConfigurationsfield = "//div[(text()='{0}']";

        public static string bcssConfigurationsMultilinefield = "//div/span[(text()='{0}']";

        public static string addNewButton = "//p[contains(text(),'{0}')]";

        public static string popupheaderText = "//p[text()='{0}']";

        public static string popupbtn = "//button[text()='{0}']";

        public static string inputfield = "//label[text()='{0}']/following-sibling::div/input";

        private string tableCellPath = "//div[@data-rowindex='{0}']/div[@data-colindex='{1}']";

        public static string errormessage = "//p[text()='{0}']";

        public static string errormessage1 = "//p[text()=\"{0}\"]";

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Search or Select')]")]
        public IWebElement SearchOrSelect;

        [FindsBy(How = How.XPath, Using = "//div[@id='notistack-snackbar']")]
        private IWebElement sucessmessage;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search…']")]
        private IWebElement AutoSearch_textbox;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='2'])[position()=1]")]
        private IWebElement BCSSRecord_created;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Edit']")]
        private IWebElement Edit_Icon_button;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Delete']")]
        private IWebElement Delete_Icon_button;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Export']")]
        private IWebElement exportButton;

        [FindsBy(How = How.XPath, Using = "//li[text()='Download as CSV']")]
        private IWebElement downloadCSVFile;

        [FindsBy(How = How.XPath, Using = "//td[@data-testid='table-pagination']//p[2]")]
        private IWebElement rowsCount;      

        public void NavigateToBCSSConfigurations(string pclID = "9005: Pier One")
        {
            DriverUtilities.Click(SearchOrSelect);
            Browser.ClickDynamicElement(PclDynamic, pclID);
            Browser.ClickDynamicElement(clientGallery, "CLIENT GALLERY");
            Browser.ClickDynamicElement(clientGalleryMenuItem, "Client Settings");
            Browser.ClickDynamicElement(clientGallerySubMenuItem, "BCSS Configurations");
        }

        //TODO: name field value already exists
        //TODO: Scenario 1B: When character are more than 200 in Description field
        public void AddNewBCSSRecord(string Text)
        {
            //ValidateBCSSConfigurationsField();

            //create new  BCSS record
            Browser.ClickDynamicElement(addNewButton, "Add New");

            //validate pop up
            validatePopupDetails("New BCSS Configuration");

            Browser.getDynamicElement(inputfield, "Name").SendKeys(Text);
            Browser.getDynamicElement(inputfield, "Description").SendKeys(Text);
            Browser.getDynamicElement(inputfield, "Profile Name").SendKeys(Text);
            Browser.ClickDynamicElement(popupbtn, "Save");
            Thread.Sleep(2000);

            //Validations
            BcssConfigurationRecord record = new BcssConfigurationRecord()
            {
                Name = Text,
                Description = Text,
                ProfileName = Text
            };
            validatePopupMessage("BCSS Configuration {0} Added Successfully.");
            validateRecord(record);
        }

        public void EditBCSSRecord(string UpdateBCSSText)
        {
            //adding new record
            this.AddNewBCSSRecord(UpdateBCSSText);
            Thread.Sleep(3000);

            //click on Edit icon and verify the popup details and go for Edit
            Browser.Click(Edit_Icon_button);
            Thread.Sleep(2000);

            //validate pop up
            validatePopupDetails("Edit BCSS Configuration");

            //update
            Browser.getDynamicElement(inputfield, "Name").SendKeys("_Updated");
            Browser.getDynamicElement(inputfield, "Description").SendKeys("_Updated");
            Browser.getDynamicElement(inputfield, "Profile Name").SendKeys("_Updated");

            //save
            Browser.Click(Browser.getDynamicElement(popupbtn, "Save"));

            //Validations
            BcssConfigurationRecord record = new BcssConfigurationRecord()
            {
                Name = UpdateBCSSText + "_Updated",
                Description = UpdateBCSSText + "_Updated",
                ProfileName = UpdateBCSSText + "_Updated"
            };
            validatePopupMessage("BCSS Configuration {0} Updated Successfully.");
            Thread.Sleep(2000);
            validateRecord(record);
        }

        public void DeleteBCSSRecord(string UpdateBCSSText)
        {
            //adding new record
            this.AddNewBCSSRecord(UpdateBCSSText);
            Thread.Sleep(2000);
            var id = Browser.getDynamicElement(tableCellPath,"0","1").Text;
            Browser.Click(Delete_Icon_button);
            Browser.ClickDynamicElement(popupheaderText, "Delete");
            Browser.WaitForElement(sucessmessage, 10);
            var BCSSUpdatesuccessmessage = sucessmessage.Text;
            
            string idvalue = id.Replace(",", "");
            Assert.That(BCSSUpdatesuccessmessage, Does.Contain("BCSS Configuration " + idvalue + " Deleted Successfully."));
        }

        public void ValidateBCSSConfigurationField()
        {
            ValidateBCSSConfigurationsField();

            //create new BCSS record
            Browser.ClickDynamicElement(addNewButton, "Add New");
            Browser.ClickDynamicElement(popupbtn, "Save");
            Thread.Sleep(500);
            WebElement NameFieldErrorValue = Browser.getDynamicElement(errormessage, "Name is required.");
            var NameErrorText = NameFieldErrorValue.GetText();

            WebElement DescriptionErrorValue = Browser.getDynamicElement(errormessage, "Description is required.");
            var DescriptionErrorText = DescriptionErrorValue.GetText();

            WebElement ProfileNameErrorValue = Browser.getDynamicElement(errormessage, "Profile Name is required.");
            var ProfileNameErrorText = ProfileNameErrorValue.GetText();
            
            string dynamicMessage = "PVKI Code can't be more than 32767.";
            WebElement PVKIFieldEle = Browser.getDynamicElement(inputfield, "PVKI Code");
            PVKIFieldEle.SendKeys("45673");   
            var PVKIvalue = PVKIFieldEle.GetDomAttribute("value");
            ValidateIntegerValue(PVKIvalue, dynamicMessage);

            string dynamicMessage1 = "CVK Type can't be more than 32767.";
            WebElement CVKFieldEle = Browser.getDynamicElement(inputfield, "CVK Type");
            CVKFieldEle.SendKeys("45673");
            var cvkvalue = CVKFieldEle.GetDomAttribute("value");
            ValidateIntegerValue(cvkvalue, dynamicMessage1);

            Assert.That(NameErrorText, Does.Contain("Name is required."));
            Assert.That(DescriptionErrorText, Does.Contain("Description is required."));
            Assert.That(ProfileNameErrorText, Does.Contain("Profile Name is required."));
        }

        public void ExportBCSSConfigurationRecord()
        {
            DriverUtilities.Click(exportButton);
            Thread.Sleep(1000);
            Browser.Click(downloadCSVFile);
            Thread.Sleep(3000);
            string[] csvFiles = Directory.GetFiles(Browser.downloadsFolderPath, "*.csv");
            if (csvFiles.Length == 0)
            {
                throw new Exception("No CSV files found in the directory.");
            }
            else
            {
                string rowsCountText = rowsCount.GetText();
                string[] parts = rowsCountText.Split(new string[] { " of " }, StringSplitOptions.None);
                string totalCount = parts[1].Trim();
                string csvRowCount = CountRowsInCsv(csvFiles[0]).ToString();
                Assert.That(totalCount, Is.EqualTo(csvRowCount), "Total count in CSV does not match with total count on web page");
            }
        }

        private void ValidateBCSSConfigurationsField()
        {
            WebElement bcssConfigurationsIDELe = Browser.getDynamicElement(bcssConfigurationsfield, "ID");
            WebElement bcssConfigurationsNameEle = Browser.getDynamicElement(bcssConfigurationsfield, "Name");
            WebElement bcssConfigurationsDescriptionELe = Browser.getDynamicElement(bcssConfigurationsfield, "Description");
            WebElement pbcssConfigurationsProfileNameEle = Browser.getDynamicElement(bcssConfigurationsfield, "Profile Name");
            WebElement bcssConfigurationsCVVDateFormatEle = Browser.getDynamicElement(bcssConfigurationsfield, "CVV Date Format");
            WebElement bcssConfigurationsCVV2DateFormatEle = Browser.getDynamicElement(bcssConfigurationsfield, "CVV2 Date Format");
            WebElement bcssConfigurationsCVVkeypairEle = Browser.getDynamicElement(bcssConfigurationsfield, "CVV key pair");
            WebElement bcssConfigurationsCVV2keypairEle = Browser.getDynamicElement(bcssConfigurationsfield, "CVV2 key pair");
            WebElement bcssConfigurationsServicecodeEle = Browser.getDynamicElement(bcssConfigurationsfield, "Service Code");
            WebElement bcssConfigurationsServicecodeCVVLine1Ele = Browser.getDynamicElement(bcssConfigurationsMultilinefield, "User service");
            WebElement bcssConfigurationsServicecodeCVVLine2Ele = Browser.getDynamicElement(bcssConfigurationsMultilinefield, " code CVV");
            WebElement bcssConfigurationsServicecodeCVV2Line1Ele = Browser.getDynamicElement(bcssConfigurationsMultilinefield, "User service");
            WebElement bcssConfigurationsServicecodeCVV2Line2Ele = Browser.getDynamicElement(bcssConfigurationsMultilinefield, " code CVV2");
            WebElement bcssConfigurationsPVKICodeEle = Browser.getDynamicElement(bcssConfigurationsfield, "PVKI code");
            WebElement bcssConfigurationsCVKTypeEle = Browser.getDynamicElement(bcssConfigurationsfield, "CVK type");
            //validation

            //Browser.isElementPresent(bcssConfigurationsIDELe);
            //Browser.isElementPresent(bcssConfigurationsNameEle);
            //Browser.isElementPresent(bcssConfigurationsDescriptionELe);
            //Browser.isElementPresent(pbcssConfigurationsProfileNameEle);
            //Browser.isElementPresent(bcssConfigurationsCVVDateFormatEle);
            //Browser.isElementPresent(bcssConfigurationsCVV2DateFormatEle);
            //Browser.isElementPresent(bcssConfigurationsCVVkeypairEle);
            //Browser.isElementPresent(bcssConfigurationsCVV2keypairEle);
        }

        private void ValidateIntegerValue(string value, string message)
        {
            if (int.TryParse(value, out int result))
            {
                if (result > 32767)
                {
                    WebElement ErrorEle = Browser.getDynamicElement(errormessage1, message);
                    var ErrorText = ErrorEle.GetText();
                    Assert.That(ErrorText, Does.Contain(message));
                }
            }
            else
            {
                throw new Exception("The entered value is not a valid number.");
            }
        }

        private void validatePopupDetails(String headerMessage)
        {
            WebElement headerEle = Browser.getDynamicElement(popupheaderText, headerMessage);
            WebElement cancelEle = Browser.getDynamicElement(popupbtn, "Cancel");
            WebElement saveEle = Browser.getDynamicElement(popupbtn, "Save");

            Assert.That(headerEle.Text, Is.EqualTo(headerMessage));
            Assert.That(cancelEle.Text, Is.EqualTo("CANCEL"));
            Assert.That(saveEle.Text, Is.EqualTo("SAVE"));
        }

        private void validatePopupMessage(String message)
        {
            Browser.WaitForElement(sucessmessage, 10);
            var BCSSUpdateSuccessMessage = sucessmessage.Text;
            Thread.Sleep(2000);
            var id = Browser.getDynamicElement(tableCellPath, "0", "1").Text;
            string idvalue = id.Replace(",", "");
            string expectedMessage = String.Format(message, idvalue);
            Assert.That(BCSSUpdateSuccessMessage, Does.Contain(expectedMessage));
        }

        private void validateRecord(BcssConfigurationRecord record)
        {
            Assert.That(record.Name, Does.Contain(Browser.getDynamicElement(tableCellPath, "0", "2").Text));
            Assert.That(record.Description, Does.Contain(Browser.getDynamicElement(tableCellPath, "0", "3").Text));
            Assert.That(record.ProfileName, Does.Contain(Browser.getDynamicElement(tableCellPath, "0", "4").Text));
        }       

        private int CountRowsInCsv(string filePath)
        {
            int rowCount = 0;
            try
            {
                // Read the CSV file line by line
                using (var reader = new StreamReader(filePath))
                {
                    // Skip the first line (header)
                    if (!reader.EndOfStream)
                    {
                        reader.ReadLine();  // This skips the header line
                    }

                    // Count the remaining rows
                    while (reader.ReadLine() != null)
                    {
                        rowCount++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading the file '{filePath}': {ex.Message}");
            }
            return rowCount;
        }


    }
}
