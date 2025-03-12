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

    public class Carrier_Dynamic_Info : TestBase
    {
        string randomString = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE,10);


        [Test]
        [Description("Carrier_Dynamic_Info_Create")]
        [Category("Smoke")]
        [TestCase("Automation_Carrier_Create_Info_")]
        public void Create_New_Carrier_Dynamic_Info(string CreateCarrierDynamicText)
        {
            CP_Pages.Login.LogIn("shaikhussainpasha", "Shaik@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToCSPSettingsSubMenu("Carrier Dynamic Info");
            CP_Pages.CarrierDynamicInfoPage.AddNewCarrierDynamicInfo(CreateCarrierDynamicText + randomString);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("Carrier_Dynamic_Info_Update")]
        [Category("Smoke")]
        [TestCase("Automation_Cariier_Edit_Info_")]
        public void Edit_Carrier_Dynamic_Info(string UpdateCarrierDynamicText)
        {
            CP_Pages.Login.LogIn("shaikhussainpasha", "Shaik@12345");
            CP_Pages.Home.ValidateHomePageTitle();
             CP_Pages.Home.NavigateToCSPSettingsSubMenu("Carrier Dynamic Info");
            CP_Pages.CarrierDynamicInfoPage.EditCarrierDynamicInfo(UpdateCarrierDynamicText + randomString);
            DriverUtilities.TakeScreenshot(@"C:\");
        }


        [Test]
        [Description("Carrier_Dynamic_Info_Delete")]
        [Category("Smoke")]
        [TestCase("Automation_Delete_Carrier_Info_")]
        public void Delete_Carrier_Dynamic_Info(string DeleteCarrierDynamicText)
        {
            CP_Pages.Login.LogIn("shaikhussainpasha", "Shaik@12345");
            CP_Pages.Home.ValidateHomePageTitle();
             CP_Pages.Home.NavigateToCSPSettingsSubMenu("Carrier Dynamic Info");
            CP_Pages.CarrierDynamicInfoPage.DeleteCarrierDynamicInfo(DeleteCarrierDynamicText + randomString);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("Carrier_Dynamic_Info_View_Search")]
        [Category("Smoke")]
        [TestCase("Automation_Search_View_CarrierDynamicInfo_")]
        public void View_Search_Carrier_Dynamic_Info(string ViewSearchCarrierDynamicText)
        {

            CP_Pages.Login.LogIn("shaikhussainpasha", "Shaik@12345");
            CP_Pages.Home.ValidateHomePageTitle();
             CP_Pages.Home.NavigateToCSPSettingsSubMenu("Carrier Dynamic Info");
            CP_Pages.CarrierDynamicInfoPage.ViewandSearchCarrierDynamicInfo(ViewSearchCarrierDynamicText + randomString);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("Carrier_Dynamic_Info_Negative_Scenarios_Validations")]
        [Category("Smoke")]
        [TestCase("Automation_Negative_Scenarios")]
        public void Negative_Validations_Carrier_Dynamic_Info(string NegativeScenariosText)
        {
            string randomStrings = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 90);
            CP_Pages.Login.LogIn("shaikhussainpasha", "Shaik@12345");
            CP_Pages.Home.ValidateHomePageTitle();
             CP_Pages.Home.NavigateToCSPSettingsSubMenu("Carrier Dynamic Info");
            CP_Pages.CarrierDynamicInfoPage.ValidationsCarrierDynamicInfo(NegativeScenariosText + randomStrings);
            DriverUtilities.TakeScreenshot(@"C:\");
        }
    }
}


