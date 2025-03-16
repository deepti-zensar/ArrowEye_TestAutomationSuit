using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using ArrowEye_Automation_Framework;
using ArrowEye_Automation_Framework.Common;
using ArrowEye_Automation_Portal.PageRepository.Objects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V129.Overlay;
using Org.BouncyCastle.Asn1.X509;
using RandomString4Net;
using SeleniumExtras.PageObjects;
using static NPOI.HSSF.Util.HSSFColor;

//Note
//https://arroweye-jira-cloud.atlassian.net/browse/CRP-5427 
//https://arroweye-jira-cloud.atlassian.net/browse/CRP-5431
//https://arroweye-jira-cloud.atlassian.net/browse/CRP-5432
//Scenario 1: Viewing the Parameters on Orders on Hold Dashboard
//Scenario 2: Exporting Orders On Hold Grid
//Scenario 2: Releasing Orders On Hold
//Scenario 2: Cancelling Orders On Hold
///COMPLETED 

namespace ArrowEye_Automation_Portal.PageRepository.EMV
  
{
    
    public class Order_On_Hold_Page : TestBase
    {
      
        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Search or Select')]")]
        public IWebElement SearchOrSelect;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'CLIENT GALLERY')]")]
        public IWebElement clientGallery;

        public static string clientGalleryItem = "//p[contains(text(),'{0}')]";
      

        public static string PclDynamic = "//td[contains(.,'{0}')]";

        public static string clientGalleryMenuItem = "//li[@data-testid='nestedMenuItem']//p[contains(text(),'{0}')]";

        public static string clientGallerySubMenuItem = "//li[@data-testid='subMenuItems']//p[contains(text(),'{0}')]";

        public static string programfield = "//div[text()='{0}']";

        public static string orderbutton = "//button[contains(text(),'{0}')]";

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Export']")]
        private IWebElement exportButton;

        [FindsBy(How = How.XPath, Using = "//li[text()='Download as CSV']")]
        private IWebElement downloadCSVFile;

        [FindsBy(How = How.XPath, Using = "//td[@data-testid='table-pagination']//p[2]")]
        private IWebElement rowsCount;

        [FindsBy(How = How.XPath, Using = "//div[@data-rowindex='0']/div[@data-colindex='1']")]
        private IWebElement tablecellpath;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Release Selected')]")]
        private IWebElement releasebtn;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Cancel Selected')]")]
        private IWebElement cancelbtn;

        [FindsBy(How = How.XPath, Using = "(//td[contains(.,'9005: Pier One')])[6]")]
        private IWebElement ordersPcl;

        [FindsBy(How = How.XPath, Using = "//input[@name='programName']")]
        private IWebElement ProgramNameInput;

        [FindsBy(How = How.XPath, Using = "//div[@id='notistack-snackbar']")]
        private IWebElement sucessmessage;

        public static string popupheaderText = "//p[text()='{0}']";

        public static string popupbtn = "//p[text()='{0}']";


        public void NavigateToOrdersOnHoldHomepage()
        {
            DriverUtilities.Click(SearchOrSelect);
            Thread.Sleep(1000);
            //Browser.ClickDynamicElement(PclDynamic, "9006: Pier 2");
            DriverUtilities.Click(ordersPcl);
            DriverUtilities.Click(clientGallery);
            Browser.ClickDynamicElement(clientGalleryItem, "Orders On Hold");
            


        }
        


        public void ViewingTheParameters()
        {
            WebElement scriptIDELe = Browser.getDynamicElement(programfield, "ID");
            WebElement scriptDescriptionELe = Browser.getDynamicElement(programfield, "Program Name");
            WebElement scripteNameEle = Browser.getDynamicElement(programfield, "Package ID");
            WebElement scriptEcountELe = Browser.getDynamicElement(programfield, "Ecount ID");
            WebElement scriptLast4DigitsELe = Browser.getDynamicElement(programfield, "Last 4 Digits(PAN)");
            WebElement scriptHolderNameELe = Browser.getDynamicElement(programfield, "Card Holder Name");
            WebElement scriptDataFileReceived = Browser.getDynamicElement(programfield, "Data File Received");
            WebElement scriptExpectedDeletionELe = Browser.getDynamicElement(programfield, "Expected Deletion");
            WebElement scriptEmbossFileNameELe = Browser.getDynamicElement(programfield, "Emboss File Name");
           
        }

        public void ExportingOrders()
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

        public void ReleasingOrders()
        {
            DriverUtilities.Click(tablecellpath);

            if (releasebtn.Enabled && cancelbtn.Enabled)
            {
                DriverUtilities.Click(releasebtn);
                Console.WriteLine("Error: The Next button should initially be disabled.");
                validateReleaseMessage("Do you want to Cancel the selected order(s)");
                WebElement releaseEle = Browser.getDynamicElement(popupbtn, "Release");
                releaseEle.Click();
                Browser.WaitForElement(sucessmessage, 10);
                var UpdateSuccessMessage = sucessmessage.Text;
                Assert.That(UpdateSuccessMessage, Is.EqualTo("Order(s) released from Hold"));

                Thread.Sleep(2000);

            }
     
        }

        public void CancelOrders()
        {
            DriverUtilities.Click(tablecellpath);

            if (releasebtn.Enabled && cancelbtn.Enabled)
            {
                DriverUtilities.Click(cancelbtn);
                validateCancelMessage("Do you want to release the selected order(s) from hold");
                WebElement cancelEle = Browser.getDynamicElement(popupbtn, "Cancel");
                cancelEle.Click();
                Browser.WaitForElement(sucessmessage, 10);
                var UpdateSuccessMessage = sucessmessage.Text;
                Assert.That(UpdateSuccessMessage, Is.EqualTo("Order cancelled."));

                Thread.Sleep(2000);

            }

        }



        private void validateReleaseMessage(String headerMessage)
        {
            WebElement headerEle = Browser.getDynamicElement(popupheaderText, headerMessage);
            WebElement cancelEle = Browser.getDynamicElement(popupbtn, "Cancel");
            WebElement releaseEle = Browser.getDynamicElement(popupbtn, "Release");

            Assert.That(headerEle.Text, Is.EqualTo(headerMessage));
            Assert.That(cancelEle.Text, Is.EqualTo("CANCEL"));
            Assert.That(releaseEle.Text, Is.EqualTo("RELEASE"));


        }

        private void validateCancelMessage(String headerMessage)
        {
            WebElement headerEle = Browser.getDynamicElement(popupheaderText, headerMessage);
            WebElement cancelEle = Browser.getDynamicElement(popupbtn, "Cancel");
            WebElement cancel1Ele = Browser.getDynamicElement(popupbtn, "Cancel");

            Assert.That(headerEle.Text, Is.EqualTo(headerMessage));
            Assert.That(cancelEle.Text, Is.EqualTo("CANCEL"));
            Assert.That(cancel1Ele.Text, Is.EqualTo("CANCEL"));


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
