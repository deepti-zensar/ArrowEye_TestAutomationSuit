using System;
using System.Collections.Generic;
using System.Threading;
using ArrowEye_Automation_Framework.Common;
using NUnit.Framework;
using OpenQA.Selenium;
using RandomString4Net;
using SeleniumExtras.PageObjects;

namespace ArrowEye_Automation_Portal.PageRepository
{
    public class CP_EMV_CardProfilesPage
    {
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'EMV Card Profiles')]")]
        public IWebElement emvCardProfilesText;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Add New')]")]
        public IWebElement addNewCardProfile;

        [FindsBy(How = How.XPath, Using = "//p[text()='New Card Profile']")]
        public IWebElement newCardProfileDialogBoxText;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='nameInputField']")]
        public IWebElement nameField;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='nameInputField']/following-sibling::fieldset//span")]
        public IWebElement nameFieldText;

        [FindsBy(How = How.XPath, Using = "//input[@id='combo-box-demo']")]
        public IWebElement issuerFieldDropdown;

        [FindsBy(How = How.XPath, Using = "//label[@id='combo-box-demo-label']")]
        public IWebElement issuerFieldLabel;

        [FindsBy(How = How.XPath, Using = "//div[@data-testid='DatePicker']//input")]
        private IWebElement expirationDateField;

        [FindsBy(How = How.XPath, Using = "//div[@data-testid='DatePicker']//label")]
        private IWebElement expirationDateLabel;

        [FindsBy(How = How.XPath, Using = "//div[@data-testid='DatePicker']//*[@data-testid='CalendarIcon']")]
        private IWebElement expirationDateCalendar;

        [FindsBy(How = How.XPath, Using = "//button[@aria-current='date']")]
        private IWebElement currentActiveDate;

        [FindsBy(How = How.XPath, Using = "//*[@data-testid='ArrowRightIcon']")]
        private IWebElement nextMonthArrow;

        [FindsBy(How = How.XPath, Using = "//div[@role='rowgroup']//button[text()='1']")]
        private IWebElement firstDayOfMonth;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='cancel']")]
        private IWebElement cancelButton;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='saveCardProfile']")]
        private IWebElement saveButton;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search…']")]
        private IWebElement searchBox;

        [FindsBy(How = How.XPath, Using = "//div[@id='notistack-snackbar']")]
        private IWebElement toasterMessage;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='1'])[position()=1]")]
        private IWebElement createdEMVCardProfileID;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='2'])[position()=1]")]
        private IWebElement createdEMVCardProfileName;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='3'])[position()=1]")]
        private IWebElement createdEMVCardProfileIssuer;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='4'])[position()=1]")]
        private IWebElement createdEMVCardProfileExpDate;

        [FindsBy(How = How.XPath, Using = "(//button[@data-testid='editData'])[position()=1]")]
        private IWebElement emvCardProfileEditButton;

        [FindsBy(How = How.XPath, Using = "//p[text()='Update Card Profile']")]
        public IWebElement editCardProfilesDialogBoxText;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'ID')]/div")]
        private IWebElement editedEMVCardProfileID;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Name Field is required')]")]
        public IWebElement nameRequiredText;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Issuer Field is required')]")]
        public IWebElement issuerRequiredText;

        [FindsBy(How = How.XPath, Using = "(//p[contains(@id,'helper-text')])[1]")]
        public IWebElement nameSizeLimitMsg;       

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Expiration Date cannot be past date.')] ")]
        public IWebElement expDateMessage;

        [FindsBy(How = How.XPath, Using = "(//li[@id='subMenuItems']/p)")]
        public IList<IWebElement> emvOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitleContainerContent']/div)")]
        public IList<IWebElement> tableHeaderEMVCardProfiles { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Export']")]
        public IWebElement emvCardProfilesExport;

        [FindsBy(How = How.XPath, Using = "//li[@role='menuitem']")]
        public IWebElement downloadCSV;

        public void ValidatePageTitle()
        {
            //DriverUtilities.IsElementPresent(emvCardProfilesText);
            Assert.That(emvCardProfilesText.Text, Is.EqualTo("EMV Card Profiles"));
        }

        public void ValidateNewCardProfileDialogBox()
        {
            //DriverUtilities.IsElementPresent(newCardProfileDialogBoxText);
            Assert.That(newCardProfileDialogBoxText.Text, Is.EqualTo("New Card Profile"));            
            Assert.That(issuerFieldLabel.Text, Is.EqualTo("Issuer"));
            Assert.That(expirationDateLabel.Text, Is.EqualTo("Expiration Date"));
        }
        // To fill EMV Card Profiles details
        public void FillEMVCardProfilesDetails(string name, string issuer, string date)
        {
            nameField.SendKeys(Keys.Control + "a");
            nameField.SendKeys(Keys.Control + "x");
            nameField.SendKeys(name);
            Thread.Sleep(1000);
            if (issuer==""||issuer==null)
            {
                issuerFieldDropdown.Click();
                Thread.Sleep(2000);
                issuerFieldDropdown.SendKeys(Keys.Down + Keys.Down + Keys.Enter);                
            }
            else
            {
                issuerFieldDropdown.SendKeys(Keys.Control + "a");
                issuerFieldDropdown.SendKeys(Keys.Control + "x");
                issuerFieldDropdown.SendKeys(issuer);
                Thread.Sleep(1000);
                issuerFieldDropdown.SendKeys(Keys.Down + Keys.Down + Keys.Enter);
            }
            
            Thread.Sleep(1000);
            if (date != "" || date != null)
            {
                expirationDateField.Click();
                Thread.Sleep(1000);
                expirationDateField.SendKeys(date);
            }            
            Thread.Sleep(1000);
        }

        // To Search EMV Card Profiles 
        public void SearchEMVCardProfilesName(string name)
        {
            searchBox.SendKeys(Keys.Control + "a");
            searchBox.SendKeys(Keys.Control + "x");
            searchBox.SendKeys(name);
            Thread.Sleep(3000);
        }

        public void AddNewCardProfiles(string name,string issuer, string date)
        {
            ValidatePageTitle();
            // Add new Card Profiles and fill EMV Card Profiles details
            Browser.Click(addNewCardProfile);
            ValidateNewCardProfileDialogBox();
            Browser.Click(cancelButton);
            Thread.Sleep(2000);
            Browser.Click(addNewCardProfile);
            FillEMVCardProfilesDetails(name,issuer, date);
            Browser.Click(saveButton);
            Thread.Sleep(2000);

            //get Toaster message
            var toasterMessage_Text = toasterMessage.Text;

            //Search with newly created record
            SearchEMVCardProfilesName(name);
            var created_EMVCardProfile_Record_ID = createdEMVCardProfileID.Text;
            var created_EMVCardProfile_Record_Name = createdEMVCardProfileName.Text;
            Assert.That(created_EMVCardProfile_Record_Name, Is.EqualTo(name));

            //validate Toaster message
            Assert.That(toasterMessage_Text, Is.EqualTo("EMV Card Profile " + created_EMVCardProfile_Record_ID + " added Successfully."));
        }

        public void ValidateCalendarDropdown(string name)
        {
            ValidatePageTitle();
            //Validate calendar and select first day of next month and verify
            Browser.Click(addNewCardProfile);            
            expirationDateCalendar.Click();
            Thread.Sleep(2000);
            nextMonthArrow.Click();
            Thread.Sleep(1000);
            firstDayOfMonth.Click();
            Thread.Sleep(2000);
            var enteredDate=expirationDateField.GetDomAttribute("value");
            var todaysDate = DateTime.Now;
            var nextMonthFirstDay = todaysDate.AddDays(-todaysDate.Day + 1).AddMonths(1);
            Assert.That(enteredDate, Is.EqualTo(nextMonthFirstDay.ToString("yyyy-MM-dd")));
        }

        public void EditCardProfiles(string name, string issuer, string date, string newIssuer)
        {
            ValidatePageTitle();
            // Add new Card Profiles and fill EMV Card Profiles details            
            Browser.Click(addNewCardProfile);
            FillEMVCardProfilesDetails(name, issuer, date);
            Browser.Click(saveButton);
            Thread.Sleep(2000);

            //Search with newly created record
            SearchEMVCardProfilesName(name);
            var created_EMVCardProfile_Record_ID = createdEMVCardProfileID.Text;
            var created_EMVCardProfile_Record_Name = createdEMVCardProfileName.Text;
            Assert.That(created_EMVCardProfile_Record_Name, Is.EqualTo(name));

            //Edit EMV Card Profiles details 
            Browser.Click(emvCardProfileEditButton);
            Thread.Sleep(2000);
            Assert.That(editCardProfilesDialogBoxText.Text, Is.EqualTo("Update Card Profile"));
            var edited_EMVCardProfiles_Record_ID = editedEMVCardProfileID.Text;
            var newName = name + "_Updated";            
            var newDate = DateTime.Now.AddDays(10).ToString("yyyy-MM-dd");
            FillEMVCardProfilesDetails(newName, newIssuer, newDate);
            Browser.Click(saveButton);
            Thread.Sleep(2000);

            //validate Toaster message
            var toasterMessage_Text = toasterMessage.Text;
            Assert.That(toasterMessage_Text, Is.EqualTo("EMV Card Profile " + created_EMVCardProfile_Record_ID + " updated Successfully."));

            //Search with newly edited record and get information from search result          
            SearchEMVCardProfilesName(newName);            
            var edited_EMVCardProfiles_Record_Name = createdEMVCardProfileName.Text;
            var edited_EMVCardProfiles_Record_Issuer = createdEMVCardProfileIssuer.Text;
            var edited_EMVCardProfiles_Record_ExpDate = createdEMVCardProfileExpDate.Text;            

            //validate newly edited record in EMV Issuer homepage
            Assert.That(edited_EMVCardProfiles_Record_ID, Is.EqualTo(created_EMVCardProfile_Record_ID));
            Assert.That(edited_EMVCardProfiles_Record_Name, Is.EqualTo(newName));
            Assert.That(edited_EMVCardProfiles_Record_Issuer, Is.EqualTo(newIssuer));
            Assert.That(edited_EMVCardProfiles_Record_ExpDate, Is.EqualTo(newDate));            
        }

        public void ValidateEMVCardProfiles()
        {
            ValidatePageTitle();
            //ADD NEW Card Profiles WITHOUT ANY DETAILS AND VALIDATE MESSAGE
            Browser.Click(addNewCardProfile);
            ValidateNewCardProfileDialogBox();
            Browser.Click(saveButton);
            Assert.That(nameRequiredText.Text, Is.EqualTo("Name Field is required"));
            Assert.That(issuerRequiredText.Text, Is.EqualTo("Issuer Field is required"));            

            //CHARACTER LIMITATIONS FOR Fields            
            string longString = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 55);
            nameField.SendKeys(Keys.Control + "a");
            nameField.SendKeys(Keys.Control + "x");
            nameField.SendKeys(longString);
            Thread.Sleep(1000);
            Assert.That(nameSizeLimitMsg.Text, Is.EqualTo("50/50"));

            //Expiration date can't be past date
            var date = "1111-11-01";
            expirationDateField.Click();
            Thread.Sleep(1000);
            expirationDateField.SendKeys(date);
            Assert.That(expDateMessage.Text, Is.EqualTo("Expiration Date cannot be past date."));
        }

        //To validate EMV Card Profiles homepage table headers
        public void EMVCardProfilesHomepageView(string[] listOfOptions)
        {
            List<string> expectedListOfOptions = new List<string>(listOfOptions);
            List<string> actualListOfOptions = new List<string>();
            foreach (IWebElement actualOption in tableHeaderEMVCardProfiles)
            {
                actualListOfOptions.Add(actualOption.Text);
            }
            Assert.That(actualListOfOptions, Is.EquivalentTo(expectedListOfOptions));
        }

        //To validate EMV Card Profiles Export 
        public void EMVCardProfilesExport(string fileName)
        {
            Browser.Click(emvCardProfilesExport);
            Browser.Click(downloadCSV);
            Thread.Sleep(4000);
            bool fileStatus = Extensions.IsFileDownloaded(fileName);            
            Assert.That(fileStatus, Is.True);
        }

    }
}
