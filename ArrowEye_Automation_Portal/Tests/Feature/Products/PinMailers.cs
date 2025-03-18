using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrowEye_Automation_Framework;
using ArrowEye_Automation_Framework.Common;
using NUnit.Framework;
using RandomString4Net;

namespace ArrowEye_Automation_Portal.Tests.Feature.Products
{
    [TestFixture]
    public class PinMailers : TestBase
    {
        string userName = "portaltestuser";
        string password = "Admin123@";
        public string getRandomString()
        {
            return RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 5); ;
        }

        [Test]
        [Description("PinMailers_Create")]
        [Category("Smoke")]
        [TestCase("Automation_", "Automation_", "Corporate site", "Turned off", "Color")]
        public void Create_PINMailers(string carrierTitle, string desc,string partOf, string carrierStatus, string colorMode)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Products");
            CP_Pages.Home.NavigateToSubmenu("Pin Mailers");
            CP_Pages.PinMailersPage.AddNewPINMailer(carrierTitle + getRandomString(), desc, partOf, carrierStatus, colorMode);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("PinMailers_Edit")]
        [Category("Smoke")]
        [TestCase("Automation_", "Automation_", "Consumer site", "Turned on", "Grayscale", "AutomationUpdate_", "AutomationUpdate_", "Corporate site", "Turned off", "Color")]
        public void Edit_PINMailers(string carrierTitle, string desc, string partOf, string carrierStatus, string colorMode, string newCarrierTitle, string newDesc, string newPartOf, string newCarrierStatus, string newColorMode)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Products");
            CP_Pages.Home.NavigateToSubmenu("Pin Mailers");
            CP_Pages.PinMailersPage.EditPINMailer(carrierTitle + getRandomString(), desc, partOf, carrierStatus, colorMode, newCarrierTitle + getRandomString(), newDesc, newPartOf, newCarrierStatus, newColorMode);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("PinMailers_Delete")]
        [Category("Smoke")]
        [TestCase("Automation_", "Automation_", "Consumer site", "Turned on", "Grayscale")]
        [TestCase("Automation_", "Automation_", "Corporate site", "Turned off", "Color")]
        public void Delete_PINMailers(string carrierTitle, string desc, string partOf, string carrierStatus, string colorMode)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Products");
            CP_Pages.Home.NavigateToSubmenu("Pin Mailers");
            CP_Pages.PinMailersPage.DeletePINMailer(carrierTitle + getRandomString(), desc, partOf, carrierStatus, colorMode);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("PinMailers_Validate")]
        [Category("Smoke")]        
        public void Validate_PINMailers()
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Products");
            CP_Pages.Home.NavigateToSubmenu("Pin Mailers");
            CP_Pages.PinMailersPage.ValidatePINMailers();
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("PinMailers_RenameCategory")]
        [Category("Smoke")]
        [TestCase("Automation_")]
        public void RenameCategory_PINMailers(string newCategoryName )
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Products");
            CP_Pages.Home.NavigateToSubmenu("Pin Mailers");
            CP_Pages.PinMailersPage.RenamePINMailersCategory(newCategoryName + getRandomString());
            DriverUtilities.TakeScreenshot(@"C:\");
        }

    }
}
