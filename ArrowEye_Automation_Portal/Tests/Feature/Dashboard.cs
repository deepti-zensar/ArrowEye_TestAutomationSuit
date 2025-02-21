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
        [TestCase("Approvals","Client Information","Client Settings","Change Requests","Configuration Hierarchy","CSP Settings","EMV","Orders On Hold","Package Components","Plastic Core Assemblies","Products","Product Pricing","Programs","Program Bulk Upload","Reports","SLA Configuration Parameters","Users")]
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

    }
}
