using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Xml.Linq;
using ArrowEye_Automation_Framework;
using ArrowEye_Automation_Framework.Common;
using NUnit.Framework;
using RandomString4Net;

namespace ArrowEye_Automation_Portal.Tests.Feature.Products
{
    [TestFixture]
    public class PlasticCardFrontTemplate : TestBase
    {
        string userName = "sbabu";
        string password = "Sudarshan@12345";
        public string getRandomString()
        {
            return RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 5); 
        }

        [Test]
        [Description("PlasticCardFrontTemplate_Create")]
        [Category("Smoke")]
        [TestCase("Mastercard Debit", "Automation_", "Automation_")]
        public void Create_PlasticCardFrontTemplate(string template, string name, string desc)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToProductsSubmenu("Plastic Card Front Templates");
            CP_Pages.PlasticCardFrontTemplatePage.AddNewPlasticCardFrontTemplate(template, name+ getRandomString(), desc);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("PlasticCardFrontTemplate_Edit")]
        [Category("Smoke")]
        [TestCase("Mastercard Debit", "Automation_", "Automation_","AutomationEdit_", "Automation_Edit")]
        public void Edit_PlasticCardFrontTemplate(string template, string name, string desc, string newName, string newDesc)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToProductsSubmenu("Plastic Card Front Templates");
            CP_Pages.PlasticCardFrontTemplatePage.EditPlasticCardFrontTemplate(template, name + getRandomString(), desc, newName + getRandomString(), newDesc);
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
            CP_Pages.Home.NavigateToProductsSubmenu("Pin Mailers");
            CP_Pages.PinMailersPage.DeletePINMailer(carrierTitle + getRandomString(), desc, partOf, carrierStatus, colorMode);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("PlasticCardFrontTemplate_Validate")]
        [Category("Smoke")]        
        public void Validate_PlasticCardFrontTemplate()
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToProductsSubmenu("Plastic Card Front Templates");
            CP_Pages.PlasticCardFrontTemplatePage.ValidatePlasticCardFrontTemplate();
            DriverUtilities.TakeScreenshot(@"C:\");
        }

    }
}
