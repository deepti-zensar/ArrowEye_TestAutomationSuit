using ArrowEye_Automation_Framework.Common;
using ArrowEye_Automation_Framework;
using NUnit.Framework;
using RandomString4Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowEye_Automation_Portal.Tests.Feature.CSP_Settings
{
    public class EMV_Profile : TestBase
    {

        string randomString = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 10);

        [Test]
        [Description("EMVProfile_Create")]
        [Category("Smoke")]
        [TestCase("Automation_Create_EMVProfile")]
        public void Create_EMVProfile(string CreateEMVProfileText)
        {
            CP_Pages.Login.LogIn("shaikhussainpasha", "Shaik@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToCSPSettings("EMVProfile");
            CP_Pages.EMVProfilePage.AddNewEMVProfile(CreateEMVProfileText + randomString);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("EMVProfile_Update")]
        [Category("Smoke")]
        [TestCase("Automation_Edit_EMVProfile")]
        public void Edit_EMVProfile(string UpdateBOCDynamicText)
        {
            CP_Pages.Login.LogIn("shaikhussainpasha", "Shaik@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToCSPSettings("EMVProfile");
            CP_Pages.EMVProfilePage.EditEMVProfile(UpdateBOCDynamicText + randomString);
            DriverUtilities.TakeScreenshot(@"C:\");
        }


        [Test]
        [Description("EMVProfile_Delete")]
        [Category("Smoke")]
        [TestCase("Automation_Delete_EMVProfile")]
        public void Delete_EMVProfile(string DeleteBOCDynamicText)
        {
            CP_Pages.Login.LogIn("shaikhussainpasha", "Shaik@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToCSPSettings("EMVProfile");
            CP_Pages.EMVProfilePage.DeleteEMVProfile(DeleteBOCDynamicText + randomString);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("EMVProfile_Create")]
        [Category("Smoke")]
        [TestCase("Automation_Create_EMVProfile")]
        public void View_Search_EMVProfile(string ViewSearchBOCDynamicText)
        {
            CP_Pages.Login.LogIn("shaikhussainpasha", "Shaik@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToCSPSettings("EMVProfile");
            CP_Pages.EMVProfilePage.ViewandSearchEMVProfile(ViewSearchBOCDynamicText + randomString);
            DriverUtilities.TakeScreenshot(@"C:\");
        }


        [Test]
        [Description("EMVProfile_Negative_Scenarios_Validations")]
        [Category("Smoke")]
        [TestCase("Automation_Negative_Scenarios")]
        public void Negative_Validations_EMVProfile(string InvalidInputsText)
        {
            CP_Pages.Login.LogIn("test1", "Test@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToCSPSettings("EMVProfile");
            CP_Pages.EMVProfilePage.ValidationsEMVProfile(InvalidInputsText + randomString);
            DriverUtilities.TakeScreenshot(@"C:\");
        }
    }
}

