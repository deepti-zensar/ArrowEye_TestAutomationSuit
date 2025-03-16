using System;
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
    //TODO: Scenario 1B: When character are more than 100 in Ship type field
    //TODO: Scenario 1B: When character are more than 100 in Description field

    public class CS_Ship_TypesPage : TestBase
    {
        public static string PclDynamic = "//td[contains(.,'{0}')]";

        public static string clientGallery = "//p[contains(.,'{0}')]";

        public static string clientGallerySubMenuItem = "//li[@data-testid='subMenuItems']//p[contains(text(),'{0}')]";

        public static string clientGalleryMenuItem = "//li[@data-testid='nestedMenuItem']//p[contains(text(),'{0}')]";

        public static string ship_Typefield = "//div[(text()='{0}')]";

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


        public void NavigateToShipTypes()
        {
            DriverUtilities.Click(SearchOrSelect);
            Browser.ClickDynamicElement(PclDynamic, "9005: Pier One");
            Browser.ClickDynamicElement(clientGallery, "CLIENT GALLERY");
            Browser.ClickDynamicElement(clientGalleryMenuItem, "Client Settings");
            Browser.ClickDynamicElement(clientGallerySubMenuItem, "Ship Types");

        }

        
        public void AddNewShipTypesRecord(string Text,string ASIShipType)
        {
            ValidateShipTypesField();

            //create new  BCSS record
            Browser.ClickDynamicElement(addNewButton, "Add New");

            //validate pop up
            validatePopupDetails("New Ship Type");

            Browser.getDynamicElement(inputfield, "Ship Type").SendKeys(Text);
            Browser.getDynamicElement(inputfield, "Description").SendKeys(Text);
            Browser.getDynamicElement(inputfield, "ASI Ship Type").SendKeys(ASIShipType);
            Browser.getDynamicElement(dropDown, ASIShipType).Click();
            Browser.ClickDynamicElement(popupbtn, "Save");
            Thread.Sleep(2000);

            //Validations
            ShipTypesRecord record = new ShipTypesRecord()
            {
                ShipType = Text,
                Description = Text,
                ASIShipType = ASIShipType
            };
            validatePopupMessage("Ship Type {0} Added Successfully.");
            validateRecord(record);
        }

        public void EditShipTypeRecord(string UpdateShipTypeText,string ASIShipType)
        {
            //adding new record
            this.AddNewShipTypesRecord(UpdateShipTypeText, ASIShipType);
            Thread.Sleep(3000);

            //click on Edit icon and verify the popup details and go for Edit
            Browser.Click(Edit_Icon_button);
            Thread.Sleep(2000);

            //validate pop up
            validatePopupDetails("Update Ship Type");

            //update
            Browser.getDynamicElement(inputfield, "Ship Type").SendKeys("_Updated");
            Browser.getDynamicElement(inputfield, "Description").SendKeys("_Updated");

            WebElement valueEle = Browser.getDynamicElement(inputfield, "ASI Ship Type");
            DriverUtilities.clearText(valueEle);
            Browser.getDynamicElement(inputfield, "ASI Ship Type").SendKeys(ASIShipType);
            Browser.getDynamicElement(dropDown, ASIShipType).Click();

            //save
            Browser.Click(Browser.getDynamicElement(popupbtn, "Save"));

            //Validations
            ShipTypesRecord record = new ShipTypesRecord()
            {
                ShipType = UpdateShipTypeText + "_Updated",
                Description = UpdateShipTypeText + "_Updated",
                ASIShipType = ASIShipType
            };
            validatePopupMessage("Ship Type {0} Updated Successfully.");
            Thread.Sleep(2000);
            validateRecord(record);
        }

        public void DeleteShipTypesRecord(string ShipTypeText,string key)
        {
            //adding new record
            this.AddNewShipTypesRecord(ShipTypeText, key);
            Thread.Sleep(2000);
            var id = Browser.getDynamicElement(tableCellPath,"0","1").Text;
            Browser.Click(Delete_Icon_button);
            Browser.ClickDynamicElement(popupheaderText, "Delete");
            Browser.WaitForElement(sucessmessage, 10);
            var BCSSUpdatesuccessmessage = sucessmessage.Text;
            
            string idvalue = id.Replace(",", "");
            Assert.That(BCSSUpdatesuccessmessage, Does.Contain("Ship Type " + idvalue + " Deleted Successfully."));
        }

        public void ValidateShip_TypesField()
        {
            ValidateShipTypesField();

            //create new BCSS record
            Browser.ClickDynamicElement(addNewButton, "Add New");
            Browser.ClickDynamicElement(popupbtn, "Save");
            Thread.Sleep(500);
            WebElement ShipTypeErrorValue = Browser.getDynamicElement(errormessage, "Ship Type is required.");
            var ShipTypeErrorText = ShipTypeErrorValue.GetText();

            WebElement DescriptionErrorValue = Browser.getDynamicElement(errormessage, "Description is required.");
            var DescriptionErrorText = DescriptionErrorValue.GetText();

            WebElement ASIShipErrorValue = Browser.getDynamicElement(errormessage, "ASI Ship Type is required.");
            var ASIShipErrorText = ASIShipErrorValue.GetText();
            
            


            Assert.That(ShipTypeErrorText, Does.Contain("Ship Type is required."));
            Assert.That(DescriptionErrorText, Does.Contain("Description is required."));
            Assert.That(ASIShipErrorText, Does.Contain("ASI Ship Type is required."));
        }

        public void ExportShip_TypesRecord()
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

        private void ValidateShipTypesField()
        {
            WebElement shipTypesIDELe = Browser.getDynamicElement(ship_Typefield, "ID");
            WebElement shipTypesEle = Browser.getDynamicElement(ship_Typefield, "Ship Type");
            WebElement shipTypesDescriptionELe = Browser.getDynamicElement(ship_Typefield, "Description");
            WebElement asishipTypesEle = Browser.getDynamicElement(ship_Typefield, "ASI Ship Type");
            
            
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

        private void validateRecord(ShipTypesRecord record)
        {
            Assert.That(record.ShipType, Does.Contain(Browser.getDynamicElement(tableCellPath, "0", "2").Text));
            Assert.That(record.Description, Does.Contain(Browser.getDynamicElement(tableCellPath, "0", "3").Text));
            Assert.That(record.ASIShipType, Does.Contain(Browser.getDynamicElement(tableCellPath, "0", "4").Text));
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
