
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrowEye_Automation_Framework;
using ArrowEye_Automation_Framework.Excel;
using ArrowEye_Automation_Portal.PageRepository.EMV;
using NUnit.Framework;
using RandomString4Net;

namespace ArrowEye_Automation_Portal.Tests.Feature.Client_Settings
{
    [TestFixture]
    public class Print_Settings : TestBase
    {
        string randomString = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 10);

        [Test]
        [Description("Print_Setting_Records_Create")]
        [Category("Smoke")]
        [TestCaseSource(typeof(ExcelDataParser), "TestData", new object[] { "LoginData", new int[] { 1 } })]
        public void ADD_New_Record(ArrowEye_Automation_Framework.Excel.TestCaseData TestCaseData)
        {
            CP_Pages.Login.LogIn(TestCaseData.GetValue("Username"), TestCaseData.GetValue("Password"));
            CP_Pages.Home.ValidateHomePageTitle();
            CS_Pages.CSPrintSettingPage.NavigateToPrintSettings();
            CS_Pages.CSPrintSettingPage.AddNewPrintSettingRecord("cltnotifyhttp_get:allcomments");
        }

        [Test]
        [Description("Print_Setting_Records_Update")]
        [Category("Smoke")]
        [TestCaseSource(typeof(ExcelDataParser), "TestData", new object[] { "LoginData", new int[] { 1 } })]
        public void Edit_Record(ArrowEye_Automation_Framework.Excel.TestCaseData TestCaseData)
        {
            CP_Pages.Login.LogIn(TestCaseData.GetValue("Username"), TestCaseData.GetValue("Password"));
            CP_Pages.Home.ValidateHomePageTitle();
            CS_Pages.CSPrintSettingPage.NavigateToPrintSettings();
            CS_Pages.CSPrintSettingPage.EditPrintSettingRecord("cltnotifyhttp_get:allcomments");
        }

        [Test]
        [Description("Print_Setting_Records_Delete")]
        [Category("Smoke")]
        [TestCaseSource(typeof(ExcelDataParser), "TestData", new object[] { "LoginData", new int[] { 1 } })]
        public void Delete_Record(ArrowEye_Automation_Framework.Excel.TestCaseData TestCaseData)
        {
            CP_Pages.Login.LogIn(TestCaseData.GetValue("Username"), TestCaseData.GetValue("Password"));
            CP_Pages.Home.ValidateHomePageTitle();
            CS_Pages.CSPrintSettingPage.NavigateToPrintSettings();
            CS_Pages.CSPrintSettingPage.AddNewPrintSettingRecord("cltnotifyhttp_get:allcomments");
            CS_Pages.CSPrintSettingPage.DeletePrintSettingRecord();
        }

        [Test]
        [Description("Print_Setting_Records_Validation")]
        [Category("Smoke")]
        [TestCaseSource(typeof(ExcelDataParser), "TestData", new object[] { "LoginData", new int[] { 1 } })]
        public void Validate_Record(ArrowEye_Automation_Framework.Excel.TestCaseData TestCaseData)
        {
            CP_Pages.Login.LogIn(TestCaseData.GetValue("Username"), TestCaseData.GetValue("Password"));
            CP_Pages.Home.ValidateHomePageTitle();
            CS_Pages.CSPrintSettingPage.NavigateToPrintSettings();
            CS_Pages.CSPrintSettingPage.validatePrintSettings("cltnotifyhttp_get:allcomments");
        }

        [Test]
        [Description("Print_Setting_Records_Export")]
        [Category("Smoke")]
        [TestCaseSource(typeof(ExcelDataParser), "TestData", new object[] { "LoginData", new int[] { 1 } })]
        public void Export_Records(ArrowEye_Automation_Framework.Excel.TestCaseData TestCaseData)
        {
            CP_Pages.Login.LogIn(TestCaseData.GetValue("Username"), TestCaseData.GetValue("Password"));
            CP_Pages.Home.ValidateHomePageTitle();
            CS_Pages.CSPrintSettingPage.NavigateToPrintSettings();
            CS_Pages.CSPrintSettingPage.ExportPrintSettings();
        }
    }
}