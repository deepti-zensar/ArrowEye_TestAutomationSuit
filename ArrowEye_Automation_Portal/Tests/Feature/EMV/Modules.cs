using ArrowEye_Automation_Framework;
using ArrowEye_Automation_Framework.Common;
using NUnit.Framework;
using RandomString4Net;

namespace ArrowEye_Automation_Portal.Tests.Feature.EMV
{
    public class Modules : TestBase
    {
        string userName = "portaltestuser";
        string password = "Admin123@";
        public string getRandomString()
        {            
            return RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 5); ;
        }        
        
        [Test]
        [Description("EMV_Module_Create")]
        [Category("Smoke")]
        [TestCase("Automation_Create_Module_", "Automation_Module", "Traveller_Automation", "CMI_Automation","123")]            
        public void Create_New_EMV_Module(string name, string description, string travellerLabel, string cmiProgram, string groupId)
        {
            CP_Pages.Login.LogIn(userName,password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("EMV");
            CP_Pages.Home.NavigateToSubmenu("Modules");            
            CP_Pages.EMVModulesPage.AddNewModule(name + getRandomString(), description, travellerLabel, cmiProgram, groupId);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("EMV_Modules_Edit")]
        [Category("Smoke")]
        [TestCase("Automation_Create_Module_", "Automation_Module", "Traveller_Automation", "CMI_Automation", "546")]
        public void Edit_EMV_Modules(string name, string description, string travellerLabel, string cmiProgram, string groupId)
        {
            CP_Pages.Login.LogIn(userName,password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("EMV");
            CP_Pages.Home.NavigateToSubmenu("Modules");
            CP_Pages.EMVModulesPage.EditModules(name + getRandomString(), description, travellerLabel, cmiProgram, groupId);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("EMV_Modules_Validations")]
        [Category("Smoke")]
        public void Validate_EMV_Modules()
        {
            CP_Pages.Login.LogIn(userName,password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("EMV");
            CP_Pages.Home.NavigateToSubmenu("Modules");
            CP_Pages.EMVModulesPage.ValidateEMVModules();
            DriverUtilities.TakeScreenshot(@"C:\");
        }        

        [Test]
        [Description("EMV_Modules_Homepage_View")]
        [Category("Smoke")]
        [TestCase("ID", "Name", "Description", "Travel Label", "CMI Program", "Group ID", "Module LOA", "Actions", "Shared By")]
        public void EMV_Modules_Homepage_View(params string[] listOfOptions)
        {
            CP_Pages.Login.LogIn(userName,password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("EMV");
            CP_Pages.Home.NavigateToSubmenu("Modules");
            CP_Pages.EMVModulesPage.EMVModulesHomepageView(listOfOptions);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("EMV_Module_Export")]
        [Category("Smoke")]
        [TestCase("ASI Portal.csv")]
        public void EMV_Modules_Export(string fileName)
        {
            CP_Pages.Login.LogIn(userName,password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("EMV");
            CP_Pages.Home.NavigateToSubmenu("Modules");
            CP_Pages.EMVModulesPage.EMVModulesExport(fileName);
            DriverUtilities.TakeScreenshot(@"C:\");
        }
    }
}
