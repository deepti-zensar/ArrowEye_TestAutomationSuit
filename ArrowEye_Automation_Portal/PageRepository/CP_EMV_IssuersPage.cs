using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using ArrowEye_Automation_Framework.Common;
using System.Threading;
using Keys = OpenQA.Selenium.Keys;
using NUnit.Framework;
using System.Xml.Linq;
using RandomString4Net;
using System.Collections.Generic;
using System.IO;
using System;

namespace ArrowEye_Automation_Portal.PageRepository
{
    public class CP_EMV_IssuersPage
    {
        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 jss14 css-1rtfhzq' and contains(text(),'EMV Issuers')]")]
        public IWebElement emvIssuersText;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 css-9l3uo3' and contains(text(),' Add New ')]")]
        public IWebElement addNewIssuer;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'New Issuer')]")]
        public IWebElement newIssuerDialogBoxText;

        [FindsBy(How = How.XPath, Using = "//input[@name='name']")]
        public IWebElement nameField;

        [FindsBy(How = How.XPath, Using = "//input[@name='cpvPvtNumber']")]
        public IWebElement cpvField;

        [FindsBy(How = How.XPath, Using = "//input[@name='notes']")]
        public IWebElement notesField;

        [FindsBy(How = How.XPath, Using = "//input[@id='approval-path-autocomplete']")]
        private IWebElement approvalPath;

        [FindsBy(How = How.XPath, Using = "//p[@id='approval-path-autocomplete' and @aria-controls='spproval-path-autocomplete-option-0']")]
        private IWebElement certifiedPath;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='cancelCSP']")]
        private IWebElement cancelButton;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='saveCSP']")]
        private IWebElement saveButton;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search…']")]
        private IWebElement searchBox;

        [FindsBy(How = How.XPath, Using = "//div[@id='notistack-snackbar']")]
        private IWebElement toasterMessage;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='1'])[position()=1]")]
        private IWebElement createdEMVIssuerID;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='2'])[position()=1]")]
        private IWebElement createdEMVIssuerName;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='3'])[position()=1]")]
        private IWebElement createdEMVIssuerCPV;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='4'])[position()=1]")]
        private IWebElement createdEMVIssuerApprovalPath;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='5'])[position()=1]")]
        private IWebElement createdEMVIssuerNotes;

        [FindsBy(How = How.XPath, Using = "(//button[@data-testid='edit'])[position()=1]")]
        private IWebElement EMVIssuerEditButton;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Update Issuer')]")]
        public IWebElement editIssuerDialogBoxText;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Name is required.')]")]
        public IWebElement nameRequiredText;

        [FindsBy(How = How.XPath, Using = "(//p[contains(@id,'helper-text')])[1]")]
        public IWebElement nameSizeLimitMsg;

        [FindsBy(How = How.XPath, Using = "(//p[contains(@id,'helper-text')])[2]")]
        public IWebElement cpvSizeLimitMsg;

        [FindsBy(How = How.XPath, Using = "(//p[contains(@id,'helper-text')])[3]")]
        public IWebElement notesSizeLimitMsg;

        [FindsBy(How = How.XPath, Using = "(//li[@id='subMenuItems']/p)")]
        public IList<IWebElement> emvOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitleContainerContent']/div)")]
        public IList<IWebElement> tableHeaderEMVIssuer { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Export']")]
        public IWebElement emvIssuerExport;

        [FindsBy(How = How.XPath, Using = "//li[@role='menuitem']")]
        public IWebElement downloadCSV;

        public void ValidatePageTitle()
        {
            //DriverUtilities.IsElementPresent(emvIssuersText);
            Assert.That(emvIssuersText.Text, Is.EqualTo("EMV Issuers"));
        }

        public void ValidateNewIssuerDialogBox()
        {
            //DriverUtilities.IsElementPresent(newIssuerDialogBoxText);
            Assert.That(newIssuerDialogBoxText.Text, Is.EqualTo("New Issuer"));
        }
        // To fill EMV Issuer details
        public void FillEMVIssuerDetails(string name, string cpv, string appPath, string notes)
        {
            nameField.SendKeys(Keys.Control + "a");
            nameField.SendKeys(Keys.Control + "x");
            nameField.SendKeys(name);
            Thread.Sleep(1000);
            cpvField.SendKeys(Keys.Control + "a");
            cpvField.SendKeys(Keys.Control + "x");
            cpvField.SendKeys(cpv);
            Browser.Click(approvalPath);
            Thread.Sleep(2000);
            approvalPath.Clear();
            approvalPath.SendKeys(Keys.Down + Keys.Enter);

            switch (appPath)
            {
                case "Certified":
                    approvalPath.SendKeys(Keys.Down + Keys.Enter);
                    break;
                case "CNS":
                    approvalPath.SendKeys(Keys.Down + Keys.Down + Keys.Enter);
                    break;
                case "EasyPath":
                    approvalPath.SendKeys(Keys.Down + Keys.Down + Keys.Down + Keys.Enter);
                    break;
                case "PE":
                    approvalPath.SendKeys(Keys.Down + Keys.Down + Keys.Down + Keys.Down + Keys.Enter);
                    break;
            }
            notesField.SendKeys(Keys.Control + "a");
            notesField.SendKeys(Keys.Control + "x");
            notesField.SendKeys(notes);
        }

        // To Search EMV Issuer 
        public void SearchEMVIssuerName(string name)
        {
            searchBox.SendKeys(Keys.Control + "a");
            searchBox.SendKeys(Keys.Control + "x");
            searchBox.SendKeys(name);
            Thread.Sleep(3000);
        }

        public void AddNewIssuer(string name, string cpv, string appPath, string notes)
        {
            ValidatePageTitle();
            // Add new Issuer and fill EMV Issuer details
            Browser.Click(addNewIssuer);
            ValidateNewIssuerDialogBox();
            Browser.Click(cancelButton);
            Thread.Sleep(3000);
            Browser.Click(addNewIssuer);
            FillEMVIssuerDetails(name, cpv, appPath, notes);
            Browser.Click(saveButton);
            Thread.Sleep(2000);

            //validate Toaster message
            var toasterMessage_Text = toasterMessage.Text;
            var created_EMVIssuer_Record_ID = createdEMVIssuerID.Text;
            Assert.That(toasterMessage_Text, Is.EqualTo("EMV Issuer " + created_EMVIssuer_Record_ID + " Added Successfully."));

            //Search with newly created record
            SearchEMVIssuerName(name);
            var created_EMVIssuer_Record_Name = createdEMVIssuerName.Text;
            Assert.That(created_EMVIssuer_Record_Name, Is.EqualTo(name));
        }

        public void EditIssuer(string name, string cpv, string appPath, string notes, string newAppPath)
        {
            ValidatePageTitle();
            // Add new Issuer and fill EMV Issuer details
            Browser.Click(addNewIssuer);
            FillEMVIssuerDetails(name, cpv, appPath, notes);
            Browser.Click(saveButton);
            Thread.Sleep(2000);

            //Search with newly created record
            searchBox.Clear();
            searchBox.SendKeys(name);
            Thread.Sleep(3000);
            var created_EMVIssuer_Record_ID = createdEMVIssuerID.Text;
            var created_EMVIssuer_Record_Name = createdEMVIssuerName.Text;
            Assert.That(created_EMVIssuer_Record_Name, Does.Contain(name));

            //Edit EMV Issuer details 
            Browser.Click(EMVIssuerEditButton);
            Thread.Sleep(2000);
            Assert.That(editIssuerDialogBoxText.Text, Is.EqualTo("Update Issuer"));
            var newName = name + "_Updated";
            var newCPV = cpv + 1;
            var newNotes = notes + "_Updated";
            FillEMVIssuerDetails(newName, newCPV, newAppPath, newNotes);
            Browser.Click(saveButton);
            Thread.Sleep(2000);

            //validate Toaster message
            var toasterMessage_Text = toasterMessage.Text;
            Assert.That(toasterMessage_Text, Is.EqualTo("EMV Issuer " + created_EMVIssuer_Record_ID + " Updated Successfully."));

            //Search with newly edited record and get information from search result          
            SearchEMVIssuerName(newName);
            var edited_EMVIssuer_Record_ID = createdEMVIssuerID.Text;
            var edited_EMVIssuer_Record_Name = createdEMVIssuerName.Text;
            var edited_EMVIssuer_Record_CPV = createdEMVIssuerCPV.Text;
            var edited_EMVIssuer_Record_AppPath = createdEMVIssuerApprovalPath.Text;
            var edited_EMVIssuer_Record_Notes = createdEMVIssuerNotes.Text;

            //validate newly edited record in EMV Issuer homepage
            Assert.That(edited_EMVIssuer_Record_ID, Is.EqualTo(created_EMVIssuer_Record_ID));
            Assert.That(edited_EMVIssuer_Record_Name, Is.EqualTo(newName));
            Assert.That(edited_EMVIssuer_Record_CPV, Is.EqualTo(newCPV.ToString()));
            Assert.That(edited_EMVIssuer_Record_AppPath, Is.EqualTo(newAppPath));
            Assert.That(edited_EMVIssuer_Record_Notes, Is.EqualTo(newNotes));

        }

        public void ValidateEMVIssuer(string name, string cpv, string appPath, string notes)
        {
            ValidatePageTitle();
            //ADD NEW ISSUER WITHOUT EMV ISSUER DETAILS AND VALIDATE MESSAGE
            Browser.Click(addNewIssuer);
            ValidateNewIssuerDialogBox();
            Browser.Click(saveButton);
            Assert.That(nameRequiredText.Text, Is.EqualTo("Name is required."));

            //USER ENTERS A NAME WHICH ALREADY EXISTS
            //create new EMV Issuer record
            FillEMVIssuerDetails(name, cpv, appPath, notes);
            Browser.Click(saveButton);
            Thread.Sleep(2000);

            //Enter same details for new EMV Issuer 
            Browser.Click(addNewIssuer);
            FillEMVIssuerDetails(name, cpv, appPath, notes);
            Browser.Click(saveButton);
            Thread.Sleep(2000);

            //verify toaster Error message
            var errorToasterMessage_Text = toasterMessage.Text;
            Assert.That(errorToasterMessage_Text, Is.EqualTo("EMV Issuer Name " + name + " already exists."));

            //Search with newly created record
            Browser.Click(cancelButton);
            SearchEMVIssuerName(name);
            var created_EMVIssuer_Record_Name = createdEMVIssuerName.Text;
            Assert.That(created_EMVIssuer_Record_Name, Is.EqualTo(name));

            //Update the added record with same name and details            
            Browser.Click(EMVIssuerEditButton);
            Thread.Sleep(2000);
            Assert.That(editIssuerDialogBoxText.Text, Is.EqualTo("Update Issuer"));
            FillEMVIssuerDetails(name, cpv, appPath, notes);
            Browser.Click(saveButton);
            Thread.Sleep(2000);

            //verify toaster Error message
            errorToasterMessage_Text = toasterMessage.Text;
            Assert.That(errorToasterMessage_Text, Is.EqualTo("EMV Issuer Name " + name + " already exists."));

            //CHARACTER LIMITATIONS FOR NAME, NOTES AND CPV / PVT NUMBER FIELD
            //create new EMV Issuer record with longer data
            string longString = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 55);
            string longNumber = RandomString.GetString(Types.NUMBERS, 55);
            var longName = name + longString;
            var longCPV = cpv + longNumber;
            var longNotes = notes + longString;
            FillEMVIssuerDetails(longName, longCPV, appPath, longNotes);
            Assert.That(nameSizeLimitMsg.Text, Is.EqualTo("50/50"));
            Assert.That(cpvSizeLimitMsg.Text, Is.EqualTo("50/50"));
            Assert.That(notesSizeLimitMsg.Text, Is.EqualTo("50/50"));
            //Browser.Click(saveButton);
            Thread.Sleep(2000);

        }

        //To validate EMV Options
        public void EMVOptionsView(string[] listOfOptions)
        {
            List<string> expectedListOfOptions = new List<string>(listOfOptions);
            List<string> actualListOfOptions= new List<string>();
            foreach (IWebElement actualOption in emvOptions)
            {
                actualListOfOptions.Add(actualOption.Text);
            }
            Assert.That(actualListOfOptions, Is.EquivalentTo(expectedListOfOptions));
        }

        //To validate EMV Issuer homepage table headers
        public void EMVIssuerHomepageView(string[] listOfOptions)
        {
            List<string> expectedListOfOptions = new List<string>(listOfOptions);
            List<string> actualListOfOptions = new List<string>();
            foreach (IWebElement actualOption in tableHeaderEMVIssuer)
            {
                actualListOfOptions.Add(actualOption.Text);
            }            
            Assert.That(actualListOfOptions, Is.EquivalentTo(expectedListOfOptions));
        }

        //To export EMV Issuer data
        public void EMVIssuerExport(string fileName)
        {
            Browser.Click(emvIssuerExport);
            Browser.Click(downloadCSV);
            Thread.Sleep(4000);
            bool fileStatus=IsFileDownloaded(fileName);
            Assert.That(fileStatus,Is.True);
        }

        //To check is File downloaded
        public bool IsFileDownloaded(string fileName)
        {
            string pathUser = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string pathDownload = Path.Combine(pathUser, "Downloads");
            DirectoryInfo downloadDir = new DirectoryInfo(pathDownload);
            var dirContents = downloadDir.GetFiles();
            foreach (var file in dirContents)
            {
                if (file.Name.Equals(fileName))
                {
                    file.Delete();
                    return true;
                }
            }
            return false;
        }
    }
}
