using ArrowEye_Automation_Framework;
using ArrowEye_Automation_Framework.Common;
using NUnit.Framework;
using RandomString4Net;

namespace ArrowEye_Automation_Portal.Tests.Feature.EMV
{
    public class Configurations : TestBase
    {
        string userName = "portaltestuser";
        string password = "Admin123@";
        public string getRandomString()
        {            
            return RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 5); ;
        }

        [Test]
        [Description("EMV_Configurations_Create")]
        [Category("Smoke")]    
        [TestCase("Automation_Create_Configurations_", "Automation Testing", "Automation Testing", "", "","",false)]
        public void Create_New_EMV_Configurations(string name, string issuer, string cardProfile, string personalizationScript, string module, string authentication, bool isInTest)
        {
            CP_Pages.Login.LogIn(userName,password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("EMV");
            CP_Pages.Home.NavigateToSubmenu("Configurations");
            CP_Pages.EMVConfigurationsPage.AddNewConfigurations(name + getRandomString(), issuer, cardProfile, personalizationScript, module, authentication, isInTest);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("EMV_Configurations_Edit")]
        [Category("Smoke")]
        [TestCase("Automation_Edit_Configurations_", "Automation Testing", "Automation Testing", "", "", "", false)]
        public void Edit_EMV_Configurations(string name, string issuer, string cardProfile, string personalizationScript, string module, string authentication, bool isInTest)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("EMV");
            CP_Pages.Home.NavigateToSubmenu("Configurations");
            CP_Pages.EMVConfigurationsPage.EditConfigurations(name + getRandomString(), issuer, cardProfile, personalizationScript, module, authentication, isInTest);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("EMV_Options_View")]
        [Category("Smoke")]
        [TestCase("Authentications", "Card Profiles", "Configurations", "Issuers", "Scripts", "Modules")]
        public void EMV_Options_View(params string[] listOfOptions)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("EMV");
            CP_Pages.EMVIssuersPage.EMVOptionsView(listOfOptions);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("EMV_Configurations_Homepage_View")]
        [Category("Smoke")]
        [TestCase("ID", "Name", "Issuer ID", "Issuer Name", "Card Profile ID", "Card Profile Name", "Personalization ID","Personalization Name",
                "Module ID", "Module Name", "Auth. ID", "Auth. Name", "Is In Test?", "Shared By", "Actions")]
        public void EMV_Configurations_Homepage_View(params string[] listOfOptions)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("EMV");
            CP_Pages.Home.NavigateToSubmenu("Configurations");
            CP_Pages.EMVConfigurationsPage.EMVConfigurationsHomepageView(listOfOptions);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("EMV_Configurations_Export")]
        [Category("Smoke")]
        [TestCase("React App.csv")]
        public void EMV_Configurations_Export(string fileName)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("EMV");
            CP_Pages.Home.NavigateToSubmenu("Configurations");
            CP_Pages.EMVConfigurationsPage.EMVConfigurationsExport(fileName);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("EMV_Configurations_Validations")]
        [Category("Smoke")]
        public void Validate_EMV_Configurations()
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("EMV");
            CP_Pages.Home.NavigateToSubmenu("Configurations"); ;
            CP_Pages.EMVConfigurationsPage.ValidateEMVConfigurations();
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("EMV_Configurations_Clone")]
        [Category("Smoke")]
        [TestCase("Automation_New_Configurations_", "Automation Testing", "Automation Testing", "", "", "",false, "Automation_issuer", "Automation_CardProfile")]
        public void Clone_EMV_Configurations(string name, string issuer, string cardProfile, string personalizationScript, string module, string authentication, bool isInTest, string newIssuer, string newCardProfile)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("EMV");
            CP_Pages.Home.NavigateToSubmenu("Configurations");
            CP_Pages.EMVConfigurationsPage.CloneConfigurationss(name + getRandomString(), issuer, cardProfile, personalizationScript, module, authentication, isInTest,newIssuer,newCardProfile);
            DriverUtilities.TakeScreenshot(@"C:\");
        }
    }
}
