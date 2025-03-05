using ArrowEye_Automation_Framework;
using ArrowEye_Automation_Framework.Common;
using NUnit.Framework;
using RandomString4Net;

namespace ArrowEye_Automation_Portal.Tests.Feature
{
    [TestFixture]
    public class ConfigurationHierarchy : TestBase
    {
        string userName = "sbabu";
        string password = "Sudarshan@12345";
        public string getRandomString()
        {
            return RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 5); ;
        }

        [Test]
        [Description("Configuration_Hierarchy_Edit")]
        [Category("Smoke")]
        [TestCase("Program Profile Test", "Automation_","Automation_")]
        public void Edit_ConfigurationHierarchy(string attributeName, string newAttributeValue,string description)
        {
            CP_Pages.Login.LogIn(userName,password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Configuration Hierarchy");
            CP_Pages.ConfigurationHierarchyPage.EditConfigurationHierarchy(attributeName,newAttributeValue + getRandomString(), description+ getRandomString());
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("Configuration_Hierarchy_Delete")]
        [Category("Smoke")]
        [TestCase("Client","")]
        public void Delete_ConfigurationHierarchy(string attributeLevel,string attributeName)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Configuration Hierarchy");
            CP_Pages.ConfigurationHierarchyPage.DeleteConfigurationHierarchy(attributeLevel,attributeName);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("Configuration_Hierarchy_Validate")]
        [Category("Smoke")]
        [TestCase("")]
        public void Validate_Configuration_Hierarchy(string attributeName)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Configuration Hierarchy");
            CP_Pages.ConfigurationHierarchyPage.ValidateConfigurationHierarchy(attributeName);
            DriverUtilities.TakeScreenshot(@"C:\");
        }
        
        [Test]
        [Description("Configuration_Hierarchy_Homepage_View")]
        [Category("Smoke")]
        [TestCase("ID", "Attribute Level", "Attribute ID", "Data Type", "Attribute Name", "Attribute Value", "IsNullable","Description", "Actions")]
        public void HomepageView_ConfigurationHierarchy(params string[] listOfOptions)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Configuration Hierarchy");
            CP_Pages.ConfigurationHierarchyPage.ConfigurationHierarchyHomepageView(listOfOptions);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("Configuration_Hierarchy_Export")]
        [Category("Smoke")]
        [TestCase("React App.csv")]
        public void Export_ConfigurationHierarchy(string fileName)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Configuration Hierarchy");
            CP_Pages.ConfigurationHierarchyPage.ConfigurationHierarchyExport(fileName);
            DriverUtilities.TakeScreenshot(@"C:\");
        }
    }
}
