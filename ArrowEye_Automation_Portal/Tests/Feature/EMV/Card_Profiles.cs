using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrowEye_Automation_Framework;
using NUnit.Framework;
using RandomString4Net;

namespace ArrowEye_Automation_Portal.Tests.Feature
{
    public class Card_Profiles : TestBase
    {
        public string getRandomString()
        {
            return RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 5); ;
        }

        [Test]
        [Description("EMV_CardProfiles_Create")]
        [Category("Smoke")]
        [TestCase("Automation_Create_CardProfiles_","","")]
        [TestCase("Automation_Create_CardProfiles_", "", "2025-05-18")]
        [TestCase("Automation_Create_CardProfiles_", "abc", "2025-05-18")]        
        public void Create_New_EMV_CardProfiles(string name, string issuer, string date)
        {
            CP_Pages.Login.LogIn("sbabu", "Sudarshan@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToEMVSubmenu("Card Profiles");
            CP_Pages.EMVCardProfilesPage.AddNewCardProfiles(name + getRandomString(), issuer, date);
            //DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("EMV_CardProfiles_ExpirationDate_Calendar")]
        [Category("Smoke")]
        [TestCase("Automation_Create_CardProfiles_")]     
        public void Validate_EMV_CardProfiles_ExpirationDate_Calendar(string name)
        {
            CP_Pages.Login.LogIn("sbabu", "Sudarshan@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToEMVSubmenu("Card Profiles");
            CP_Pages.EMVCardProfilesPage.ValidateCalendarDropdown(name + getRandomString());
            //DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("EMV_CardProfiles_Edit")]
        [Category("Smoke")]        
        [TestCase("Automation_Create_CardProfiles_", "abc", "2025-05-18", "Automation_EMV_Issuer_Validation_k3ba7")]
        public void Edit_EMV_CardProfiles(string name, string issuer, string date, string newIssuer)
        {
            CP_Pages.Login.LogIn("sbabu", "Sudarshan@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToEMVSubmenu("Card Profiles");
            CP_Pages.EMVCardProfilesPage.EditCardProfiles(name + getRandomString(), issuer, date, newIssuer);
            //DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("EMV_CardProfiles_Validations")]
        [Category("Smoke")]        
        public void Validate_EMV_CardProfiles()
        {
            CP_Pages.Login.LogIn("sbabu", "Sudarshan@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToEMVSubmenu("Card Profiles");
            CP_Pages.EMVCardProfilesPage.ValidateEMVCardProfiles();
            //DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("EMV_Options_View")]
        [Category("Smoke")]
        [TestCase("Authentications", "Card Profiles", "Configurations", "Issuers", "Scripts", "Modules")]
        public void EMV_Options_View(params string[] listOfOptions)
        {
            CP_Pages.Login.LogIn("sbabu", "Sudarshan@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToEMV();
            CP_Pages.EMVIssuersPage.EMVOptionsView(listOfOptions);
            //DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("EMV_Card_Profiles_Homepage_View")]
        [Category("Smoke")]
        [TestCase("ID", "Name", "Issuer", "Expiration Date", "Actions")]
        public void EMV_Card_Profiles_Homepage_View(params string[] listOfOptions)
        {
            CP_Pages.Login.LogIn("sbabu", "Sudarshan@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToEMVSubmenu("Card Profiles");
            CP_Pages.EMVCardProfilesPage.EMVCardProfilesHomepageView(listOfOptions);
            //DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("EMV_Card_Profiles_Export")]
        [Category("Smoke")]
        [TestCase("React App.csv")]
        public void EMV_Card_Profiles_Export(string fileName)
        {
            CP_Pages.Login.LogIn("sbabu", "Sudarshan@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToEMVSubmenu("Card Profiles");
            CP_Pages.EMVCardProfilesPage.EMVCardProfilesExport(fileName);
            //DriverUtilities.TakeScreenshot(@"C:\");
        }
    }
}
