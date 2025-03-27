using System.Collections.Generic;
using System.Threading;
using ArrowEye_Automation_Framework.Common;
using NUnit.Framework;
using OpenQA.Selenium;
using RandomString4Net;
using SeleniumExtras.PageObjects;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ArrowEye_Automation_Portal.PageRepository
{
    public class CP_ClientSettings_MagTrackEncodingsPage
    {
        [FindsBy(How = How.XPath, Using = "//div[@data-testid='DataTable']//p[text()='Mag Track Encodings']")]
        public IWebElement magTrackEncodingsText;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Add New')]")]
        public IWebElement addNewMagTrackEncodings;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'New Mag Track Encodings')]")]
        public IWebElement newMagTrackEncodingsDialogBoxText;

        [FindsBy(How = How.XPath, Using = "//input[@name='name']")]
        public IWebElement nameField;

        [FindsBy(How = How.XPath, Using = "//input[@name='description']")]
        public IWebElement descriptionField;

        [FindsBy(How = How.XPath, Using = "//input[@name='track1']")]
        public IWebElement track1Field;

        [FindsBy(How = How.XPath, Using = "//input[@name='track2']")]
        public IWebElement track2Field;

        [FindsBy(How = How.XPath, Using = "//input[@name='track3']")]
        public IWebElement track3Field;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Cancel')]")]
        private IWebElement cancelButton;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Save')]")]
        private IWebElement saveButton;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search…']")]
        private IWebElement searchBox;

        [FindsBy(How = How.XPath, Using = "//div[@id='notistack-snackbar']")]
        private IWebElement toasterMessage;
        
        [FindsBy(How = How.XPath, Using = "//div[text()='No results found.']")]
        public IWebElement noResultFound;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Name is required.')]")]
        public IWebElement nameRequiredText;

        [FindsBy(How = How.XPath, Using = "//label[text()='Name']/following-sibling::p")]
        public IWebElement nameLimitText;

        [FindsBy(How = How.XPath, Using = "//label[text()='Description']/following-sibling::p")]
        public IWebElement descriptionLimitText;

        [FindsBy(How = How.XPath, Using = "//label[text()='Track 1']/following-sibling::p")]
        public IWebElement track1LimitText;

        [FindsBy(How = How.XPath, Using = "//label[text()='Track 2']/following-sibling::p")]
        public IWebElement track2LimitText;

        [FindsBy(How = How.XPath, Using = "//label[text()='Track 3']/following-sibling::p")]
        public IWebElement track3LimitText;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='1'])[position()=1]")]
        private IWebElement searchedID;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='2'])[position()=1]")]
        private IWebElement searchedName;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='7'][position()=1])//button[@data-testid='DeleteButton']")]
        private IWebElement deleteButton;

        [FindsBy(How = How.XPath, Using = "//h2[contains(text(),'Delete')]")]
        public IWebElement deleteDialogBoxTitle;

        [FindsBy(How = How.XPath, Using = "//div[@role='dialog']//p[contains(text(),'Are you sure')]")]
        public IWebElement deleteDialogBoxText;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='okButton']")]
        public IWebElement deleteBoxDeleteBtn;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='cancelButton']")]
        public IWebElement deleteBoxCancelBtn;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitleContainerContent']/div)")]
        public IList<IWebElement> tableHeaderMagTrack { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Export']")]
        public IWebElement proofReplacementExport;

        [FindsBy(How = How.XPath, Using = "//li[@role='menuitem']")]
        public IWebElement downloadCSV;

        public void ValidatePageTitle()
        {
            // DriverUtilities.IsElementPresent(magTrackEncodingsText);
            Assert.That(magTrackEncodingsText.Text, Is.EqualTo("Mag Track Encodings"));
        }

        public void ValidateMagTrackEncodingsDialogBox()
        {
            //  DriverUtilities.IsElementPresent(newMagTrackEncodingsDialogBoxText);
            Assert.That(newMagTrackEncodingsDialogBoxText.Text, Is.EqualTo("New Mag Track Encodings"));
        }


        public void ValidateMagTrackEncodings()
        {
            ValidatePageTitle();
            //ADD NEW Mag Track Encodings WITHOUT DETAILS AND VALIDATE MESSAGE
            Browser.Click(addNewMagTrackEncodings);
            ValidateMagTrackEncodingsDialogBox();
            Browser.Click(saveButton);
            Assert.That(nameRequiredText.Text, Is.EqualTo("Name is required."));

            //CHARACTER LIMITATIONS FOR different fields
            //create new record with longer data
            string nameString = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 55);
            string descString = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 205);
            string trackString = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 505);
            nameField.SendKeys(nameString);
            descriptionField.SendKeys(descString);
            track1Field.SendKeys(trackString);
            track2Field.SendKeys(trackString);
            track3Field.SendKeys(trackString);
            
            Assert.That(nameLimitText.Text, Is.EqualTo("50/50"));
            Assert.That(descriptionLimitText.Text, Is.EqualTo("200/200"));
            Assert.That(track1LimitText.Text, Is.EqualTo("500/500"));
            Assert.That(track2LimitText.Text, Is.EqualTo("500/500"));
            Assert.That(track3LimitText.Text, Is.EqualTo("500/500"));
            //Browser.Click(saveButton);   

        }

        public void DeleteBINMagTrackEncodings(string name)
        {
            ValidatePageTitle();
            //Search with Mag track encoding which is linked to a BIN
            searchBox.Clear();
            searchBox.SendKeys(name);
            Thread.Sleep(1000);
            var ID = searchedID.Text;
            
            Assert.That(searchedName.Text, Is.EqualTo(name));

            //Delete details 
            Browser.Click(deleteButton);
            Assert.That(deleteDialogBoxTitle.Text, Is.EqualTo("Delete"));
            var deleteDialogBoxMessage = deleteDialogBoxText.Text;
            Browser.Click(deleteBoxCancelBtn);
            Browser.Click(deleteButton);
            Browser.Click(deleteBoxDeleteBtn);
            Thread.Sleep(2000);

            //validate delete popup message            
            Assert.That(deleteDialogBoxMessage, Is.EqualTo("Are you sure you want to delete the \"Mag Track Encoding " + ID + "\"?"));

            //validate Delete Toaster message
            var toasterMessage_Text = toasterMessage.Text;
            Assert.That(toasterMessage_Text, Does.Contain("Mag track encoding can not be deleted since it is linked to following BIN's: "));

        }


        //To validate Mag Track Encodings homepage table headers
        public void MagTrackEncodingsHomepageView(string[] listOfOptions)
        {
            ValidatePageTitle();
            Extensions.CompareActualExpectedLists(listOfOptions, tableHeaderMagTrack);
        }

        //To export Mag Track Encodings data
        public void MagTrackEncodingsExport(string fileName)
        {
            Browser.Click(proofReplacementExport);
            Browser.Click(downloadCSV);
            Thread.Sleep(4000);
            bool fileStatus = Extensions.IsFileDownloaded(fileName);
            Assert.That(fileStatus, Is.True);
        }
    }
}
