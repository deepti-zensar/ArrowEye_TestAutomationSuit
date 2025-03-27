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
using Extensions = ArrowEye_Automation_Framework.Common.Extensions;

namespace ArrowEye_Automation_Portal.PageRepository
{
    public class CP_EMV_ModulesPage
    {
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'EMV Module')]")]
        public IWebElement emvModulesText;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Add New')]")]
        public IWebElement addNewModule;

        [FindsBy(How = How.XPath, Using = "//p[text()='New Module']")]
        public IWebElement newModuleDialogBoxText;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='nameInputField']")]
        public IWebElement nameField;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='descriptionInputField']")]
        public IWebElement descriptionField;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='travelerLabelInputField']")]
        public IWebElement travellerLabelField;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='cmiProgInputField']")]
        public IWebElement cmiProgramField;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='groupIdInputField']")]
        private IWebElement groupIdField;

        [FindsBy(How = How.XPath, Using = "//div[@data-testid='DatePicker']//label")]
        private IWebElement expirationDateLabel;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='cancelScripts']")]
        private IWebElement cancelButton;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='saveModules']")]
        private IWebElement saveButton;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search…']")]
        private IWebElement searchBox;

        [FindsBy(How = How.XPath, Using = "//div[@id='notistack-snackbar']")]
        private IWebElement toasterMessage;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='1'])[position()=1]")]
        private IWebElement createdEMVModuleID;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='2'])[position()=1]")]
        private IWebElement createdEMVModuleName;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='3'])[position()=1]")]
        private IWebElement createdEMVModuleDesc;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='4'])[position()=1]")]
        private IWebElement createdEMVModuleTravelLabel;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='5'])[position()=1]")]
        private IWebElement createdEMVModuleCMIProg;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='6'])[position()=1]")]
        private IWebElement createdEMVModuleGroupId;

        [FindsBy(How = How.XPath, Using = "(//button[@data-testid='edit'])[position()=1]")]
        private IWebElement emvModuleEditButton;

        [FindsBy(How = How.XPath, Using = "//p[text()='Update Module']")]
        public IWebElement editModulesDialogBoxText;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'ID')]/div")]
        private IWebElement editedEMVModuleID;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The Name field is required.')]")]
        public IWebElement nameRequiredText;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The Description field is required.')]")]
        public IWebElement descRequiredText;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'The Group ID field is required.')]")]
        public IWebElement groupIdRequiredText;

        [FindsBy(How = How.XPath, Using = "(//p[contains(@id,'helper-text')])[1]")]
        public IWebElement nameSizeLimitMsg;

        [FindsBy(How = How.XPath, Using = "(//p[contains(@id,'helper-text')])[2]")]
        public IWebElement descSizeLimitMsg;

        [FindsBy(How = How.XPath, Using = "(//p[contains(@id,'helper-text')])[3]")]
        public IWebElement travellerLabelSizeLimitMsg;

        [FindsBy(How = How.XPath, Using = "(//p[contains(@id,'helper-text')])[4]")]
        public IWebElement cmiSizeLimitMsg;

        [FindsBy(How = How.XPath, Using = "(//p[contains(@id,'helper-text')])[5]")]
        public IWebElement groupIdErrorMsg;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Expiration Date cannot be past date.')] ")]
        public IWebElement expDateMessage;

        [FindsBy(How = How.XPath, Using = "(//li[@id='subMenuItems']/p)")]
        public IList<IWebElement> emvOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitleContainerContent']/div)")]
        public IList<IWebElement> tableHeaderEMVModules { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Export']")]
        public IWebElement emvModulesExport;

        [FindsBy(How = How.XPath, Using = "//li[@role='menuitem']")]
        public IWebElement downloadCSV;

        public void ValidatePageTitle()
        {
            Browser.WaitForElement(emvModulesText, 10);
            Assert.That(emvModulesText.Displayed, Is.True);
            Assert.That(emvModulesText.Text, Is.EqualTo("EMV Module"));
        }

        public void ValidateNewModuleDialogBox()
        {
            Assert.That(newModuleDialogBoxText.Displayed, Is.True);
            Assert.That(newModuleDialogBoxText.Text, Is.EqualTo("New Module"));            
        }
        // To fill EMV Module details
        public void FillEMVModuleDetails(string name, string description, string travellerLabel, string cmiProgram, string groupId)
        {
            nameField.SendKeys(Keys.Control + "a");
            nameField.SendKeys(Keys.Control + "x");
            nameField.SendKeys(name);
            descriptionField.SendKeys(Keys.Control + "a");
            descriptionField.SendKeys(Keys.Control + "x");
            descriptionField.SendKeys(description);
            if (travellerLabel != null||travellerLabel!="")
            {
                travellerLabelField.SendKeys(Keys.Control + "a");
                travellerLabelField.SendKeys(Keys.Control + "x");
                travellerLabelField.SendKeys(travellerLabel);
            }
            if (cmiProgram != null|| cmiProgram != "")
            {
                cmiProgramField.SendKeys(Keys.Control + "a");
                cmiProgramField.SendKeys(Keys.Control + "x");
                cmiProgramField.SendKeys(cmiProgram);
            }
            groupIdField.SendKeys(Keys.Control + "a");
            groupIdField.SendKeys(Keys.Control + "x");
            groupIdField.SendKeys(groupId);
        }

        // To Search EMV Module
        public void SearchEMVModuleName(string name)
        {
            searchBox.SendKeys(Keys.Control + "a");
            searchBox.SendKeys(Keys.Control + "x");
            searchBox.SendKeys(name);
            Thread.Sleep(3000);
        }

        public void AddNewModule(string name, string description, string travellerLabel, string cmiProgram, string groupId)
        {
            ValidatePageTitle();
            // Add new Module and fill EMV Module details
            Browser.Click(addNewModule);
            ValidateNewModuleDialogBox();
            Browser.Click(cancelButton);
            Thread.Sleep(2000);
            Browser.Click(addNewModule);
            FillEMVModuleDetails(name, description, travellerLabel, cmiProgram, groupId);
            Browser.Click(saveButton);
            Thread.Sleep(2000);
            //get Toaster message
            var toasterMessage_Text = toasterMessage.Text;
            //Search with newly created record and validate information from search result
            SearchEMVModuleName(name);
            var created_EMVModule_Record_ID = createdEMVModuleID.Text;            
            Assert.That(createdEMVModuleID.Text, Is.EqualTo(created_EMVModule_Record_ID));
            Assert.That(createdEMVModuleName.Text, Is.EqualTo(name));
            Assert.That(createdEMVModuleDesc.Text, Is.EqualTo(description));
            Assert.That(createdEMVModuleTravelLabel.Text, Is.EqualTo(travellerLabel));
            Assert.That(createdEMVModuleCMIProg.Text, Is.EqualTo(cmiProgram));
            Assert.That(createdEMVModuleGroupId.Text, Is.EqualTo(groupId));
            //validate Toaster message
            Assert.That(toasterMessage_Text, Is.EqualTo("EMV Module " + created_EMVModule_Record_ID + " Added Successfully."));            
        }

        public void EditModules(string name, string description, string travellerLabel, string cmiProgram, string groupId)
        {
            ValidatePageTitle();
            // Add new Modules and fill EMV Modules details            
            Browser.Click(addNewModule);
            FillEMVModuleDetails(name, description, travellerLabel, cmiProgram, groupId);
            Browser.Click(saveButton);
            Thread.Sleep(2000);
            //Search with newly created record
            SearchEMVModuleName(name);
            var created_EMVModule_Record_ID = createdEMVModuleID.Text;
            var created_EMVModule_Record_Name = createdEMVModuleName.Text;
            Assert.That(created_EMVModule_Record_Name, Is.EqualTo(name));
            //Edit EMV Module details 
            Browser.Click(emvModuleEditButton);
            Thread.Sleep(2000);
            Assert.That(editModulesDialogBoxText.Text, Is.EqualTo("Update Module"));
            var edited_EMVModule_Record_ID = editedEMVModuleID.Text;
            var newName = name + "_Updated";
            var newDescription = description + "_Updated";
            var newTravellerLabel = travellerLabel + "_Updated";
            var newCMIProgram = cmiProgram + "_Updated";
            var newGroupId =  (int.Parse(groupId) + 1).ToString();
            FillEMVModuleDetails(newName, newDescription, newTravellerLabel, newCMIProgram, newGroupId);
            Browser.Click(saveButton);
            Thread.Sleep(2000);
            //validate Toaster message
            var toasterMessage_Text = toasterMessage.Text;
            Assert.That(toasterMessage_Text, Is.EqualTo("EMV Module " + edited_EMVModule_Record_ID + " Updated Successfully."));
            //Search with newly edited record and get information from search result          
            SearchEMVModuleName(newName);
            var edited_EMVModules_Record_Name = createdEMVModuleName.Text;
            var edited_EMVModules_Record_Desc = createdEMVModuleDesc.Text;
            var edited_EMVModules_Record_TravelLabel = createdEMVModuleTravelLabel.Text;
            var edited_EMVModules_Record_CMIProg = createdEMVModuleCMIProg.Text;
            var edited_EMVModules_Record_GroupId = createdEMVModuleGroupId.Text;
            //validate newly edited record in EMV Module homepage
            Assert.That(edited_EMVModule_Record_ID, Is.EqualTo(created_EMVModule_Record_ID));
            Assert.That(edited_EMVModules_Record_Name, Is.EqualTo(newName));
            Assert.That(edited_EMVModules_Record_Desc, Is.EqualTo(newDescription));
            Assert.That(edited_EMVModules_Record_TravelLabel, Is.EqualTo(newTravellerLabel));
            Assert.That(edited_EMVModules_Record_CMIProg, Is.EqualTo(newCMIProgram));
            Assert.That(edited_EMVModules_Record_GroupId, Is.EqualTo(newGroupId));
        }

        public void ValidateEMVModules()
        {
            ValidatePageTitle();
            //ADD NEW EMV MODULE WITHOUT ANY DETAILS AND VALIDATE MESSAGE
            Browser.Click(addNewModule);
            ValidateNewModuleDialogBox();
            Browser.Click(saveButton);
            Assert.That(nameRequiredText.Text, Is.EqualTo("The Name field is required."));
            Assert.That(descRequiredText.Text, Is.EqualTo("The Description field is required."));
            Assert.That(groupIdRequiredText.Text, Is.EqualTo("The Group ID field is required."));
            //Validate CHARACTER LIMITATIONS MESSAGES FOR FIELDS            
            string longString1 = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 55);
            string longString2 = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 105);
            FillEMVModuleDetails(longString1, longString2, longString2, longString2, "12345");
            Assert.That(nameSizeLimitMsg.Text, Is.EqualTo("50/50"));
            Assert.That(descSizeLimitMsg.Text, Is.EqualTo("100/100"));
            Assert.That(travellerLabelSizeLimitMsg.Text, Is.EqualTo("100/100"));
            Assert.That(cmiSizeLimitMsg.Text, Is.EqualTo("100/100"));
            //Validate Group ID message
            Assert.That(groupIdErrorMsg.Text, Is.EqualTo("Only accepted values are numbers from 1 to 999."));                    
        }

        //To validate EMV Modules homepage table headers
        public void EMVModulesHomepageView(string[] listOfOptions)
        {
            ValidatePageTitle();
            Extensions.CompareActualExpectedLists(listOfOptions, tableHeaderEMVModules);
        }

        //To validate EMV Modules Export
        public void EMVModulesExport(string fileName)
        {
            Browser.Click(emvModulesExport);
            Browser.Click(downloadCSV);
            Thread.Sleep(4000);
            bool fileStatus = Extensions.IsFileDownloaded(fileName);
            Assert.That(fileStatus, Is.True);
        }
    }
}
