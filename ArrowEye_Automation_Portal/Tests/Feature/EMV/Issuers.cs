using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrowEye_Automation_Framework;
using ArrowEye_Automation_Framework.Common;
using NUnit.Framework;
using RandomString4Net;

namespace ArrowEye_Automation_Portal.Tests.Feature
{
    [TestFixture]
    public class Issuers : TestBase
    {
        string randomString = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 5);
        
        [Test]
        [Description("EMV_Issuer_Create")]
        [Category("Smoke")]
        [TestCase("Automation_Create_Issuer_Certified_", "123", "Certified", "Testing Issuer")]
        // [TestCase("Automation_Create_Issuer_CNS_","123","CNS","Testing Issuer")]
        // [TestCase("Automation_Create_Issuer_EasyPath_","123","EasyPath","Testing Issuer")]
        // [TestCase("Automation_Create_Issuer_PE_","123","PE","Testing Issuer")]
        public void Create_New_EMV_Issuer(string name, string cpv, string appPath, string notes)
        {
            CP_Pages.Login.LogIn("sbabu", "Sudarshan@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToIssuers();
            CP_Pages.EMVIssuersPage.AddNewIssuer(name + randomString, cpv, appPath, notes);
            //DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("EMV_Issuer_Edit")]
        [Category("Smoke")]
        [TestCase("Automation_Edit_Issuer_", "123", "Certified", "Testing Issuer", "PE")]
        // [TestCase("Automation_Create_EMV_Issuer_CNS_","123","CNS","Testing Issuer")]
        // [TestCase("Automation_Create_EMV_Issuer_EasyPath_","123","EasyPath","Testing Issuer")]
        // [TestCase("Automation_Create_EMV_Issuer_PE_","123","PE","Testing Issuer")]
        public void Edit_EMV_Issuer(string name, string cpv, string appPath, string notes, string newAppPath)
        {
            CP_Pages.Login.LogIn("sbabu", "Sudarshan@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToIssuers();
            CP_Pages.EMVIssuersPage.EditIssuer(name + randomString, cpv, appPath, notes, newAppPath);
            // DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("EMV_Issuer_Validate")]
        [Category("Smoke")]
        [TestCase("Automation_EMV_Issuer_Validation_", "123", "Certified", "Testing Issuer")]
        // [TestCase("Automation_Create_EMV_Issuer_CNS_","123","CNS","Testing Issuer")]
        // [TestCase("Automation_Create_EMV_Issuer_EasyPath_","123","EasyPath","Testing Issuer")]
        // [TestCase("Automation_Create_EMV_Issuer_PE_","123","PE","Testing Issuer")]
        public void Validate_EMV_Issuer(string name, string cpv, string appPath, string notes)
        {
            CP_Pages.Login.LogIn("sbabu", "Sudarshan@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToIssuers();
            CP_Pages.EMVIssuersPage.ValidateEMVIssuer(name + randomString, cpv, appPath, notes);
            //DriverUtilities.TakeScreenshot(@"C:\");
        }
        
        [Test]
        [Description("EMV_Options_View")]
        [Category("Smoke")]        
        [TestCase("Authentications", "Card Profiles","Configurations","Issuers","Scripts","Modules")]        
        public void EMV_Options_View(params string[] listOfOptions)
        {
            CP_Pages.Login.LogIn("sbabu", "Sudarshan@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToEMV();
            CP_Pages.EMVIssuersPage.EMVOptionsView(listOfOptions);
            //DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("EMV_Issuer_Homepage_View")]
        [Category("Smoke")]
        [TestCase("ID", "Name", "CPV / PVT Number", "Approval Path", "Notes", "Actions")]
        public void EMV_Issuer_Homepage_View(params string[] listOfOptions)
        {
            CP_Pages.Login.LogIn("sbabu", "Sudarshan@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToIssuers();
            CP_Pages.EMVIssuersPage.EMVIssuerHomepageView(listOfOptions);
            //DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("EMV_Issuer_Export")]
        [Category("Smoke")]
        [TestCase("React App.csv")]
        public void EMV_Issuer_Export(string fileName)
        {
            CP_Pages.Login.LogIn("sbabu", "Sudarshan@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToIssuers();
            CP_Pages.EMVIssuersPage.EMVIssuerExport(fileName);
            //DriverUtilities.TakeScreenshot(@"C:\");
        }



    }
}
