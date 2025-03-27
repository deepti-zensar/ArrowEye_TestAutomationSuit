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
    public class PlasticCardBackTemplate : TestBase
    {
        string userName = "portaltestuser";
        string password = "Admin123@";
        public string getRandomString()
        {
            return RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 5); 
        }

        [Test]
        [Description("PlasticCardBackTemplate_Create")]
        [Category("Smoke")]
        [TestCase("Mastercard Debit", "Automation_", "Automation_")]
        public void Create_PlasticCardBackTemplate(string template, string name, string desc)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Products");
            CP_Pages.Home.NavigateToSubmenu("Plastic Card Back Templates");            
            CP_Pages.PlasticCardBackTemplatePage.AddNewPlasticCardBackTemplate(template, name+ getRandomString(), desc);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("PlasticCardBackTemplate_Edit")]
        [Category("Smoke")]
        [TestCase("Mastercard Debit", "Automation_", "Automation_","AutomationEdit_", "Automation_Edit")]
        public void Edit_PlasticCardBackTemplate(string template, string name, string desc, string newName, string newDesc)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Products");
            CP_Pages.Home.NavigateToSubmenu("Plastic Card Back Templates");
            CP_Pages.PlasticCardBackTemplatePage.EditPlasticCardBackTemplate(template, name + getRandomString(), desc, newName + getRandomString(), newDesc);
            DriverUtilities.TakeScreenshot(@"C:\");
        }        

        [Test]
        [Description("PlasticCardBackTemplate_Validate")]
        [Category("Smoke")]        
        public void Validate_PlasticCardBackTemplate()
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Products");
            CP_Pages.Home.NavigateToSubmenu("Plastic Card Back Templates");
            CP_Pages.PlasticCardBackTemplatePage.ValidatePlasticCardBackTemplate();
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("PlasticCardBackTemplate_Duplicate")]
        [Category("Smoke")]
        [TestCase("Mastercard Debit", "Automation_", "Automation_", "AutomationDuplicate_", "Automation_Duplicate")]
        public void Duplicate_PlasticCardBackTemplate(string template, string name, string desc, string newName, string newDesc)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Products");
            CP_Pages.Home.NavigateToSubmenu("Plastic Card Back Templates");
            CP_Pages.PlasticCardBackTemplatePage.DuplicatePlasticCardBackTemplate(template, name + getRandomString(), desc, newName + getRandomString(), newDesc);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("PlasticCardBackTemplate_Deactivate")]
        [Category("Smoke")]
        [TestCase("Mastercard Debit", "Automation_", "Automation_")]
        public void Deactivate_PlasticCardBackTemplate(string template, string name, string desc)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Products");
            CP_Pages.Home.NavigateToSubmenu("Plastic Card Back Templates");
            CP_Pages.PlasticCardBackTemplatePage.DeactivatePlasticCardBackTemplate(template, name + getRandomString(), desc);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("PlasticCardBackTemplate_ViewHistory")]
        [Category("Smoke")]
        [TestCase("Mastercard Debit", "Automation_", "Automation_", "AutomationHistory_", "Automation_History")]
        public void ViewHistory_PlasticCardBackTemplate(string template, string name, string desc, string newName, string newDesc)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Products");
            CP_Pages.Home.NavigateToSubmenu("Plastic Card Back Templates");
            CP_Pages.PlasticCardBackTemplatePage.ViewHistoryPlasticCardBackTemplate(template, name + getRandomString(), desc, newName + getRandomString(), newDesc);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("PlasticCardBackTemplate_ViewSharedBy")]
        [Category("Smoke")]
        [TestCase("Mastercard Debit", "Automation_", "Automation_")]
        public void ViewSharedBy_PlasticCardBackTemplate(string template, string name, string desc)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Products");
            CP_Pages.Home.NavigateToSubmenu("Plastic Card Back Templates");
            CP_Pages.PlasticCardBackTemplatePage.ViewSharedByPlasticCardBackTemplate(template, name + getRandomString(), desc);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("PlasticCardBackTemplate_Delete")]
        [Category("Smoke")]
        [TestCase("Mastercard Debit", "Automation_", "Automation_")]
        public void Delete_PlasticCardBackTemplate(string template, string name, string desc)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Products");
            CP_Pages.Home.NavigateToSubmenu("Plastic Card Back Templates");
            CP_Pages.PlasticCardBackTemplatePage.DeletePlasticCardBackTemplate(template, name + getRandomString(), desc);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("PlasticCardBackTemplate_Activate")]
        [Category("Smoke")]
        [TestCase("Mastercard Debit", "Automation_", "Automation_")]
        public void Activate_PlasticCardBackTemplate(string template, string name, string desc)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Products");
            CP_Pages.Home.NavigateToSubmenu("Plastic Card Back Templates");
            CP_Pages.PlasticCardBackTemplatePage.ActivatePlasticCardBackTemplate(template, name + getRandomString(), desc);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

    }
}
