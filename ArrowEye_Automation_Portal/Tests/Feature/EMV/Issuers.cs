using ArrowEye_Automation_Framework;
using ArrowEye_Automation_Framework.Common;
using NUnit.Framework;
using RandomString4Net;

namespace ArrowEye_Automation_Portal.Tests.Feature.EMV
{
    [TestFixture]
    public class Issuers : TestBase
    {
        string userName = "portaltestuser";
        string password = "Admin123@";
        public string getRandomString()
        {
            return RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 5); ;
        }

        [Test]
        [Description("EMV_Issuer_Create")]
        [Category("Smoke")]
        [TestCase("Automation_Create_Issuer_Certified_", "123", "Certified", "Testing Issuer")]        
        public void Create_New_EMV_Issuer(string name, string cpv, string appPath, string notes)
        {
            CP_Pages.Login.LogIn(userName,password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("EMV");
            CP_Pages.Home.NavigateToSubmenu("Issuers");            
            CP_Pages.EMVIssuersPage.AddNewIssuer(name + getRandomString(), cpv, appPath, notes);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("EMV_Issuer_Edit")]
        [Category("Smoke")]
        [TestCase("Automation_Edit_Issuer_", "678", "Certified", "Testing Issuer", "PE")]        
        public void Edit_EMV_Issuer(string name, string cpv, string appPath, string notes, string newAppPath)
        {
            CP_Pages.Login.LogIn(userName,password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("EMV");
            CP_Pages.Home.NavigateToSubmenu("Issuers");
            CP_Pages.EMVIssuersPage.EditIssuer(name + getRandomString(), cpv, appPath, notes, newAppPath);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("EMV_Issuer_Validate")]
        [Category("Smoke")]
        [TestCase("Automation_EMV_Issuer_Validation_", "234", "Certified", "Testing Issuer")]        
        public void Validate_EMV_Issuer(string name, string cpv, string appPath, string notes)
        {
            CP_Pages.Login.LogIn(userName,password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("EMV");
            CP_Pages.Home.NavigateToSubmenu("Issuers");
            CP_Pages.EMVIssuersPage.ValidateEMVIssuer(name + getRandomString(), cpv, appPath, notes);
            DriverUtilities.TakeScreenshot(@"C:\");
        }        

        [Test]
        [Description("EMV_Issuer_Homepage_View")]
        [Category("Smoke")]
        [TestCase("ID", "Name", "CPV / PVT Number", "Approval Path", "Notes", "Actions")]
        public void EMV_Issuer_Homepage_View(params string[] listOfOptions)
        {
            CP_Pages.Login.LogIn(userName,password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("EMV");
            CP_Pages.Home.NavigateToSubmenu("Issuers");
            CP_Pages.EMVIssuersPage.EMVIssuerHomepageView(listOfOptions);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("EMV_Issuer_Export")]
        [Category("Smoke")]
        [TestCase("ASI Portal.csv")]
        public void EMV_Issuer_Export(string fileName)
        {
            CP_Pages.Login.LogIn(userName,password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("EMV");
            CP_Pages.Home.NavigateToSubmenu("Issuers");
            CP_Pages.EMVIssuersPage.EMVIssuerExport(fileName);
            DriverUtilities.TakeScreenshot(@"C:\");
        }
    }
}
