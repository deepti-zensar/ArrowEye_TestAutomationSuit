using System.Collections.Generic;
using System.Threading;
using ArrowEye_Automation_Framework.Common;
using NUnit.Framework;
using OpenQA.Selenium;
using RandomString4Net;
using SeleniumExtras.PageObjects;

namespace ArrowEye_Automation_Portal.PageRepository
{
    public class CP_ClientSettings_DefaultProofReplacementsPage
    {
        [FindsBy(How = How.XPath, Using = "//div[@data-testid='DataTable']//p[text()='Default Proof Replacements']")]
        public IWebElement defaultProofReplacementText;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Add New')]")]
        public IWebElement addNewProofReplacement;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'New Proof Replacement')]")]
        public IWebElement newProofReplacementDialogBoxText;

        [FindsBy(How = How.XPath, Using = "//label[text()='Replacement Tag']/following-sibling::div/input[@id='combo-box-demo']")]
        public IWebElement replacementTagField;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='replace_Value']")]
        public IWebElement replacementValueField;

        [FindsBy(How = How.XPath, Using = "//label[text()='Replacement Type']/following-sibling::div/input[@id='combo-box-demo']")]
        public IWebElement replacementTypeField;        

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='cancelProofReplacement']")]
        private IWebElement cancelButton;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='saveProofReplacement']")]
        private IWebElement saveButton;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search…']")]
        private IWebElement searchBox;

        [FindsBy(How = How.XPath, Using = "//div[@id='notistack-snackbar']")]
        private IWebElement toasterMessage;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='1'])[position()=1]")]
        private IWebElement createdID;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='2'])[position()=1]")]
        private IWebElement createdReplacementTag;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='3'])[position()=1]")]
        private IWebElement createdReplacementValue;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='4'])[position()=1]")]
        private IWebElement createdReplacementType;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='4'][position()=1])//button[@data-testid='DeleteButton']")]
        private IWebElement deleteButton;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='4'][position()=1])//button[@data-testid='editIcon']")]
        private IWebElement editButton;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Update Proof Replacement')]")]
        public IWebElement editDialogBoxText;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'ID')]/div")]
        public IWebElement editDialogBoxID;

        [FindsBy(How = How.XPath, Using = "//h2[contains(text(),'Delete')]")]
        public IWebElement deleteDialogBoxTitle;

        [FindsBy(How = How.XPath, Using = "//div[@role='dialog']//p[contains(text(),'Are you sure')]")]
        public IWebElement deleteDialogBoxText;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='okButton']")]
        public IWebElement deleteBoxDeleteBtn;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='cancelButton']")]
        public IWebElement deleteBoxCancelBtn;

        [FindsBy(How = How.XPath, Using = "//div[text()='No results found.']")]
        public IWebElement noResultFound;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Replacement Tag is required.')]")]
        public IWebElement replacementTagRequiredText;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Replacement Value is required.')]")]
        public IWebElement replacementValueRequiredText;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='replace_Value']/parent::div/following-sibling::p")]
        public IWebElement replacementValueLimitText;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitleContainerContent']/div)")]
        public IList<IWebElement> tableHeaderProofReplacement { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Export']")]
        public IWebElement proofReplacementExport;

        [FindsBy(How = How.XPath, Using = "//li[@role='menuitem']")]
        public IWebElement downloadCSV;

        public void ValidatePageTitle()
        {
            Browser.WaitForElement(defaultProofReplacementText, 10);
            Assert.That(defaultProofReplacementText.Displayed, Is.True);
            Assert.That(defaultProofReplacementText.Text, Is.EqualTo("Default Proof Replacements"));
        }

        public void ValidateNewProofReplacementDialogBox()
        {
            Assert.That(newProofReplacementDialogBoxText.Displayed, Is.True);
            Assert.That(newProofReplacementDialogBoxText.Text, Is.EqualTo("New Proof Replacement"));
        }

        //To select dropdown value
        public void SelectDropDownValue(IWebElement dropDownName, string value)
        {
            if (value == "" || value == null)
            {
                dropDownName.Click();
                Thread.Sleep(2000);
                dropDownName.SendKeys(Keys.Down + Keys.Enter);
            }
            else
            {
                dropDownName.SendKeys(Keys.Control + "a");
                dropDownName.SendKeys(Keys.Control + "x");
                dropDownName.SendKeys(value);
                Thread.Sleep(1000);
                dropDownName.SendKeys(Keys.Down + Keys.Down + Keys.Enter);
            }
        }

        // To fill Proof Replacement details
        public void FillProofReplacementDetails(string replacementTag, string replacementValue)
        {
            SelectDropDownValue(replacementTagField, replacementTag);
            replacementValueField.SendKeys(Keys.Control + "a");
            replacementValueField.SendKeys(Keys.Control + "x");
            replacementValueField.SendKeys(replacementValue);            
        }

        // To Search EMV Issuer 
        public void SearchProofReplacement(string replacementValue)
        {
            searchBox.SendKeys(Keys.Control + "a");
            searchBox.SendKeys(Keys.Control + "x");
            searchBox.SendKeys(replacementValue);
            Thread.Sleep(3000);
        }
        public void AddNewProofReplacement(string replacementTag, string replacementValue)
        {
            ValidatePageTitle();
            // Add new Default Proof Replacements and fill details
            Browser.Click(addNewProofReplacement);
            ValidateNewProofReplacementDialogBox();
            Browser.Click(cancelButton);
            Thread.Sleep(2000);
            Browser.Click(addNewProofReplacement);
            FillProofReplacementDetails(replacementTag, replacementValue);
            var newReplacementTag = replacementTagField.GetAttributeValue("value");
            var newReplacementValue = replacementValueField.GetAttributeValue("value");            
            Browser.Click(saveButton);
            Thread.Sleep(3000);
            //Toaster message
            var toasterMessage_Text = toasterMessage.Text;
            //Search and Validate with newly created record
            SearchProofReplacement(replacementValue);
            var created_ID = createdID.Text;
            var created_ReplacementTag = createdReplacementTag.Text;
            var created_ReplacementValue = createdReplacementValue.Text;
            //Validate newly created record
            Assert.That(created_ReplacementTag, Is.EqualTo(newReplacementTag));            
            Assert.That(created_ReplacementValue, Is.EqualTo(newReplacementValue));  
            //validate Toaster message
            Assert.That(toasterMessage_Text, Is.EqualTo("Proof Replacement " + created_ID + " Added Successfully."));
        }

        public void EditProofReplacement(string replacementTag, string replacementValue)
        {
            ValidatePageTitle();
            // Add new Default Proof Replacements and fill details
            Browser.Click(addNewProofReplacement);
            ValidateNewProofReplacementDialogBox();
            Browser.Click(cancelButton);
            Thread.Sleep(2000);
            Browser.Click(addNewProofReplacement);
            FillProofReplacementDetails(replacementTag, replacementValue);
            var newReplacementTag = replacementTagField.GetAttributeValue("value");
            var newReplacementValue = replacementValueField.GetAttributeValue("value");            
            Browser.Click(saveButton);
            Thread.Sleep(3000);
            //Search with newly created record
            searchBox.Clear();
            searchBox.SendKeys(replacementValue);
            Thread.Sleep(3000);
            var created_ProofReplacement_ID = createdID.Text;
            var created_ProofReplacement_tag = createdReplacementTag.Text;
            var created_ProofReplacement_Value = createdReplacementValue.Text;
            Assert.That(created_ProofReplacement_Value, Is.EqualTo(replacementValue));
            //Edit EMV Issuer details 
            Browser.Click(editButton);
            Thread.Sleep(2000);
            Assert.That(editDialogBoxText.Text, Is.EqualTo("Update Proof Replacement"));
            var editDialogBox_ID = editDialogBoxID.Text;            
            var newreplacementValue = replacementValue + "_Updated";
            replacementValueField.SendKeys(Keys.Control + "a");
            replacementValueField.SendKeys(Keys.Control + "x");
            replacementValueField.SendKeys(newreplacementValue);            
            Browser.Click(saveButton);
            Thread.Sleep(2000);
            //validate Toaster message
            var toasterMessage_Text = toasterMessage.Text;
            Assert.That(toasterMessage_Text, Is.EqualTo("Proof Replacement " + editDialogBox_ID + " Updated Successfully."));
            //Search with newly edited record and get information from search result          
            searchBox.Clear();
            searchBox.SendKeys(newreplacementValue);
            Thread.Sleep(3000);
            var edited_ProofReplacement_ID = createdID.Text;
            var edited_ProofReplacement_Tag = createdReplacementTag.Text;
            var edited_ProofReplacement_Value = createdReplacementValue.Text;
            //validate newly edited record in EMV Issuer homepage
            Assert.That(editDialogBox_ID, Is.EqualTo(created_ProofReplacement_ID));
            Assert.That(edited_ProofReplacement_Tag, Is.EqualTo(created_ProofReplacement_tag));
            Assert.That(edited_ProofReplacement_Value, Is.EqualTo(newreplacementValue));  
        }
        public void DeleteProofReplacement(string replacementTag, string replacementValue)
        {
            ValidatePageTitle();
            // Add new Default Proof Replacements and fill details
            Browser.Click(addNewProofReplacement);
            ValidateNewProofReplacementDialogBox();
            Browser.Click(cancelButton);
            Thread.Sleep(2000);
            Browser.Click(addNewProofReplacement);
            FillProofReplacementDetails(replacementTag, replacementValue);
            var newReplacementTag = replacementTagField.GetAttributeValue("value");
            var newReplacementValue = replacementValueField.GetAttributeValue("value");
            Browser.Click(saveButton);
            Thread.Sleep(3000);
            //Search with newly created record
            searchBox.Clear();
            searchBox.SendKeys(replacementValue);
            Thread.Sleep(3000);
            var created_ProofReplacement_ID = createdID.Text;
            var created_ProofReplacement_tag = createdReplacementTag.Text;
            var created_ProofReplacement_Value = createdReplacementValue.Text;
            Assert.That(created_ProofReplacement_Value, Is.EqualTo(replacementValue));
            //Delete details 
            Browser.Click(deleteButton);            
            Assert.That(deleteDialogBoxTitle.Text, Is.EqualTo("Delete"));
            var deleteDialogBoxMessage = deleteDialogBoxText.Text;
            Browser.Click(deleteBoxCancelBtn);
            Browser.Click(deleteButton);
            Browser.Click(deleteBoxDeleteBtn);
            Thread.Sleep(2000);
            //validate delete popup message            
            Assert.That(deleteDialogBoxMessage, Is.EqualTo("Are you sure you want to delete the \"Proof Replacement "+ created_ProofReplacement_ID + "\"?"));
            //validate Delete Toaster message
            var toasterMessage_Text = toasterMessage.Text;
            Assert.That(toasterMessage_Text, Is.EqualTo("Proof Replacement " + created_ProofReplacement_ID + " Deleted Successfully."));
            //Search with newly Deleted record        
            searchBox.Clear();
            searchBox.SendKeys(replacementValue);
            Thread.Sleep(3000);            
            Assert.That(noResultFound.Text, Is.EqualTo("No results found."));   
        }

        public void ValidateProofReplacement(string replacementTag, string replacementValue)
        {
            ValidatePageTitle();
            //ADD NEW ISSUER WITHOUT EMV ISSUER DETAILS AND VALIDATE MESSAGE
            Browser.Click(addNewProofReplacement);
            ValidateNewProofReplacementDialogBox();
            Browser.Click(saveButton);
            Assert.That(replacementTagRequiredText.Text, Is.EqualTo("Replacement Tag is required."));
            Assert.That(replacementValueRequiredText.Text, Is.EqualTo("Replacement Value is required."));                     
            //CHARACTER LIMITATIONS FOR Replacement Value
            //create new record with longer data
            string longString = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 155);            
            var longReplacementValue = replacementValue + longString;
            FillProofReplacementDetails(replacementTag, longReplacementValue);
            Assert.That(replacementValueLimitText.Text, Is.EqualTo("150/150"));                 
        }
        //To validate Proof Replacement homepage table headers
        public void ProofReplacementHomepageView(string[] listOfOptions)
        {
            ValidatePageTitle();
            Extensions.CompareActualExpectedLists(listOfOptions, tableHeaderProofReplacement);
        }

        //To export Proof Replacement data
        public void ProofReplacementExport(string fileName)
        {
            Browser.Click(proofReplacementExport);
            Browser.Click(downloadCSV);
            Thread.Sleep(4000);
            bool fileStatus = Extensions.IsFileDownloaded(fileName);
            Assert.That(fileStatus, Is.True);
        }
    }
}
