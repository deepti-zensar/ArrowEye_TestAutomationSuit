using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using ArrowEye_Automation_Framework;
using ArrowEye_Automation_Framework.Common;
using NUnit.Framework;
using OpenQA.Selenium;
using RandomString4Net;
using SeleniumExtras.PageObjects;

namespace ArrowEye_Automation_Portal.PageRepository
{
    public class CP_EMV_ConfigurationsPage : TestBase
    {
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'EMV Configurations')]")]
        public IWebElement emvConfigurationsText;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Add New')]")]
        public IWebElement addNewConfigurations;

        [FindsBy(How = How.XPath, Using = "//p[text()='New EMV Configurations']")]
        public IWebElement newConfigurationsDialogBoxText;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='nameInputField']")]
        public IWebElement nameField;

        [FindsBy(How = How.XPath, Using = "//label[text()='Issuer']/following-sibling::div/input[@id='combo-box-demo']")]
        public IWebElement issuerDropDown;

        [FindsBy(How = How.XPath, Using = "//label[text()='Card Profile']/following-sibling::div/input[@id='combo-box-demo']")]
        public IWebElement cardProfileDropDown;

        [FindsBy(How = How.XPath, Using = "//label[text()='Personalization Script']/following-sibling::div/input[@id='combo-box-demo']")]
        public IWebElement personalizationScriptDropDown;

        [FindsBy(How = How.XPath, Using = "//label[text()='Module']/following-sibling::div/input[@id='combo-box-demo']")]
        private IWebElement moduleDropDown;

        [FindsBy(How = How.XPath, Using = "//label[text()='Authentication']/following-sibling::div/input[@id='combo-box-demo']")]
        private IWebElement authenticationDropDown;

        [FindsBy(How = How.XPath, Using = "//input[@name='inTest']")]
        private IWebElement isInTestCheckbox;

        [FindsBy(How = How.XPath, Using = "//input[@name='inTest']/parent::span")]
        private IWebElement isInTestCheckboxClass;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='cancelConfiguration']")]
        private IWebElement cancelButton;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='saveConfiguration']")]
        private IWebElement saveButton;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search…']")]
        private IWebElement searchBox;

        [FindsBy(How = How.XPath, Using = "//div[@id='notistack-snackbar']")]
        private IWebElement toasterMessage;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='1'])[position()=1]")]
        private IWebElement emvConfigurations_ID;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='2'])[position()=1]")]
        private IWebElement emvConfigurations_Name;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='3'])[position()=1]")]
        private IWebElement emvConfigurations_IssuerID;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='4'])[position()=1]")]
        private IWebElement emvConfigurations_IssuerName;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='5'])[position()=1]")]
        private IWebElement emvConfigurations_CardProfileID;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='6'])[position()=1]")]
        private IWebElement emvConfigurations_CardProfileName;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='7'])[position()=1]")]
        private IWebElement emvConfigurations_PersonalizationID;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='8'])[position()=1]")]
        private IWebElement emvConfigurations_PersonalizationName;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='9'])[position()=1]")]
        private IWebElement emvConfigurations_ModuleID;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='10'])[position()=1]")]
        private IWebElement emvConfigurations_ModuleName;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='11'])[position()=1]")]
        private IWebElement emvConfigurations_AuthID;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='12'])[position()=1]")]
        private IWebElement emvConfigurations_AuthName;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='13'])[position()=1]")]
        private IWebElement emvConfigurations_IsInTest;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='14'])[position()=1]")]
        private IWebElement emvConfigurations_SharedBy;

        [FindsBy(How = How.XPath, Using = "(//button[@data-testid='editData'])[position()=1]")]
        private IWebElement emvConfigurationsEditButton;

        [FindsBy(How = How.XPath, Using = "(//button[@data-testid='cloneIcon'])[position()=1]")]
        private IWebElement emvConfigurationsCloneButton;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'MuiDataGrid-scrollbar--horizontal')]")]
        public IWebElement horizontalScrollBar;

        [FindsBy(How = How.XPath, Using = "//p[text()='Update EMV Configurations']")]
        public IWebElement editConfigurationssDialogBoxText;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'ID')]/div")]
        private IWebElement editedEMVConfigurationsID;

        [FindsBy(How = How.XPath, Using = "//p[text()='New EMV Configurations']")]
        public IWebElement cloneConfigurationssDialogBoxText;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Select columns']")]
        private IWebElement columnsButton;

        [FindsBy(How = How.XPath, Using = "//span[contains(@class,'MuiFormControlLabel-label')][not(text()= 'Row reordering' or text()='Show/Hide All')]")]
        public IList<IWebElement> columnList { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Name is required')]")]
        public IWebElement nameRequiredText;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Issuer is required')]")]
        public IWebElement issuerRequiredText;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Card Profile is required')]")]
        public IWebElement cardProfileRequiredText;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Personalization Script is required')]")]
        public IWebElement personalizationScriptRequiredText;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Module is required')]")]
        public IWebElement moduleRequiredText;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Authentication is required')]")]
        public IWebElement authenticationRequiredText;

        [FindsBy(How = How.XPath, Using = "(//p[contains(@id,'helper-text')])[1]")]
        public IWebElement nameSizeLimitMsg;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitleContainerContent']/div)")]
        public IList<IWebElement> tableHeaderEMVConfigurations { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Export']")]
        public IWebElement emvConfigurationssExport;

        [FindsBy(How = How.XPath, Using = "//li[@role='menuitem']")]
        public IWebElement downloadCSV;

        public void ValidatePageTitle()
        {
           // DriverUtilities.IsElementPresent(emvConfigurationsText);
            Assert.That(emvConfigurationsText.Text, Is.EqualTo("EMV Configurations"));
        }

        public void ValidateNewConfigurationsDialogBox()
        {
            // DriverUtilities.IsElementPresent(newConfigurationsDialogBoxText);
            Assert.That(newConfigurationsDialogBoxText.Text, Is.EqualTo("New EMV Configurations"));            
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

        // To fill EMV Configurations details
        public void FillEMVConfigurationsDetails(string name, string issuer, string cardProfile, string personalizationScript, string module, string authentication, bool isInTest)
        {
            nameField.SendKeys(Keys.Control + "a");
            nameField.SendKeys(Keys.Control + "x");
            nameField.SendKeys(name);
            SelectDropDownValue(issuerDropDown, issuer);
            SelectDropDownValue(cardProfileDropDown, cardProfile);
            SelectDropDownValue(personalizationScriptDropDown, personalizationScript);
            SelectDropDownValue(moduleDropDown, module);
            SelectDropDownValue(authenticationDropDown, authentication);
            if (isInTest == true)
                isInTestCheckbox.Click();          
        }

        // To fill EMV Configurations details for Cloning
        public void FillEMVConfigurationsDetailsClone(string name, string issuer, string cardProfile)
        {
            nameField.SendKeys(Keys.Control + "a");
            nameField.SendKeys(Keys.Control + "x");
            nameField.SendKeys(name);
            SelectDropDownValue(issuerDropDown, issuer);
            SelectDropDownValue(cardProfileDropDown, cardProfile);           
        }

        // To Search EMV Configurations 
        public void SearchEMVConfigurationsName(string name)
        {
            searchBox.SendKeys(Keys.Control + "a");
            searchBox.SendKeys(Keys.Control + "x");
            searchBox.SendKeys(name);
            Thread.Sleep(3000);
        }

        //To check default value of Is In Test checkbox
        public void checkDefaultValueOfIsInTestCheckbox()
        {   
            if (isInTestCheckboxClass.GetAttributeValue("class").Contains("Mui-checked"))
            {
                Assert.Fail("Is In Test checkbox is checked by default");
            }
        }

        public void AddNewConfigurations(string name, string issuer, string cardProfile, string personalizationScript, string module, string authentication, bool isInTest)
        {
            ValidatePageTitle();
            // Add new Configurations and fill EMV Configurations details
            Browser.Click(addNewConfigurations);
            ValidateNewConfigurationsDialogBox();
            checkDefaultValueOfIsInTestCheckbox();
            Browser.Click(cancelButton);
            Thread.Sleep(2000);
            Browser.Click(addNewConfigurations);  
            FillEMVConfigurationsDetails(name, issuer, cardProfile, personalizationScript, module, authentication, isInTest);
            Browser.Click(saveButton);
            Thread.Sleep(2000);

            //get Toaster message
            var toasterMessage_Text = toasterMessage.Text;

            //Search with newly created record
            SearchEMVConfigurationsName(name);
            var created_EMVConfigurations_Record_ID = emvConfigurations_ID.Text;
            var created_EMVConfigurations_Record_Name = emvConfigurations_Name.Text;
            Assert.That(created_EMVConfigurations_Record_Name, Is.EqualTo(name));

            //validate Toaster message
            Assert.That(toasterMessage_Text, Is.EqualTo("EMV Configuration " + created_EMVConfigurations_Record_ID + " Added Successfully."));
        }

        public void EditConfigurations(string name, string issuer, string cardProfile, string personalizationScript, string module, string authentication, bool isInTest)
        {
            ValidatePageTitle();
            // Add new Configurations and fill EMV Configurations details           
            Browser.Click(addNewConfigurations);
            FillEMVConfigurationsDetails(name, issuer, cardProfile, personalizationScript, module, authentication, isInTest);
            Browser.Click(saveButton);
            Thread.Sleep(2000);

            //Search with newly created record
            SearchEMVConfigurationsName(name);
            var created_EMVConfigurations_Record_ID = emvConfigurations_ID.Text;
            var created_EMVConfigurations_Record_Name = emvConfigurations_Name.Text;
            Assert.That(created_EMVConfigurations_Record_Name, Is.EqualTo(name));

            //Edit EMV Configurations details 
            Browser.Click(emvConfigurationsEditButton);
            Thread.Sleep(2000);
            Assert.That(editConfigurationssDialogBoxText.Text, Is.EqualTo("Update EMV Configurations"));
            var edited_EMVConfigurations_Record_ID = editedEMVConfigurationsID.Text;
            var newName = name + "_Updated";           
            FillEMVConfigurationsDetails(newName, issuer, cardProfile, personalizationScript, module, authentication, isInTest);
            var newEMVConfigurationsIssuer = issuerDropDown.GetAttributeValue("value");
            var newEMVConfigurationsCardProfile = cardProfileDropDown.GetAttributeValue("value");
            var newEMVConfigurationsPersonalizationScript = personalizationScriptDropDown.GetAttributeValue("value");
            var newEMVConfigurationsModule = moduleDropDown.GetAttributeValue("value");
            var newEMVConfigurationsAuthentication = authenticationDropDown.GetAttributeValue("value");
            Browser.Click(saveButton);
            Thread.Sleep(2000);

            //validate Toaster message
            var toasterMessage_Text = toasterMessage.Text;
            Assert.That(toasterMessage_Text, Is.EqualTo("EMV Configuration " + edited_EMVConfigurations_Record_ID + " Updated Successfully."));

            //Search with newly edited record and get information from search result          
            SearchEMVConfigurationsName(newName);
            var edited_EMVConfigurationss_Record_Name = emvConfigurations_Name.Text;
            var edited_EMVConfigurationss_Record_Issuer = emvConfigurations_IssuerName.Text;
            var edited_EMVConfigurationss_Record_CardProfile = emvConfigurations_CardProfileName.Text;
            var edited_EMVConfigurationss_Record_PersonalizationScript = emvConfigurations_PersonalizationName.Text;
            var edited_EMVConfigurationss_Record_Module = emvConfigurations_ModuleName.Text;

            //validate newly edited record in EMV Configurations homepage
            Assert.That(edited_EMVConfigurations_Record_ID, Is.EqualTo(created_EMVConfigurations_Record_ID));
            Assert.That(edited_EMVConfigurationss_Record_Name, Is.EqualTo(newName));
            Assert.That(edited_EMVConfigurationss_Record_Issuer, Is.EqualTo(newEMVConfigurationsIssuer));
            Assert.That(edited_EMVConfigurationss_Record_CardProfile, Is.EqualTo(newEMVConfigurationsCardProfile));
            Assert.That(edited_EMVConfigurationss_Record_PersonalizationScript, Is.EqualTo(newEMVConfigurationsPersonalizationScript));
            Assert.That(edited_EMVConfigurationss_Record_Module, Is.EqualTo(newEMVConfigurationsModule));            
        }

        //To validate EMV Configurations homepage table headers
        public void EMVConfigurationsHomepageView(string[] listOfOptions)
        {
            columnsButton.Click();
            List<string> expectedListOfOptions = new List<string>(listOfOptions);
            List<string> actualListOfOptions = new List<string>();
            foreach (IWebElement actualOption in columnList)
            {               
                actualListOfOptions.Add(actualOption.Text);               
            }            
            Assert.That(actualListOfOptions, Is.EqualTo(expectedListOfOptions));
        }

        //To validate EMV Configurations Export
        public void EMVConfigurationsExport(string fileName)
        {
            Browser.Click(emvConfigurationssExport);
            Browser.Click(downloadCSV);
            Thread.Sleep(4000);
            bool fileStatus = Extensions.IsFileDownloaded(fileName);
            Assert.That(fileStatus, Is.True);
        }

        //All validations for EMV Configurations
        public void ValidateEMVConfigurations()
        {
            ValidatePageTitle();
            //ADD NEW EMV Configurations WITHOUT ANY DETAILS AND VALIDATE MESSAGE
            Browser.Click(addNewConfigurations);
            ValidateNewConfigurationsDialogBox();
            Browser.Click(saveButton);
            Assert.That(nameRequiredText.Text, Is.EqualTo("Name is required"));
            Assert.That(issuerRequiredText.Text, Is.EqualTo("Issuer is required"));
            Assert.That(cardProfileRequiredText.Text, Is.EqualTo("Card Profile is required"));
            Assert.That(personalizationScriptRequiredText.Text, Is.EqualTo("Personalization Script is required"));
            Assert.That(moduleRequiredText.Text, Is.EqualTo("Module is required"));
            Assert.That(authenticationRequiredText.Text, Is.EqualTo("Authentication is required"));

            //Validate CHARACTER LIMITATIONS MESSAGES FOR FIELDS            
            string longString = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 155);
            nameField.SendKeys(Keys.Control + "a");
            nameField.SendKeys(Keys.Control + "x");
            nameField.SendKeys(longString);
            Assert.That(nameSizeLimitMsg.Text, Is.EqualTo("150/150"));

        }

        public void CloneConfigurationss(string name, string issuer, string cardProfile, string personalizationScript, string module, string authentication, bool isInTest, string newIssuer, string newCardProfile)
        {
            ValidatePageTitle();
            // Add new Configurations and fill EMV Configurations details                
            Browser.Click(addNewConfigurations);
            FillEMVConfigurationsDetails(name, issuer, cardProfile, personalizationScript, module, authentication, isInTest);
            Browser.Click(saveButton);
            Thread.Sleep(2000);

            //Search with newly created record
            SearchEMVConfigurationsName(name);
            var created_EMVConfigurations_Record_ID = emvConfigurations_ID.Text;
            var created_EMVConfigurations_Record_Name = emvConfigurations_Name.Text;
            Assert.That(created_EMVConfigurations_Record_Name, Is.EqualTo(name));

            //Clone EMV Configurations details 
            Browser.Click(emvConfigurationsCloneButton);
            Thread.Sleep(2000);
            Assert.That(cloneConfigurationssDialogBoxText.Text, Is.EqualTo("New EMV Configurations"));
            Assert.That(nameField.GetAttributeValue("value"), Is.EqualTo(string.Empty));
            Assert.That(issuerDropDown.GetAttributeValue("value"), Is.EqualTo(string.Empty));
            Assert.That(cardProfileDropDown.GetAttributeValue("value"), Is.EqualTo(string.Empty));
            var newName = name + "_Clone";
            FillEMVConfigurationsDetailsClone(newName, newIssuer, newCardProfile);
            var newEMVConfigurationsIssuer = issuerDropDown.GetAttributeValue("value");
            var newEMVConfigurationsCardProfile = cardProfileDropDown.GetAttributeValue("value");
            var newEMVConfigurationsPersonalizationScript = personalizationScriptDropDown.GetAttributeValue("value");
            var newEMVConfigurationsModule = moduleDropDown.GetAttributeValue("value");
            var newEMVConfigurationsAuthentication = authenticationDropDown.GetAttributeValue("value");
            Browser.Click(saveButton);
            Thread.Sleep(2000);

            //validate Toaster message
            var toasterMessage_Text = toasterMessage.Text;
            var toasterMessageID = Regex.Match(toasterMessage_Text, @"\d+").Value;            

            //Search with newly cloned record and get information from search result          
            SearchEMVConfigurationsName(newName);
            var cloned_EMVConfigurations_Record_ID = emvConfigurations_ID.Text;
            var cloned_EMVConfigurationss_Record_Name = emvConfigurations_Name.Text;
            var cloned_EMVConfigurationss_Record_Issuer = emvConfigurations_IssuerName.Text;
            var cloned_EMVConfigurationss_Record_CardProfile = emvConfigurations_CardProfileName.Text;
            var cloned_EMVConfigurationss_Record_PersonalizationScript = emvConfigurations_PersonalizationName.Text;
            var cloned_EMVConfigurationss_Record_Module = emvConfigurations_ModuleName.Text;

            //validate Toaster message           
            Assert.That(toasterMessage_Text, Is.EqualTo("EMV Configuration " + cloned_EMVConfigurations_Record_ID + " Cloned and Added Successfully."));

            //validate newly cloned record in EMV Configurations homepage
            Assert.That(cloned_EMVConfigurations_Record_ID, Is.EqualTo(toasterMessageID));
            Assert.That(cloned_EMVConfigurationss_Record_Name, Is.EqualTo(newName));
            Assert.That(cloned_EMVConfigurationss_Record_Issuer, Is.EqualTo(newEMVConfigurationsIssuer));
            Assert.That(cloned_EMVConfigurationss_Record_CardProfile, Is.EqualTo(newEMVConfigurationsCardProfile));
            Assert.That(cloned_EMVConfigurationss_Record_PersonalizationScript, Is.EqualTo(newEMVConfigurationsPersonalizationScript));
            Assert.That(cloned_EMVConfigurationss_Record_Module, Is.EqualTo(newEMVConfigurationsModule));
        }

    }
}
