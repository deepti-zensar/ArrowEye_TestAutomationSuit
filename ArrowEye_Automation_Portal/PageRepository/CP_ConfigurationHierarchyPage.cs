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
    public class CP_ConfigurationHierarchyPage
    {
        [FindsBy(How = How.XPath, Using = "//div[@data-testid='DataTable']//p[text()='Configuration Hierarchy']")]
        public IWebElement configurationHierarchyText;

        [FindsBy(How = How.XPath, Using = "//label[text()='Attribute Level']")]
        public IWebElement attributeLevelLabel;

        [FindsBy(How = How.XPath, Using = "//label[text()='Attribute Level']/following-sibling::div/input")]
        public IWebElement attributeLevelField;

        [FindsBy(How = How.XPath, Using = "//label[text()='Attribute Name']")]
        public IWebElement attributeNameLabel;

        [FindsBy(How = How.XPath, Using = "//label[text()='Attribute Name']/following-sibling::div/input")]
        public IWebElement attributeNameField;

        [FindsBy(How = How.XPath, Using = "//label[text()='Data Type']")]
        public IWebElement dataTypeLabel;

        [FindsBy(How = How.XPath, Using = "//label[text()='Attribute Name']/following-sibling::div/input")]
        public IWebElement dataTypeField;

        [FindsBy(How = How.XPath, Using = "//label[text()='Attribute ID']")]
        public IWebElement attributeIDLabel;

        [FindsBy(How = How.XPath, Using = "//label[text()='Attribute ID']/following-sibling::div/input")]
        public IWebElement attributeIDField;

        [FindsBy(How = How.XPath, Using = "//label[text()='Attribute Value']")]
        public IWebElement attributeValueLabel;

        [FindsBy(How = How.XPath, Using = "//label[text()='Attribute Value']/following-sibling::div/input[@data-testid='attribute_value']")]
        public IWebElement editAttributeValueField;

        [FindsBy(How = How.XPath, Using = "//label[text()='IsNullable']")]
        public IWebElement isNullableLabel;

        [FindsBy(How = How.XPath, Using = "//label[text()='IsNullable']/following-sibling::div/input")]
        public IWebElement isNullableField;

        [FindsBy(How = How.XPath, Using = "//label[text()='Description']")]
        public IWebElement descriptionLabel;

        [FindsBy(How = How.XPath, Using = "//label[text()='Description']/following-sibling::div/input[@data-testid='descriptionInput']")]
        public IWebElement editDescriptionField;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='cancelButton']")]
        private IWebElement cancelButton;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='saveButton']")]
        private IWebElement saveButton;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search…']")]
        private IWebElement searchBox;

        [FindsBy(How = How.XPath, Using = "//div[@id='notistack-snackbar']")]
        private IWebElement toasterMessage;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='1'])[position()=1]")]
        private IWebElement searchedID;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='2'])[position()=1]")]
        private IWebElement searchedAttributeLevel;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='3'])[position()=1]")]
        private IWebElement searchedAttributeID;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='4'])[position()=1]")]
        private IWebElement searchedDataType;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='5'])[position()=1]")]
        private IWebElement searchedAttributeName;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='6'])[position()=1]")]
        private IWebElement searchedAttributeValue;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='7'])[position()=1]")]
        private IWebElement searchedIsNullable;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='8'])[position()=1]")]
        private IWebElement searchedDescription;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='deleteData']")]
        private IWebElement deleteButton;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='editData']")]
        private IWebElement editButton;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Edit Configuration Hierarchy')]")]
        public IWebElement editDialogBoxText;

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

        [FindsBy(How = How.XPath, Using = "//label[text()='Attribute Value']/following-sibling::p")]
        public IWebElement attributeValueErrorMsg;

        [FindsBy(How = How.XPath, Using = "//label[text()='Description']/parent::div/following-sibling::p")]
        public IWebElement descriptionLimitText;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitleContainerContent']/div)")]
        public IList<IWebElement> tableHeaderProofReplacement { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Export']")]
        public IWebElement configurationHierarchyExport;

        [FindsBy(How = How.XPath, Using = "//li[@role='menuitem']")]
        public IWebElement downloadCSV;

        public void ValidatePageTitle()
        {
           // DriverUtilities.IsElementPresent(defaultProofReplacementText);
            Assert.That(configurationHierarchyText.Text, Is.EqualTo("Configuration Hierarchy"));
        }       

        // To Search record by replacement value
        public void SearchProofReplacement(string replacementValue)
        {
            DriverUtilities.clearText(searchBox);            
            searchBox.SendKeys(replacementValue);
            Thread.Sleep(3000);
        }


        public void EditConfigurationHierarchy(string attributeName, string newAttributeValue, string description)
        {
            ValidatePageTitle();
            //Search with Attribute Name
            DriverUtilities.clearText(searchBox);
            searchBox.SendKeys(attributeName);
            Thread.Sleep(3000);
            var configurationHierarchyID = searchedID.Text;
            var attributeID = searchedAttributeID.Text;
            
            //Edit record details 
            Browser.Click(editButton);
            Thread.Sleep(2000);
            Assert.That(editDialogBoxText.Text, Is.EqualTo("Edit Configuration Hierarchy"));
            var attributeIDFrmEdit = attributeIDField.GetAttributeValue("value");            
            DriverUtilities.clearText(editAttributeValueField);
            editAttributeValueField.SendKeys(newAttributeValue);  
            DriverUtilities.clearText(editDescriptionField);
            editDescriptionField.SendKeys(description);
            Browser.Click(saveButton);
            Thread.Sleep(2000);
            Assert.That(attributeID, Is.EqualTo(attributeIDFrmEdit));

            //validate Toaster message
            var toasterMessage_Text = toasterMessage.Text;
            Assert.That(toasterMessage_Text, Is.EqualTo("Configuration Hierarchy " + configurationHierarchyID + " updated successfully."));

            //Search with newly edited record and get information from search result          
            DriverUtilities.clearText(searchBox);
            searchBox.SendKeys(newAttributeValue);
            Thread.Sleep(3000);
            var editedAttributeValue = searchedAttributeValue.Text;
            var editedDescription = searchedDescription.Text;

            //validate newly edited record in homepage
            Assert.That(editedAttributeValue, Is.EqualTo(newAttributeValue));
            Assert.That(editedDescription, Is.EqualTo(description));        

        }

        public void DeleteConfigurationHierarchy(string attributeName)
        {
            ValidatePageTitle();
            //Search with Attribute Name
            DriverUtilities.clearText(searchBox);
            searchBox.SendKeys(attributeName);
            Thread.Sleep(3000);
            var attributeID = searchedAttributeID.Text;
            var configurationHierarchyID = searchedID.Text;
            //TODO: Get all the details of the delete record
            //Delete details 
            Browser.Click(deleteButton);
            Assert.That(deleteDialogBoxTitle.Text, Is.EqualTo("Delete"));
            var deleteDialogBoxMessage = deleteDialogBoxText.Text;
            Browser.Click(deleteBoxCancelBtn);
            Browser.Click(deleteButton);
            Browser.Click(deleteBoxDeleteBtn);
            Thread.Sleep(2000);

            //validate delete popup message            
            Assert.That(deleteDialogBoxMessage, Is.EqualTo("Are you sure you want to delete this Attribute " + attributeID + "?"));

            //validate Delete Toaster message
            var toasterMessage_Text = toasterMessage.Text;
            Assert.That(toasterMessage_Text, Is.EqualTo("Configuration Hierarchy " + configurationHierarchyID + " deleted successfully."));

            //Search with newly Deleted record        
            DriverUtilities.clearText(searchBox);
            searchBox.SendKeys(attributeName);
            Thread.Sleep(3000);
            Assert.That(noResultFound.Text, Is.EqualTo("No results found."));

        }

        public void ValidateConfigurationHierarchy(string attributeName)
        {
            ValidatePageTitle();
            //Search with Attribute Name
            DriverUtilities.clearText(searchBox);
            searchBox.SendKeys(attributeName);
            Thread.Sleep(3000);
            var configurationHierarchyID = searchedID.Text;
            var attributeID = searchedAttributeID.Text;

            //Validate attribute name error message
            Browser.Click(editButton);
            Thread.Sleep(2000);
            Assert.That(editDialogBoxText.Text, Is.EqualTo("Edit Configuration Hierarchy"));
            var attributeNameEdit = attributeNameField.GetAttributeValue("value");
            DriverUtilities.clearText(editAttributeValueField);            
            DriverUtilities.clearText(editDescriptionField);            
            Browser.Click(saveButton);
            Thread.Sleep(2000);
            Assert.That(attributeValueErrorMsg.Text, Is.EqualTo("The value for the Configuration Hierarchy '"+ attributeNameEdit + "' may not be null."));
                        
            //CHARACTER LIMITATIONS FOR Description
            //create new record with longer data
            string longString = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 155);
            editDescriptionField.SendKeys(longString);            
            Assert.That(descriptionLimitText.Text, Is.EqualTo("150/150"));
            //Browser.Click(saveButton);   

        }


        //To validate Configuration Hierarchy homepage table headers
        public void ConfigurationHierarchyHomepageView(string[] listOfOptions)
        {
            List<string> expectedListOfOptions = new List<string>(listOfOptions);
            List<string> actualListOfOptions = new List<string>();
            foreach (IWebElement actualOption in tableHeaderProofReplacement)
            {
                actualListOfOptions.Add(actualOption.Text);
            }
            Assert.That(actualListOfOptions, Is.EquivalentTo(expectedListOfOptions));
        }

        //To export Configuration Hierarchy data
        public void ConfigurationHierarchyExport(string fileName)
        {
            Browser.Click(configurationHierarchyExport);
            Browser.Click(downloadCSV);
            Thread.Sleep(4000);
            bool fileStatus = Extensions.IsFileDownloaded(fileName);
            Assert.That(fileStatus, Is.True);
        }
    }
}
