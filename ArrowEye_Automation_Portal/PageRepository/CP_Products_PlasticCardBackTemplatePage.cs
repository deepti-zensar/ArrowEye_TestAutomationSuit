using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using ArrowEye_Automation_Framework.Common;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RandomString4Net;
using SeleniumExtras.PageObjects;

namespace ArrowEye_Automation_Portal.PageRepository
{
    public class CP_Products_PlasticCardBackTemplatePage
    {
        [FindsBy(How = How.XPath, Using = "//h5[text()='BOC Templates']")]
        public IWebElement BOCHeader;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='AddButton']")]
        public IWebElement addNewBOCTemplate;

        [FindsBy(How = How.XPath, Using = "//div[@role='dialog']//p")]
        public IWebElement newBOCLabel;

        [FindsBy(How = How.XPath, Using = "//input[@id='approval-path-autocomplete']")]
        public IWebElement selectTemplate;

        [FindsBy(How = How.XPath, Using = "//p[@id='approval-path-autocomplete-helper-text']")]
        public IWebElement selectTemplateMsg;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='nameInputField']")]
        public IWebElement nameField;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='nameInputField']/parent::div/following-sibling::p")]
        public IWebElement nameFieldMsg;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='descriptionInputField']")]
        public IWebElement descField;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='descriptionInputField']/parent::div/following-sibling::p")]
        public IWebElement descFieldMsg;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='save']")]
        public IWebElement saveButton;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='cancelButton']")]
        public IWebElement cancelButton;

        [FindsBy(How = How.XPath, Using = "//div[@id='notistack-snackbar']")]
        private IWebElement toasterMessage;

        [FindsBy(How = How.XPath, Using = "//p[text()='ID:']")]
        public IWebElement idLabel;

        [FindsBy(How = How.XPath, Using = "(//p[text()='ID:']/following-sibling::p/b)[1]")]
        public IWebElement firstID;

        [FindsBy(How = How.XPath, Using = "//p[text()='Name:']")]
        public IWebElement nameLabel;

        [FindsBy(How = How.XPath, Using = "(//p[text()='Name:']/following-sibling::p)[1]")]
        public IWebElement firstName;

        [FindsBy(How = How.XPath, Using = "//p[text()='Shared By:']")]
        public IWebElement sharedByLabel;

        [FindsBy(How = How.XPath, Using = "//div[@data-testid='letCarPrograms']")]
        public IWebElement sharedByLink;

        [FindsBy(How = How.XPath, Using = "//h6[@id='modal-modal-title']")]
        public IWebElement sharedByPopupHeading;

        [FindsBy(How = How.XPath, Using = "//div[@aria-label='ID']")]
        public IWebElement sharedByIDLabel;

        [FindsBy(How = How.XPath, Using = "//div[@aria-label='Version']")]
        public IWebElement sharedByVersionLabel;

        [FindsBy(How = How.XPath, Using = "//div[@aria-label='Program name']")]
        public IWebElement sharedByProgramLabel;

        [FindsBy(How = How.XPath, Using = "//div[@aria-label='Status']")]
        public IWebElement sharedByStatusLabel;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='exportButton']")]
        public IWebElement sharedByExport;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search..']")]
        private IWebElement searchBox;

        [FindsBy(How = How.XPath, Using = "//input[@id='combo-box-demo']")]
        private IWebElement statusBox;

        [FindsBy(How = How.XPath, Using = "//div[@data-testid='editLetCarIcon']/button")]
        private IWebElement editIcon;

        [FindsBy(How = How.XPath, Using = "//div[@role='dialog']//p")]
        public IWebElement editBOCLabel;

        [FindsBy(How = How.XPath, Using = "//div[@role='dialog']//p[text()='ID: ']/div")]
        public IWebElement editBOCID;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='duplicate']")]
        private IWebElement duplicateIcon;

        [FindsBy(How = How.XPath, Using = "//div[@role='dialog']//p")]
        public IWebElement duplicateBOCLabel;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='save']")]
        public IWebElement duplicateButton;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Deactivate']")]
        private IWebElement deactivateIcon;

        [FindsBy(How = How.XPath, Using = "//div[@role='dialog']//h2")]
        public IWebElement deactivateLabel;

        [FindsBy(How = How.XPath, Using = "//div[@role='dialog']//p")]
        public IWebElement deactivateMsg;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='okButton']")]
        public IWebElement deactivateButton;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='History']")]
        private IWebElement historyIcon;

        [FindsBy(How = How.XPath, Using = "//div[@role='dialog']//p")]
        public IWebElement viewHistoryLabel;

        [FindsBy(How = How.XPath, Using = "//div[@aria-label='ID']")]
        public IWebElement historyIDLabel;

        [FindsBy(How = How.XPath, Using = "//div[@aria-label='Version']")]
        public IWebElement historyVersionLabel;

        [FindsBy(How = How.XPath, Using = "//div[@aria-label='Date']")]
        public IWebElement historyDateLabel;

        [FindsBy(How = How.XPath, Using = "//div[@aria-label='Text']")]
        public IWebElement historyTextLabel;

        [FindsBy(How = How.XPath, Using = "//div[@aria-label='User']")]
        public IWebElement historyUserLabel;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='delete']")]
        private IWebElement deleteIcon;

        [FindsBy(How = How.XPath, Using = "//div[@role='dialog']//h2")]
        private IWebElement deleteBoxLabel;

        [FindsBy(How = How.XPath, Using = "//div[@role='dialog']//p")]
        public IWebElement deleteBoxMsg;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='okButton']")]
        private IWebElement deleteBoxDeleteBtn;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='cancelButton']")]
        private IWebElement deleteBoxCancelBtn;

        [FindsBy(How = How.XPath, Using = "//div[@data-testid='no-templates-message']/p")]
        private IWebElement noMatchFound;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Activate']")]
        private IWebElement activateIcon;

        [FindsBy(How = How.XPath, Using = "//div[@role='dialog']//h2")]
        private IWebElement activateBoxLabel;

        [FindsBy(How = How.XPath, Using = "//div[@role='dialog']//p")]
        public IWebElement activateBoxMsg;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='okButton']")]
        private IWebElement activateBoxActivateBtn;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='cancelButton']")]
        private IWebElement activateBoxCancelBtn;

        [FindsBy(How = How.XPath, Using = "//td[@data-testid='pagination']")]
        private IWebElement pagination;

        [FindsBy(How = How.XPath, Using = "//td[@data-testid='pagination']/div/p")]
        private IWebElement itemsPerPageLabel;

        [FindsBy(How = How.XPath, Using = "//td[@data-testid='pagination']//select")]
        private IWebElement itemsPerPageDropdown;

        public void ValidatePageTitle()
        {            
            Assert.That(BOCHeader.Displayed, Is.True);
            Assert.That(BOCHeader.Text, Is.EqualTo("BOC Templates"));
        }       

        public void VerifyPagination()
        {
            Browser.WaitForElement(itemsPerPageDropdown, 10);
            Assert.That(pagination.Displayed, Is.True);
            Assert.That(itemsPerPageLabel.Displayed, Is.True);
            Assert.That(itemsPerPageDropdown.Displayed, Is.True);            
            Assert.That(Extensions.GetAllOptionsFromSelectTagDropDown(itemsPerPageDropdown), Is.EqualTo(new List<string> {"10", "25", "50"}));
        }

        public string AddNewPlasticCardBackTemplate(string template, string name, string desc)
        {
            ValidatePageTitle();
            VerifyPagination();
            Browser.Click(addNewBOCTemplate);
            Browser.WaitForElement(newBOCLabel, 10);
            //Fill Add new BOC details
            selectTemplate.SendKeys(template);
            selectTemplate.SendKeys(Keys.Down + Keys.Enter);
            Thread.Sleep(2000);
            nameField.SendKeys(name);
            descField.SendKeys(desc);
            //Submit
            Browser.Click(saveButton);
            //Get toaster message
            Browser.WaitForElement(toasterMessage, 10);
            var toasterMessage_Text = toasterMessage.Text;
            Console.WriteLine(toasterMessage_Text);
            var toasterMessageID = Regex.Match(toasterMessage_Text, @"\d+").Value;
            //Get latest ID
            Thread.Sleep(4000);
            var firstIDText = firstID.Text;
            //Validate Toaster message            
            Assert.That(toasterMessage_Text, Is.EqualTo("BOC " + firstIDText + " Added Successfully."));
            //search and verify in Active status
            DriverUtilities.clearText(searchBox);
            searchBox.SendKeys(toasterMessageID);
            Browser.WaitForElement(firstID, 5);
            Assert.That(firstID.Text, Is.EqualTo(toasterMessageID));
            Assert.That(firstName.Text, Is.EqualTo(name));
            Assert.That(statusBox.GetAttributeValue("value"), Is.EqualTo("Active"));
            //validate dashboard
            Assert.That(idLabel.Displayed, Is.True);
            Assert.That(nameLabel.Displayed, Is.True);
            Assert.That(sharedByLabel.Displayed, Is.True);
            //search and verify No match 
            DriverUtilities.clearText(searchBox);
            searchBox.SendKeys(RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 5));
            Browser.WaitForElement(noMatchFound, 5);
            Assert.That(noMatchFound.Text, Is.EqualTo("\"No Tempates under the selected PCL.\""));
            return toasterMessageID;            
        }

        public string EditPlasticCardBackTemplate(string template, string name, string desc, string newName, string newDesc)
        {
            ValidatePageTitle();
            string createdID = AddNewPlasticCardBackTemplate(template, name, desc);
            //Search and Edit
            DriverUtilities.clearText(searchBox);
            searchBox.SendKeys(createdID);
            Browser.WaitForElement(editIcon, 10);
            Browser.Click(editIcon);
            Browser.WaitForElement(editBOCLabel, 10);
            Assert.That(editBOCLabel.Text, Is.EqualTo("Edit BOC"));
            Assert.That(editBOCID.Text, Is.EqualTo(createdID));
            //Enter new details
            DriverUtilities.clearText(nameField);
            nameField.SendKeys(newName);
            DriverUtilities.clearText(descField);
            descField.SendKeys(newDesc);
            //Update
            Browser.Click(saveButton);            
            //Get toaster message
            Browser.WaitForElement(toasterMessage, 10);
            var toasterMessage_Text = toasterMessage.Text;
            Console.WriteLine(toasterMessage_Text);
            var toasterMessageID = Regex.Match(toasterMessage_Text, @"\d+").Value;
            //Validate Toaster message
            Assert.That(createdID, Is.EqualTo(toasterMessageID));
            Assert.That(toasterMessage_Text, Is.EqualTo("BOC " + createdID + " Updated Successfully."));
            //search and verify in Active status
            DriverUtilities.clearText(searchBox);
            searchBox.SendKeys(toasterMessageID);
            Browser.WaitForElement(firstID, 5);
            Assert.That(firstID.Text, Is.EqualTo(toasterMessageID));
            Assert.That(firstName.Text, Is.EqualTo(newName));
            Assert.That(statusBox.GetAttributeValue("value"), Is.EqualTo("Active"));
            return createdID;
        }    
        
        public void ValidatePlasticCardBackTemplate()
        {
            ValidatePageTitle();
            //Validate 
            Browser.WaitForElement(addNewBOCTemplate, 10);
            Browser.Click(addNewBOCTemplate);
            Browser.WaitForElement(newBOCLabel, 10);
            //validate Add New BOC Template pop up
            Assert.That(newBOCLabel.Text, Is.EqualTo("New BOC"));
            Assert.That(selectTemplate.Displayed, Is.True);
            Assert.That(nameField.Displayed, Is.True);
            Assert.That(descField.Displayed, Is.True);
            Assert.That(saveButton.Displayed, Is.True);
            Assert.That(cancelButton.Displayed, Is.True);
            //Submit without inputs
            Browser.Click(saveButton);
            //Validate all messages
            Assert.That(selectTemplateMsg.Text, Is.EqualTo("The Base Template field is required."));
            Assert.That(nameFieldMsg.Text, Is.EqualTo("The Name field is required."));
            Assert.That(descFieldMsg.Text, Is.EqualTo("The Description field is required."));
            //Validate character limit
            nameField.SendKeys(RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 501));
            descField.SendKeys(RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 501));
            Assert.That(nameField.GetAttributeValue("value").Length, Is.EqualTo(100));
            Assert.That(descField.GetAttributeValue("value").Length, Is.EqualTo(200));
        }

        public void DuplicatePlasticCardBackTemplate(string template, string name, string desc, string newName, string newDesc)
        {
            ValidatePageTitle();
            string createdID = AddNewPlasticCardBackTemplate(template, name, desc);
            //Search and Duplicate
            DriverUtilities.clearText(searchBox);
            searchBox.SendKeys(createdID);
            Browser.WaitForElement(duplicateIcon, 10);
            Browser.Click(duplicateIcon);
            Browser.WaitForElement(duplicateBOCLabel, 10);
            Assert.That(duplicateBOCLabel.Text, Is.EqualTo("Duplicate BOC"));            
            //Enter new details
            DriverUtilities.clearText(nameField);
            nameField.SendKeys(newName);
            DriverUtilities.clearText(descField);
            descField.SendKeys(newDesc);
            //Duplicate
            Browser.Click(duplicateButton);
            //Get toaster message
            Browser.WaitForElement(toasterMessage, 10);
            var toasterMessage_Text = toasterMessage.Text;
            Console.WriteLine(toasterMessage_Text);
            var toasterMessageID = Regex.Match(toasterMessage_Text, @"\d+").Value;
            //Get latest ID
            DriverUtilities.clearText(searchBox);
            Thread.Sleep(4000);
            var firstIDText = firstID.Text;
            //Validate Toaster message
            Assert.That(firstIDText, Is.EqualTo(toasterMessageID));
            Assert.That(toasterMessage_Text, Is.EqualTo("BOC " + firstIDText + " Added Successfully."));
            //search and verify in Active status
            DriverUtilities.clearText(searchBox);
            searchBox.SendKeys(toasterMessageID);
            Browser.WaitForElement(firstID, 5);
            Assert.That(firstID.Text, Is.EqualTo(toasterMessageID));
            Assert.That(firstName.Text, Is.EqualTo(newName));
            Assert.That(statusBox.GetAttributeValue("value"), Is.EqualTo("Active"));
        }

        public string DeactivatePlasticCardBackTemplate(string template, string name, string desc)
        {
            ValidatePageTitle();
            string createdID = AddNewPlasticCardBackTemplate(template, name, desc);
            //Search and Duplicate
            DriverUtilities.clearText(searchBox);
            searchBox.SendKeys(createdID);
            Browser.WaitForElement(deactivateIcon, 10);
            Browser.Click(deactivateIcon);
            Browser.WaitForElement(deactivateMsg, 10);
            Assert.That(deactivateMsg.Text, Is.EqualTo("Are you sure you want to Deactivate Back Card Template ID \""+ createdID + "\" ?"));            
            //Deactivate
            Browser.Click(deactivateButton);
            //Get toaster message
            Browser.WaitForElement(toasterMessage, 10);
            var toasterMessage_Text = toasterMessage.Text;
            Console.WriteLine(toasterMessage_Text);
            var toasterMessageID = Regex.Match(toasterMessage_Text, @"\d+").Value;
            //Validate Toaster message
            //TODO- Need to change the toaster message as per US                         
            Assert.That(createdID, Is.EqualTo(toasterMessageID));
            Assert.That(toasterMessage_Text, Is.EqualTo("Plastic Card " + createdID + " Updated Successfully."));
            //search and verify in Inactive status
            DriverUtilities.clearText(statusBox);
            statusBox.SendKeys("Inactive");
            statusBox.SendKeys(Keys.Down + Keys.Enter);
            DriverUtilities.clearText(searchBox);
            searchBox.SendKeys(toasterMessageID);
            Browser.WaitForElement(firstID, 5);
            Assert.That(firstID.Text, Is.EqualTo(toasterMessageID));
            Assert.That(firstName.Text, Is.EqualTo(name));
            Assert.That(statusBox.GetAttributeValue("value"), Is.EqualTo("Inactive"));
            return createdID;
        }

        public void ViewHistoryPlasticCardBackTemplate(string template, string name, string desc, string newName, string newDesc)
        {
            ValidatePageTitle();
            string createdID = EditPlasticCardBackTemplate(template, name, desc,newName,newDesc);
            //Search and View History
            DriverUtilities.clearText(searchBox);
            searchBox.SendKeys(createdID);
            Browser.WaitForElement(historyIcon, 10);
            Browser.Click(historyIcon);
            Browser.WaitForElement(viewHistoryLabel, 10);
            Assert.That(viewHistoryLabel.Text, Is.EqualTo("View History"));  
            Thread.Sleep(3000);
            //validate all fields in view history popup
            Assert.That(historyIDLabel.Displayed, Is.True);
            Assert.That(historyVersionLabel.Displayed, Is.True);
            Assert.That(historyDateLabel.Displayed, Is.True);
            Assert.That(historyTextLabel.Displayed, Is.True);
            Assert.That(historyUserLabel.Displayed, Is.True);
            //ToDo: Export functionality as per US
        }

        public void ViewSharedByPlasticCardBackTemplate(string template, string name, string desc)
        {
            ValidatePageTitle();
            string createdID = AddNewPlasticCardBackTemplate(template, name, desc);
            //Search and View History
            DriverUtilities.clearText(searchBox);
            searchBox.SendKeys(createdID);
            Browser.WaitForElement(sharedByLabel, 10);
            Assert.That(sharedByLabel.Displayed, Is.True);
            Browser.Click(sharedByLink);
            Browser.WaitForElement(sharedByPopupHeading, 10);
            Assert.That(sharedByPopupHeading.Text, Is.EqualTo("Shared programs"));
            Thread.Sleep(3000);
            //validate all fields in Shared By popup
            Assert.That(sharedByIDLabel.Displayed, Is.True);
            Assert.That(sharedByVersionLabel.Displayed, Is.True);
            Assert.That(sharedByProgramLabel.Displayed, Is.True);
            Assert.That(sharedByStatusLabel.Displayed, Is.True);
            //validate export functionality
            Browser.Click(sharedByExport);            
            Thread.Sleep(4000);
            bool fileStatus = Extensions.IsFileDownloaded("data.csv");
            Assert.That(fileStatus, Is.True);
        }

        public void DeletePlasticCardBackTemplate(string template, string name, string desc)
        {
            ValidatePageTitle();
            string createdID = DeactivatePlasticCardBackTemplate(template, name, desc);
            //Delete Plastic Card Back Template
            Browser.WaitForElement(deleteIcon, 10);
            Browser.Click(deleteIcon);
            Browser.WaitForElement(deleteBoxLabel, 10);
            Assert.That(deleteBoxLabel.Text, Is.EqualTo("Delete"));            
            Assert.That(deleteBoxMsg.Text, Is.EqualTo("Are you sure you want to Delete the Back Card Template ID \"" + createdID + "\" ?"));
            //Delete
            Browser.Click(deleteBoxDeleteBtn);
            //Get toaster message
            Browser.WaitForElement(toasterMessage, 10);
            var toasterMessage_Text = toasterMessage.Text;
            Console.WriteLine(toasterMessage_Text);
            var toasterMessageID = Regex.Match(toasterMessage_Text, @"\d+").Value;
            //Validate Toaster message
            //TODO- Need to change the toaster message as per US                         
            Assert.That(createdID, Is.EqualTo(toasterMessageID));
            Assert.That(toasterMessage_Text, Is.EqualTo("Plastic Card " + createdID + " Deleted Successfully."));
            //search and verify no match in Inactive status
            DriverUtilities.clearText(statusBox);
            statusBox.SendKeys("Inactive");
            statusBox.SendKeys(Keys.Down + Keys.Enter);
            DriverUtilities.clearText(searchBox);
            searchBox.SendKeys(toasterMessageID);
            Browser.WaitForElement(noMatchFound, 5);
            Assert.That(noMatchFound.Text, Is.EqualTo("\"No Tempates under the selected PCL.\""));            
        }

        public void ActivatePlasticCardBackTemplate(string template, string name, string desc)
        {
            ValidatePageTitle();
            string createdID = DeactivatePlasticCardBackTemplate(template, name, desc);
            //Activate Plastic Card Back Template
            Browser.WaitForElement(activateIcon, 10);
            Browser.Click(activateIcon);
            Browser.WaitForElement(activateBoxLabel, 10);
            Assert.That(activateBoxLabel.Text, Is.EqualTo("Activate"));
            Assert.That(activateBoxMsg.Text, Is.EqualTo("Are you sure you want to Activate Back Card Template ID \"" + createdID + "\" ?"));
            //Activate
            Browser.Click(activateBoxActivateBtn);
            //Get toaster message
            Browser.WaitForElement(toasterMessage, 10);
            var toasterMessage_Text = toasterMessage.Text;
            Console.WriteLine(toasterMessage_Text);
            var toasterMessageID = Regex.Match(toasterMessage_Text, @"\d+").Value;
            //Validate Toaster message
            //TODO- Need to change the toaster message as per US                         
            Assert.That(createdID, Is.EqualTo(toasterMessageID));
            Assert.That(toasterMessage_Text, Is.EqualTo("Plastic Card " + createdID + " Updated Successfully."));
            //search and verify no match in Inactive status
            DriverUtilities.clearText(statusBox);
            statusBox.SendKeys("Inactive");
            statusBox.SendKeys(Keys.Down + Keys.Enter);
            DriverUtilities.clearText(searchBox);
            searchBox.SendKeys(toasterMessageID);
            Browser.WaitForElement(noMatchFound, 5);
            Assert.That(noMatchFound.Text, Is.EqualTo("\"No Tempates under the selected PCL.\""));
            //search and verify Active status
            DriverUtilities.clearText(statusBox);
            statusBox.SendKeys("Active");
            statusBox.SendKeys(Keys.Down + Keys.Enter);
            DriverUtilities.clearText(searchBox);
            searchBox.SendKeys(toasterMessageID);            
            Browser.WaitForElement(firstID, 5);
            Assert.That(firstID.Text, Is.EqualTo(toasterMessageID));
            Assert.That(firstName.Text, Is.EqualTo(name));
            Assert.That(statusBox.GetAttributeValue("value"), Is.EqualTo("Active"));
            //validate dashboard
            Assert.That(idLabel.Displayed, Is.True);
            Assert.That(nameLabel.Displayed, Is.True);
            Assert.That(sharedByLabel.Displayed, Is.True);
        }
    }
}
