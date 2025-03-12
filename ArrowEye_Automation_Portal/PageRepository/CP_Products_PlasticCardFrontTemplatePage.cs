using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using ArrowEye_Automation_Framework.Common;
using NUnit.Framework;
using OpenQA.Selenium;
using RandomString4Net;
using SeleniumExtras.PageObjects;

namespace ArrowEye_Automation_Portal.PageRepository
{
    public class CP_Products_PlasticCardFrontTemplatePage
    {
        [FindsBy(How = How.XPath, Using = "//h5[text()='FOC Templates']")]
        public IWebElement FOCHeader;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='AddButton']")]
        public IWebElement addNewFOCTemplate;

        [FindsBy(How = How.XPath, Using = "//div[@role='dialog']//p")]
        public IWebElement newFOCLabel;

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

        [FindsBy(How = How.XPath, Using = "(//p[text()='ID:']/following-sibling::p/b)[1]")]
        public IWebElement firstID;

        [FindsBy(How = How.XPath, Using = "(//p[text()='Name:']/following-sibling::p)[1]")]
        public IWebElement firstName;        

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search..']")]
        private IWebElement searchBox;

        [FindsBy(How = How.XPath, Using = "//input[@id='combo-box-demo']")]
        private IWebElement statusBox;

        [FindsBy(How = How.XPath, Using = "//div[@data-testid='editLetCarIcon']/button")]
        private IWebElement editIcon;

        [FindsBy(How = How.XPath, Using = "//div[@role='dialog']//p")]
        public IWebElement editFOCLabel;

        [FindsBy(How = How.XPath, Using = "//div[@role='dialog']//p[text()='ID: ']/div")]
        public IWebElement editFOCID;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='deleteIcon']")]
        private IWebElement deleteButton;

        [FindsBy(How = How.XPath, Using = "//div[@role='dialog']//h2")]
        private IWebElement deleteBoxLabel;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='okButton']")]
        private IWebElement deleteBoxDeleteBtn;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='cancelButton']")]
        private IWebElement deleteBoxCancelBtn;

        [FindsBy(How = How.XPath, Using = "//div[@data-testid='no data']/p")]
        private IWebElement noMatchFound;

        public void ValidatePageTitle()
        {            
            Assert.That(FOCHeader.Displayed, Is.True);
            Assert.That(FOCHeader.Text, Is.EqualTo("FOC Templates"));
        }        

        public string AddNewPlasticCardFrontTemplate(string template, string name, string desc)
        {
            ValidatePageTitle();
            Browser.Click(addNewFOCTemplate);
            Browser.WaitForElement(newFOCLabel, 10);            
            //Fill Add new FOC details
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
            Assert.That(toasterMessage_Text, Is.EqualTo("FOC " + firstIDText + " Added Successfully."));
            //search and verify in Active status
            DriverUtilities.clearText(searchBox);
            searchBox.SendKeys(toasterMessageID);
            Browser.WaitForElement(firstID, 5);
            Assert.That(firstID.Text, Is.EqualTo(toasterMessageID));
            Assert.That(firstName.Text, Is.EqualTo(name));
            Assert.That(statusBox.GetAttributeValue("value"), Is.EqualTo("Active"));
            return toasterMessageID;
        }

        public void EditPlasticCardFrontTemplate(string template, string name, string desc, string newName, string newDesc)
        {
            ValidatePageTitle();
            string createdID = AddNewPlasticCardFrontTemplate(template, name, desc);
            //Search and Edit
            DriverUtilities.clearText(searchBox);
            searchBox.SendKeys(createdID);
            Browser.WaitForElement(editIcon, 10);
            Browser.Click(editIcon);
            Browser.WaitForElement(editFOCLabel, 10);
            Assert.That(editFOCLabel.Text, Is.EqualTo("Edit FOC"));
            Assert.That(editFOCID.Text, Is.EqualTo(createdID));
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
            Assert.That(toasterMessage_Text, Is.EqualTo("FOC " + createdID + " Updated Successfully."));
            //search and verify in Active status
            DriverUtilities.clearText(searchBox);
            searchBox.SendKeys(toasterMessageID);
            Browser.WaitForElement(firstID, 5);
            Assert.That(firstID.Text, Is.EqualTo(toasterMessageID));
            Assert.That(firstName.Text, Is.EqualTo(newName));
            Assert.That(statusBox.GetAttributeValue("value"), Is.EqualTo("Active"));
        }

        //public void DeletePINMailer(string carrierTitle, string desc, string partOf, string carrierStatus, string colorMode)
        //{
        //    ValidatePageTitle();
        //    string createdID = AddNewPINMailer(carrierTitle, desc, partOf, carrierStatus, colorMode);
        //    //Search and Edit
        //    DriverUtilities.clearText(searchBox);
        //    searchBox.SendKeys(createdID);
        //    Browser.WaitForElement(editIcon, 10);
        //    Browser.Click(editIcon);
        //    Browser.WaitForElement(editCarrierLabel, 10);
        //    Assert.That(editCarrierLabel.Text, Does.Contain(createdID));
        //    //Delete
        //    if (!deleteButton.Enabled)
        //    {
        //        selectCarrierStatusOption("Turned off");
        //        Browser.Click(submitButton);
        //        Browser.WaitForElement(searchBox, 10);
        //        DriverUtilities.clearText(searchBox);
        //        searchBox.SendKeys(createdID);
        //        Thread.Sleep(2000);
        //        Browser.WaitForElement(editIcon, 10);
        //        Browser.Click(editIcon);
        //        Browser.WaitForElement(editCarrierLabel, 10);

        //    }
        //    Browser.Click(deleteButton); 
        //    //Handle delete pop up 
        //    Browser.WaitForElement(deleteBoxLabel, 10);
        //    Assert.That(deleteBoxLabel.Text, Is.EqualTo("Delete Pin Mailer"));
        //    Browser.Click(deleteBoxDeleteBtn);
        //    //Get toaster message
        //    Browser.WaitForElement(toasterMessage, 10);
        //    var toasterMessage_Text = toasterMessage.Text;
        //    Console.WriteLine(toasterMessage_Text);
        //    var toasterMessageID = Regex.Match(toasterMessage_Text, @"\d+").Value;
        //    //Validate Toaster message
        //    Assert.That(createdID, Is.EqualTo(toasterMessageID));
        //    Assert.That(toasterMessage_Text, Is.EqualTo("Pin Mailer " + createdID + " Deleted Successfully."));
        //    //Validate no result
        //    DriverUtilities.clearText(searchBox);
        //    searchBox.SendKeys(createdID);
        //    Thread.Sleep(2000);
        //    Browser.WaitForElement(noMatchFound, 10);
        //    Assert.That(noMatchFound.Text, Is.EqualTo("No Match found"));
        //}

        public void ValidatePlasticCardFrontTemplate()
        {
            ValidatePageTitle();
            //Validate 
            Browser.WaitForElement(addNewFOCTemplate, 10);
            Browser.Click(addNewFOCTemplate);
            Browser.WaitForElement(newFOCLabel, 10);
            //validate Add New FOC Template pop up
            Assert.That(newFOCLabel.Text, Is.EqualTo("New FOC"));
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
    }
}
