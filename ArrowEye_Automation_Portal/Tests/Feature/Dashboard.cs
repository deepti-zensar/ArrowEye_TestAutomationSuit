using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ArrowEye_Automation_Framework;
using ArrowEye_Automation_Framework.Common;
using NUnit.Framework;
using OpenQA.Selenium.BiDi.Modules.BrowsingContext;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ArrowEye_Automation_Portal.Tests.Feature
{
    [TestFixture]
    public class Dashboard : TestBase
    {
        string userName = "portaltestuser";
        string password = "Admin123@";        

        [Test]
        [Description("Client Gallery Options")]
        [Category("Smoke")]
        [TestCase("Approvals","Client Information","Client Settings","Change Requests","Configuration Hierarchy","CSP Settings","EMV","Orders On Hold","Package Components","Plastic Core Assemblies","Products","Programs","Program Bulk Upload","Reports","SLA Configuration Parameters","Users")]
        public void ValidateClientGallery_Options(params string[] listOfOptions)
        {
            CP_Pages.Login.validateLoginPage();
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToClientGallery();
            CP_Pages.Home.ValidateClientGalleryOptions(listOfOptions);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("Approvals Options")]
        [Category("Smoke")]
        [TestCase("Approvals", "Global Queue")]
        public void ValidateApprovals_Options(params string[] listOfOptions)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Approvals");
            CP_Pages.Home.ValidateSubMenuOptions(listOfOptions);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("Client Settings Options")]
        [Category("Smoke")]
        [TestCase("Bank ID Numbers", "BCSS Configurations", "Client Profiles", "Configure Client", "Default Proof Replacements", "General Settings", "Hot Stamps", "Issuing Banks", "Mag Track Encodings", "Platforms & Products", "Print Tags", "Print Settings", "Ship Types")]
        public void ValidateClientSettings_Options(params string[] listOfOptions)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Client Settings");
            CP_Pages.Home.ValidateSubMenuOptions(listOfOptions);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("CSP Settings Options")]
        [Category("Smoke")]
        [TestCase("BOC Dynamic Info", "Card Holder Agreement", "Carrier Dynamic Info", "EMV Profile", "FOC Dynamic Info")]
        public void ValidateCSPSettings_Options(params string[] listOfOptions)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("CSP Settings");
            CP_Pages.Home.ValidateSubMenuOptions(listOfOptions);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("EMV Options")]
        [Category("Smoke")]
        [TestCase("Authentications", "Card Profiles", "Configurations", "Issuers", "Scripts", "Modules")]
        public void ValidateEMV_Options(params string[] listOfOptions)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("EMV");
            CP_Pages.Home.ValidateSubMenuOptions(listOfOptions);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("Package Components Options")]
        [Category("Smoke")]
        [TestCase("Activation Labels", "Inserts", "Packing Slips")]
        public void ValidatePackageComponents_Options(params string[] listOfOptions)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Package Components");
            CP_Pages.Home.ValidateSubMenuOptions(listOfOptions);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("Products Options")]
        [Category("Smoke")]
        [TestCase("Letter Carriers", "Multi Sheet Letter Carriers", "Pin Mailers", "Plastic Cards", "Plastic Card Front Templates", "Plastic Card Back Templates", "Standard Carriers")]
        public void ValidateProducts_Options(params string[] listOfOptions)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Products");
            CP_Pages.Home.ValidateSubMenuOptions(listOfOptions);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("Reports Options")]
        [Category("Smoke")]
        [TestCase("Program Checker")]
        public void ValidateReports_Options(params string[] listOfOptions)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Reports");
            CP_Pages.Home.ValidateSubMenuOptions(listOfOptions);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("Users Options")]
        [Category("Smoke")]
        [TestCase("User Roles", "User Management")]
        public void ValidateUsers_Options(params string[] listOfOptions)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Users");
            CP_Pages.Home.ValidateSubMenuOptions(listOfOptions);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("Left Navigation Bar Options")]
        [Category("Smoke")]
        [TestCase("Approvals", "Configuration Hierarchy", "Letter Carriers", "Multi Sheet Letter Carriers", "Pin Mailers", "Plastic Cards", "Plastic Card Front Templates", "Plastic Card Back Templates", "Platforms", "Programs", "Standard Carriers", "Users")]
        public void ValidateLeftNavigationBar_Options(params string[] listOfOptions)
        {
            CP_Pages.Login.validateLoginPage();
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToLeftBar();
            CP_Pages.Home.ValidateLeftNavigationBarOptions(listOfOptions);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("Disclaimer homepage Banner")]
        [Category("Smoke")]
        public void ValidateDisclaimerHomepage_Banner()
        {
            CP_Pages.Login.validateLoginPage();
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();            
            CP_Pages.Home.ValidateHomepageDisclaimerBanner();
            DriverUtilities.TakeScreenshot(@"C:\");
        }

    }
}
