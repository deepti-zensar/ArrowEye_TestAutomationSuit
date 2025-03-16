using System;
using System.IO;
using System.Linq;
using System.Threading;
using ArrowEye_Automation_Framework;
using ArrowEye_Automation_Framework.Common;
using ArrowEye_Automation_Portal.PageRepository.Objects;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace ArrowEye_Automation_Portal.PageRepository

{
    //TODO: Scenario 1B: When character are more than 100 in Name field
    //TODO: Scenario 3B: When character are more than 50 in ICA field
    //TODO: Scenario 4B: When character are more than 500 in Contact Name field
    //TODO:Scenario 5B: When character are more than 200 in Contact email field

    public class CS_IssuingBankPage : TestBase
    {
        public static string PclDynamic = "//td[contains(.,'{0}')]";

        public static string clientGallery = "//p[contains(.,'{0}')]";

        public static string clientGallerySubMenuItem = "//li[@data-testid='subMenuItems']//p[contains(text(),'{0}')]";

        public static string clientGalleryMenuItem = "//li[@data-testid='nestedMenuItem']//p[contains(text(),'{0}')]";

        public static string issuingBankfield = "//div[(text()='{0}')]";

        public static string ship_Typesfield = "//div/span[(text()='{0}')]";

        public static string addNewButton = "//p[contains(text(),'{0}')]";

        public static string popupheaderText = "//p[text()='{0}']";

        public static string popupbtn = "//button[text()='{0}']";

        public static string inputfield = "//label[text()='{0}']/following-sibling::div/input";

        private string tableCellPath = "//div[@data-rowindex='{0}']/div[@data-colindex='{1}']";

        public static string errormessage = "//p[text()='{0}']";

        public static string errormessage1 = "//p[text()=\"{0}\"]";

        private string dropDown = "(//li[text()='{0}'])[1]";

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


        public void NavigateToIssuingBank()
        {
            DriverUtilities.Click(SearchOrSelect);
            Browser.ClickDynamicElement(PclDynamic, "9005: Pier One");
            Browser.ClickDynamicElement(clientGallery, "CLIENT GALLERY");
            Browser.ClickDynamicElement(clientGalleryMenuItem, "Client Settings");
            Browser.ClickDynamicElement(clientGallerySubMenuItem, "Issuing Bank");

        }

        
        public void AddNewIssuingBankRecord(string Text,string Country)
        {
            ValidateIssuingBankField();

            //create new  BCSS record
            Browser.ClickDynamicElement(addNewButton, "Add New");

            //validate pop up
            validatePopupDetails("New Issuing Bank");

            Browser.getDynamicElement(inputfield, "Name").SendKeys(Text);
            Browser.getDynamicElement(inputfield, "ICA").SendKeys(Text);
            Browser.getDynamicElement(inputfield, "Contact Email").SendKeys("abc@zensar.com");
            Browser.getDynamicElement(inputfield, "Contact Name").SendKeys(Text);
            Browser.getDynamicElement(inputfield, "Contact Phone").SendKeys("1234567");
            Browser.getDynamicElement(inputfield, "Country").SendKeys(Country);
            Browser.getDynamicElement(dropDown, Country).Click();
            Browser.getDynamicElement(inputfield, "Region").SendKeys("East");
            Browser.getDynamicElement(dropDown, "East").Click();

            Browser.ClickDynamicElement(popupbtn, "Save");
            Thread.Sleep(2000);

            //Validations
            IssuingBankRecord record = new IssuingBankRecord()
            {
                Name = Text,
                ICA = Text,
                ContactEmail = "abc@zensar.com",
                ContactName = Text,
                ContactPhone = "1234567",
                Country = Country,
                Region = "East"
            };
            validatePopupMessage("Issuing Bank {0} Added Successfully.");
            validateRecord(record);
        }

        public void EditIssuingBanksRecord(string updateText, string Country)
        {
            //adding new record
            this.AddNewIssuingBankRecord(updateText, Country);
            Thread.Sleep(3000);

            //click on Edit icon and verify the popup details and go for Edit
            Browser.Click(Edit_Icon_button);
            Thread.Sleep(2000);

            //validate pop up
            validatePopupDetails("Edit Issuing Bank");

            //update
            Browser.getDynamicElement(inputfield, "Name").SendKeys("_Updated");
            Browser.getDynamicElement(inputfield, "ICA").SendKeys("_Updated");

            WebElement valueEle = Browser.getDynamicElement(inputfield, "Contact Email");
            DriverUtilities.clearText(valueEle);
            Browser.getDynamicElement(inputfield, "Contact Email").SendKeys("xyz@zensar.com");

            Browser.getDynamicElement(inputfield, "Contact Name").SendKeys("_Updated");

            WebElement valueEle1 = Browser.getDynamicElement(inputfield, "Contact Phone");
            DriverUtilities.clearText(valueEle1);
            Browser.getDynamicElement(inputfield, "Contact Phone").SendKeys("5678412");

            WebElement valueCountryEle = Browser.getDynamicElement(inputfield, "Country");
            DriverUtilities.clearText(valueCountryEle);
            Thread.Sleep(1000);
            Browser.getDynamicElement(inputfield, "Country").SendKeys(Country);
            Browser.getDynamicElement(dropDown, Country).Click();

            WebElement valueRegionEle = Browser.getDynamicElement(inputfield, "Region");
            DriverUtilities.clearText(valueRegionEle);
            Browser.getDynamicElement(inputfield, "Region").SendKeys("East");
            Browser.getDynamicElement(dropDown, "East").Click();

            //save
            Browser.Click(Browser.getDynamicElement(popupbtn, "Save"));

            //Validations
            IssuingBankRecord record = new IssuingBankRecord()
            {
                Name = updateText + "_Updated",
                ICA = updateText + "_Updated",
                ContactEmail = "xyz@zensar.com",
                ContactName = updateText + "_Updated",
                ContactPhone = "5678412",
                Country = Country,
                Region = "East"
            };
            validatePopupMessage("Issuing Bank {0} Updated Successfully.");
            Thread.Sleep(2000);
            validateRecord(record);
        }

        

        public void ValidateIssuingBankFields()
        {
            ValidateIssuingBankField();

            //create new BCSS record
            Browser.ClickDynamicElement(addNewButton, "Add New");
            Browser.ClickDynamicElement(popupbtn, "Save");
            Thread.Sleep(500);
            WebElement NameErrorValue = Browser.getDynamicElement(errormessage, "Name is required.");
            var NameErrorText = NameErrorValue.GetText();

            WebElement ICAErrorValue = Browser.getDynamicElement(errormessage, "ICA is required.");
            var ICAErrorText = ICAErrorValue.GetText();

            WebElement ContactEmailErrorValue = Browser.getDynamicElement(errormessage, "Contact email is required.");
            var ContactEmailErrorText = ContactEmailErrorValue.GetText();

            WebElement ContactNameErrorValue = Browser.getDynamicElement(errormessage, "Contact name is required.");
            var ContactNameErrorText = ContactNameErrorValue.GetText();

            WebElement ContactPhoneErrorValue = Browser.getDynamicElement(errormessage, "Contact number is required.");
            var ContactPhoneErrorText = ContactPhoneErrorValue.GetText();

            WebElement CountryErrorValue = Browser.getDynamicElement(errormessage, "Country is required.");
            var CountryErrorText = CountryErrorValue.GetText();


            WebElement RegionErrorValue = Browser.getDynamicElement(errormessage, "Region is required.");
            var RegionErrorText = RegionErrorValue.GetText();

            Assert.That(NameErrorText, Does.Contain("Name is required."));
            Assert.That(ICAErrorText, Does.Contain("ICA is required."));
            Assert.That(ContactEmailErrorText, Does.Contain("Contact email is required."));
            Assert.That(ContactNameErrorText, Does.Contain("Contact name is required."));
            Assert.That(ContactPhoneErrorText, Does.Contain("Contact number is required."));
            Assert.That(CountryErrorText, Does.Contain("Country is required."));
            Assert.That(RegionErrorText, Does.Contain("Region is required."));

            string dynamicMessage = "Contact number must not be less than 7 characters";
            WebElement ContactPhoneEle = Browser.getDynamicElement(inputfield, "Contact Phone");
            ContactPhoneEle.SendKeys("12345");
            var ContactPhoneValue = ContactPhoneEle.GetDomAttribute("value");
            ValidateIntegerValue(ContactPhoneValue, dynamicMessage);

            DriverUtilities.clearText(ContactPhoneEle);
            string dynamicMessage1 = "Contact number must not exceed 15 characters";
            WebElement ContactPhoneEle1 = Browser.getDynamicElement(inputfield, "Contact Phone");
            ContactPhoneEle1.SendKeys("12345454545454545");
            var ContactPhoneValue1 = ContactPhoneEle1.GetDomAttribute("value");
            ValidateIntegerValue(ContactPhoneValue1, dynamicMessage1);


        }

        public void ExportIssuingBanksRecord()
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

        private void ValidateIssuingBankField()
        {
            WebElement issuingBankIDELe = Browser.getDynamicElement(issuingBankfield, "ID");
            WebElement issuingBankNameEle = Browser.getDynamicElement(issuingBankfield, "Name");
            WebElement issuingBankCountryELe = Browser.getDynamicElement(issuingBankfield, "Country");
            WebElement issuingBankICAEle = Browser.getDynamicElement(issuingBankfield, "ICA");
            WebElement issuingBankContactEle = Browser.getDynamicElement(issuingBankfield, "Contact Name");
            WebElement issuingBankContactPhoneEle = Browser.getDynamicElement(issuingBankfield, "Contact Phone");
            WebElement issuingBankContactEmailEle = Browser.getDynamicElement(issuingBankfield, "Contact Email");
            WebElement issuingBankRegionEle = Browser.getDynamicElement(issuingBankfield, "Region");

        }

        private static bool ValidateIntegerValue(string value, string message)
        {
              string number = string.Concat(value.Where(char.IsDigit));

            // Check if the cleaned phone number has less than 7 digits or more than 15 digits
            if (number.Length < 7 || number.Length > 15)
            {
                WebElement ErrorEle = Browser.getDynamicElement(errormessage1, message);
                var ErrorText = ErrorEle.GetText();
                Assert.That(ErrorText, Does.Contain(message));
                return false; // Invalid phone number length
            }

            return true; // Valid phone number length
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

        private void validateRecord(IssuingBankRecord record)
        {

            Assert.That(record.Name, Does.Contain(Browser.getDynamicElement(tableCellPath, "0", "2").Text));
            Assert.That(record.Country, Does.Contain(Browser.getDynamicElement(tableCellPath, "0", "3").Text));
            Assert.That(record.ICA, Does.Contain(Browser.getDynamicElement(tableCellPath, "0", "4").Text));
            Assert.That(record.ContactName, Does.Contain(Browser.getDynamicElement(tableCellPath, "0", "5").Text));
            Assert.That(record.ContactPhone, Does.Contain(Browser.getDynamicElement(tableCellPath, "0", "6").Text));
            Assert.That(record.ContactEmail, Does.Contain(Browser.getDynamicElement(tableCellPath, "0", "7").Text));
            Assert.That(record.Region, Does.Contain(Browser.getDynamicElement(tableCellPath, "0", "8").Text));
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
