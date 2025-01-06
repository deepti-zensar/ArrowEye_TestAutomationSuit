using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrowEye_Automation_Framework;
using ArrowEye_Automation_Framework.Common;
using NUnit.Framework;
using OpenQA.Selenium.DevTools.V129.Runtime;
using RandomString4Net;



namespace ArrowEye_Automation_ClientPortal.Tests.Feature.CSP_Settings
{
    [TestFixture]
    public class BOC_Dynamic_Info :TestBase
    {
        string randomString = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE,10);
       
        [Test]
        [Description("BOC_Dynamic_Info_AddNew")]
        [Category("Smoke")]
        [TestCase("Automation_Addnew_BocDynamic_Info_")]
        public void Create_New_BOC_Dynamic_Info_Test(string CreateBOCDynamicText)
        {
             
            Console.WriteLine(randomString);

            CP_Pages.Login.LogIn("shaikhussainpasha", "Shaik@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToCSPSettings();
            CP_Pages.BOCDynamicInfoPage.AddNewBOCDynamicInfo(CreateBOCDynamicText+ randomString);
          DriverUtilities.TakeScreenshot(@"C:\");

        }

        [Test]
        [Description("BOC_Dynamic_Info_Update")]
        [Category("Smoke")]
        [TestCase("Automation_Edit_Info_")]
        public void Update_BOC_Dynamic_Info_Test(string UpdateBOCDynamicText)
        {

            CP_Pages.Login.LogIn("shaikhussainpasha", "Shaik@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToCSPSettings();
            CP_Pages.BOCDynamicInfoPage.UpdateBOCDynamicInfo(UpdateBOCDynamicText + randomString);
           DriverUtilities.TakeScreenshot(@"C:\");

        }


        [Test]
        [Description("BOC_Dynamic_Info_Delete")]
        [Category("Smoke")]
        [TestCase("Automation_Delete_Info_")]
        public void Delete_BOC_Dynamic_Info_Test(string DeleteBOCDynamicText)
        {

            CP_Pages.Login.LogIn("shaikhussainpasha", "Shaik@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToCSPSettings();
            CP_Pages.BOCDynamicInfoPage.DeleteBOCDynamicInfo(DeleteBOCDynamicText + randomString);
           DriverUtilities.TakeScreenshot(@"C:\");

        }

        [Test]
        [Description("BOC_Dynamic_Info_View_Search")]
        [Category("Smoke")]
        [TestCase("Automation_Search_View_BOCDynamicInfo_")]
        public void View_Search_BOC_Dynamic_Info_Test(string ViewSearchBOCDynamicText)
        {

            CP_Pages.Login.LogIn("shaikhussainpasha", "Shaik@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToCSPSettings();
            CP_Pages.BOCDynamicInfoPage.ViewandSearchBOCDynamicInfo(ViewSearchBOCDynamicText + randomString);
           DriverUtilities.TakeScreenshot(@"C:\");

        }

    }
}

