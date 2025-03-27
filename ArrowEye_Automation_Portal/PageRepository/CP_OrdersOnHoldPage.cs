using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using ArrowEye_Automation_Framework.Common;
using NUnit.Framework;
using OpenQA.Selenium;
using RandomString4Net;
using SeleniumExtras.PageObjects;

namespace ArrowEye_Automation_Portal.PageRepository
{
    public class CP_OrdersOnHoldPage
    {
        [FindsBy(How = How.XPath, Using = "//div[@data-testid='DataTable']//p[text()='Orders On Hold']")]
        public IWebElement ordersOnHoldText;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search…']")]
        private IWebElement searchBox;

        [FindsBy(How = How.XPath, Using = "//div[@id='notistack-snackbar']")]
        private IWebElement toasterMessage;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='ReleaseButton']")]
        private IWebElement releaseButton;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='CancelButton']")]
        private IWebElement cancelButton;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitleContainerContent']/div)")]
        public IList<IWebElement> tableHeaders { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@role='rowgroup']//span)[1]")]
        private IWebElement recordCheckBox;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Export']")]
        public IWebElement export;

        [FindsBy(How = How.XPath, Using = "//li[@role='menuitem']")]
        public IWebElement downloadCSV;

        public void ValidatePageTitle()
        {
            Browser.WaitForElement(ordersOnHoldText, 10);
            Assert.That(ordersOnHoldText.Displayed, Is.True); ;
            Assert.That(ordersOnHoldText.Text, Is.EqualTo("Orders On Hold"));
        }       

        

        //To validate homepage 
        public void OrdersOnHoldHomepageView(string[] listOfOptions)
        {
            ValidatePageTitle();
            //To validate homepage table headers            
            Extensions.CompareActualExpectedLists(listOfOptions, tableHeaders); ;
            //To validate Release and Cancel Button
            Assert.That(releaseButton.Displayed, Is.True);
            Assert.That(releaseButton.Enabled, Is.False);
            Assert.That(cancelButton.Displayed, Is.True);
            Assert.That(cancelButton.Enabled, Is.False);
            if (Browser.WaitForElement(recordCheckBox,2))
            {
                Browser.Click(recordCheckBox);                
                Thread.Sleep(2000);
                Assert.That(releaseButton.Enabled, Is.True);               
                Assert.That(cancelButton.Enabled, Is.True);

            }
        }

        //To export Configuration Hierarchy data
        public void OrdersOnHoldExport(string fileName)
        {
            Browser.Click(export);
            Browser.Click(downloadCSV);
            Thread.Sleep(4000);
            bool fileStatus = Extensions.IsFileDownloaded(fileName);
            Assert.That(fileStatus, Is.True);
        }
    }
}
