
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
    public class Hot_Stamps : TestBase
    {
        string randomString = "";

        [Test]
        [Description("Hot_Stamps_Records_Create")]
        [Category("Smoke")]
        [TestCaseSource(typeof(ExcelDataParser), "TestData", new object[] { "LoginData", new int[] { 1 } })]
        public void ADD_New_Record(ArrowEye_Automation_Framework.Excel.TestCaseData TestCaseData)
        {
            CP_Pages.Login.LogIn(TestCaseData.GetValue("Username"), TestCaseData.GetValue("Password"));
            CP_Pages.Home.ValidateHomePageTitle();
            CS_Pages.HotStampsPage.NavigateToHotStampPage();
            CS_Pages.HotStampsPage.AddNewHotStampsRecord("Hot-Stamps-" + RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 10));
           
        }

        [Test]
        [Description("Hot_Stamps_Records_Edit")]
        [Category("Smoke")]
        [TestCaseSource(typeof(ExcelDataParser), "TestData", new object[] { "LoginData", new int[] { 1 } })]
        public void Edit_HotStamp_Record(ArrowEye_Automation_Framework.Excel.TestCaseData TestCaseData)
        {
            CP_Pages.Login.LogIn(TestCaseData.GetValue("Username"), TestCaseData.GetValue("Password"));
            CP_Pages.Home.ValidateHomePageTitle();
            CS_Pages.HotStampsPage.NavigateToHotStampPage();
            CS_Pages.HotStampsPage.EditHotStampsRecord("Hot-Stamps-" + RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 10));

        }

        

        [Test]
        [Description("Hot_Stamps_fieldValidations")]
        [Category("Smoke")]
        [TestCaseSource(typeof(ExcelDataParser), "TestData", new object[] { "LoginData", new int[] { 1 } })]
        public void Validation_HotStampField(ArrowEye_Automation_Framework.Excel.TestCaseData TestCaseData)
        {
            CP_Pages.Login.LogIn(TestCaseData.GetValue("Username"), TestCaseData.GetValue("Password"));
            CP_Pages.Home.ValidateHomePageTitle();
            CS_Pages.HotStampsPage.NavigateToHotStampPage();
            CS_Pages.HotStampsPage.ValidateHotStampsFields();

        }
        [Test]
        [Description("Hot_Stamps_Export_Record")]
        [Category("Smoke")]
        [TestCaseSource(typeof(ExcelDataParser), "TestData", new object[] { "LoginData", new int[] { 1 } })]
        public void Export_HotStamp_Record(ArrowEye_Automation_Framework.Excel.TestCaseData TestCaseData)
        {
            CP_Pages.Login.LogIn(TestCaseData.GetValue("Username"), TestCaseData.GetValue("Password"));
            CP_Pages.Home.ValidateHomePageTitle();
            CS_Pages.HotStampsPage.NavigateToHotStampPage();
            CS_Pages.HotStampsPage.ExportHotStampsRecord();

        }
    }
}