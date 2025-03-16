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
using NPOI.SS.Formula.Functions;
using NUnit.Framework;
using OpenQA.Selenium;
using RandomString4Net;
using SeleniumExtras.PageObjects;
using static OpenQA.Selenium.BiDi.Modules.BrowsingContext.Locator;

namespace ArrowEye_Automation_Portal.PageRepository

{

    public class CS_Hot_StampsPage : TestBase
    {
        public static string PclDynamic = "//td[contains(.,'{0}')]";

        public static string clientGallery = "//p[contains(.,'{0}')]";

        public static string clientGallerySubMenuItem = "//li[@data-testid='subMenuItems']//p[contains(text(),'{0}')]";

        public static string clientGalleryMenuItem = "//li[@data-testid='nestedMenuItem']//p[contains(text(),'{0}')]";

        public static string hotStampsfield = "//div[(text()='{0}')]";

        public static string bcssConfigurationsMultilinefield = "//div/span[(text()='{0}']";

        public static string addNewButton = "//p[contains(text(),'{0}')]";

        public static string popupheaderText = "//p[text()='{0}']";

        public static string popupbtn = "//button[text()='{0}']";

        public static string inputfield = "//label[text()='{0}']/following-sibling::div/input";

        private string tableCellPath = "//div[@data-rowindex='{0}']/div[@data-colindex='{1}']";

        private string nameSizeLimitPath = "//label[text()='{0}']/following-sibling::p";

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


        public void NavigateToHotStampPage()
        {
            DriverUtilities.Click(SearchOrSelect);
            Browser.ClickDynamicElement(PclDynamic, "9005: Pier One");
            Browser.ClickDynamicElement(clientGallery, "CLIENT GALLERY");
            Browser.ClickDynamicElement(clientGalleryMenuItem, "Client Settings");
            Browser.ClickDynamicElement(clientGallerySubMenuItem, "Hot Stamps");

        }

        //TODO: name field value already exists
        //TODO: Scenario 1B: When character are more than 200 in Description field
        public void AddNewHotStampsRecord(string Text)
        {
            ValidateHotStampsField();

            //create new  BCSS record
            Browser.ClickDynamicElement(addNewButton, "Add New");

            //validate pop up
            validatePopupDetails("New Hot Stamp");

            Browser.getDynamicElement(inputfield, "Name").SendKeys(Text);
            Browser.getDynamicElement(inputfield, "Description").SendKeys(Text);
            Browser.ClickDynamicElement(popupbtn, "Save");
            Thread.Sleep(2000);

            //Validations
            HotStampRecord record = new HotStampRecord()
            {
                Name = Text,
                Description = Text,
                
            };
            validatePopupMessage("Hot Stamp {0} Added Successfully.");
            validateRecord(record);
        }

        public void EditHotStampsRecord(string UpdateText)
        {
            //adding new record
            this.AddNewHotStampsRecord(UpdateText);
            Thread.Sleep(3000);

            //click on Edit icon and verify the popup details and go for Edit
            Browser.Click(Edit_Icon_button);
            Thread.Sleep(2000);

            //validate pop up
            validatePopupDetails("Edit Hot Stamp");

            //update
            Browser.getDynamicElement(inputfield, "Name").SendKeys("_Updated");
            Browser.getDynamicElement(inputfield, "Description").SendKeys("_Updated");
           

            //save
            Browser.Click(Browser.getDynamicElement(popupbtn, "Save"));

            //Validations
            HotStampRecord record = new HotStampRecord()
            {
                Name = UpdateText + "_Updated",
                Description = UpdateText + "_Updated",

               };
            validatePopupMessage("Hot Stamp {0} Updated Successfully.");
            Thread.Sleep(2000);
            validateRecord(record);
        }

        

        public void ValidateHotStampsFields()
        {
            ValidateHotStampsField();

            
            Browser.ClickDynamicElement(addNewButton, "Add New");
            Browser.ClickDynamicElement(popupbtn, "Save");
            Thread.Sleep(500);
            WebElement NameFieldErrorValue = Browser.getDynamicElement(errormessage, "The Name field is required.");
            var NameErrorText = NameFieldErrorValue.GetText();
            Assert.That(NameErrorText, Does.Contain("The Name field is required."));

            WebElement descriptionSizeLimitMsg = Browser.getDynamicElement(nameSizeLimitPath, "Description");
            string longString = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 555);
            Browser.getDynamicElement(inputfield, "Description").SendKeys(longString);
            Assert.That(descriptionSizeLimitMsg.Text, Is.EqualTo("500/500"));



        }

        public void ExportHotStampsRecord()
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

        private void ValidateHotStampsField()
        {
            WebElement hotStampsfieldIDELe = Browser.getDynamicElement(hotStampsfield, "ID");
            WebElement hotStampsfieldNameEle = Browser.getDynamicElement(hotStampsfield, "Name");
            WebElement hotStampsfieldDescriptionELe = Browser.getDynamicElement(hotStampsfield, "Description");
            WebElement hotStampsfieldPartNumberEle = Browser.getDynamicElement(hotStampsfield, "Part Number");
            
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
            var HotStampMessage = sucessmessage.Text;
            Thread.Sleep(2000);
            var id = Browser.getDynamicElement(tableCellPath, "0", "1").Text;
            string idvalue = id.Replace(",", "");
            string expectedMessage = String.Format(message, idvalue);
            Assert.That(HotStampMessage, Does.Contain(expectedMessage));
        }

        private void validateRecord(HotStampRecord record)
        {
            Assert.That(record.Name, Does.Contain(Browser.getDynamicElement(tableCellPath, "0", "2").Text));
            Assert.That(record.Description, Does.Contain(Browser.getDynamicElement(tableCellPath, "0", "3").Text));
           
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
