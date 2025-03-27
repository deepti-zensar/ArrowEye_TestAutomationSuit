using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Xml.Linq;
using ArrowEye_Automation_Framework;
using ArrowEye_Automation_Framework.Common;
using NPOI.SS.UserModel;
using NUnit.Framework;
using RandomString4Net;

namespace ArrowEye_Automation_Portal.Tests.Feature.Products
{
    [TestFixture]
    public class PlasticCardFrontTemplate : TestBase
    {
        string userName = "portaltestuser";
        string password = "Admin123@";
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
            CP_Pages.Home.NavigateToMenu("Products");
            CP_Pages.Home.NavigateToSubmenu("Plastic Card Front Templates");            
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
            CP_Pages.Home.NavigateToMenu("Products");
            CP_Pages.Home.NavigateToSubmenu("Plastic Card Front Templates");
            CP_Pages.PlasticCardFrontTemplatePage.EditPlasticCardFrontTemplate(template, name + getRandomString(), desc, newName + getRandomString(), newDesc);
            DriverUtilities.TakeScreenshot(@"C:\");
        }        

        [Test]
        [Description("PlasticCardFrontTemplate_Validate")]
        [Category("Smoke")]        
        public void Validate_PlasticCardFrontTemplate()
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Products");
            CP_Pages.Home.NavigateToSubmenu("Plastic Card Front Templates");
            CP_Pages.PlasticCardFrontTemplatePage.ValidatePlasticCardFrontTemplate();
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("PlasticCardFrontTemplate_Duplicate")]
        [Category("Smoke")]
        [TestCase("Mastercard Debit", "Automation_", "Automation_", "AutomationDuplicate_", "Automation_Duplicate")]
        public void Duplicate_PlasticCardFrontTemplate(string template, string name, string desc, string newName, string newDesc)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Products");
            CP_Pages.Home.NavigateToSubmenu("Plastic Card Front Templates");
            CP_Pages.PlasticCardFrontTemplatePage.DuplicatePlasticCardFrontTemplate(template, name + getRandomString(), desc, newName + getRandomString(), newDesc);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("PlasticCardFrontTemplate_Deactivate")]
        [Category("Smoke")]
        [TestCase("Mastercard Debit", "Automation_", "Automation_")]
        public void Deactivate_PlasticCardFrontTemplate(string template, string name, string desc)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Products");
            CP_Pages.Home.NavigateToSubmenu("Plastic Card Front Templates");
            CP_Pages.PlasticCardFrontTemplatePage.DeactivatePlasticCardFrontTemplate(template, name + getRandomString(), desc);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("PlasticCardFrontTemplate_ViewHistory")]
        [Category("Smoke")]
        [TestCase("Mastercard Debit", "Automation_", "Automation_", "AutomationHistory_", "Automation_History")]
        public void ViewHistory_PlasticCardFrontTemplate(string template, string name, string desc, string newName, string newDesc)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Products");
            CP_Pages.Home.NavigateToSubmenu("Plastic Card Front Templates");
            CP_Pages.PlasticCardFrontTemplatePage.ViewHistoryPlasticCardFrontTemplate(template, name + getRandomString(), desc, newName + getRandomString(), newDesc);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("PlasticCardFrontTemplate_ViewSharedBy")]
        [Category("Smoke")]
        [TestCase("Mastercard Debit", "Automation_", "Automation_")]
        public void ViewSharedBy_PlasticCardFrontTemplate(string template, string name, string desc)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Products");
            CP_Pages.Home.NavigateToSubmenu("Plastic Card Front Templates");
            CP_Pages.PlasticCardFrontTemplatePage.ViewSharedByPlasticCardFrontTemplate(template, name + getRandomString(), desc);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("PlasticCardFrontTemplate_Delete")]
        [Category("Smoke")]
        [TestCase("Mastercard Debit", "Automation_", "Automation_")]
        public void Delete_PlasticCardFrontTemplate(string template, string name, string desc)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Products");
            CP_Pages.Home.NavigateToSubmenu("Plastic Card Front Templates");
            CP_Pages.PlasticCardFrontTemplatePage.DeletePlasticCardFrontTemplate(template, name + getRandomString(), desc);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("PlasticCardFrontTemplate_Activate")]
        [Category("Smoke")]
        [TestCase("Mastercard Debit", "Automation_", "Automation_")]
        public void Activate_PlasticCardFrontTemplate(string template, string name, string desc)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Products");
            CP_Pages.Home.NavigateToSubmenu("Plastic Card Front Templates");
            CP_Pages.PlasticCardFrontTemplatePage.ActivatePlasticCardFrontTemplate(template, name + getRandomString(), desc);
            DriverUtilities.TakeScreenshot(@"C:\");
        }
    }
}
