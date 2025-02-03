﻿
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
    public class BCSS_Configuration : TestBase
    {
        string randomString = "";

        [Test]
        [Description("BCSS_Configuration_Records_Create")]
        [Category("Smoke")]
        [TestCaseSource(typeof(ExcelDataParser), "TestData", new object[] { "LoginData", new int[] { 1 } })]
        public void ADD_New_Record(ArrowEye_Automation_Framework.Excel.TestCaseData TestCaseData)
        {
            CP_Pages.Login.LogIn(TestCaseData.GetValue("Username"), TestCaseData.GetValue("Password"));
            CP_Pages.Home.ValidateHomePageTitle();
            CS_Pages.BCSSConfigurationPage.NavigateToBCSSConfigurations();
            CS_Pages.BCSSConfigurationPage.AddNewBCSSRecord("BCSS-Configuration-" + RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 10));

        }

        [Test]
        [Description("BCSS_Configuration_Records_Edit")]
        [Category("Smoke")]
        [TestCaseSource(typeof(ExcelDataParser), "TestData", new object[] { "LoginData", new int[] { 1 } })]
        public void Edit_BCSS_Record(ArrowEye_Automation_Framework.Excel.TestCaseData TestCaseData)
        {
            CP_Pages.Login.LogIn(TestCaseData.GetValue("Username"), TestCaseData.GetValue("Password"));
            CP_Pages.Home.ValidateHomePageTitle();
            CS_Pages.BCSSConfigurationPage.NavigateToBCSSConfigurations();
            CS_Pages.BCSSConfigurationPage.EditBCSSRecord("BCSS-Configuration-" + RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 10));

        }

        [Test]
        [Description("BCSS_Configuration_Records_Delete")]
        [Category("Smoke")]
        [TestCaseSource(typeof(ExcelDataParser), "TestData", new object[] { "LoginData", new int[] { 1 } })]
        public void Delete_BCSS_Record(ArrowEye_Automation_Framework.Excel.TestCaseData TestCaseData)
        {
            CP_Pages.Login.LogIn(TestCaseData.GetValue("Username"), TestCaseData.GetValue("Password"));
            CP_Pages.Home.ValidateHomePageTitle();
            CS_Pages.BCSSConfigurationPage.NavigateToBCSSConfigurations();
            CS_Pages.BCSSConfigurationPage.DeleteBCSSRecord("BCSS-Configuration-" + RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 10));

        }

        [Test]
        [Description("BCSS_Configuration_fieldValidations")]
        [Category("Smoke")]
        [TestCaseSource(typeof(ExcelDataParser), "TestData", new object[] { "LoginData", new int[] { 1 } })]
        public void Validation_BCSSConfiguration_Field(ArrowEye_Automation_Framework.Excel.TestCaseData TestCaseData)
        {
            CP_Pages.Login.LogIn(TestCaseData.GetValue("Username"), TestCaseData.GetValue("Password"));
            CP_Pages.Home.ValidateHomePageTitle();
            CS_Pages.BCSSConfigurationPage.NavigateToBCSSConfigurations();
            CS_Pages.BCSSConfigurationPage.ValidateBCSSConfigurationField();

        }
        [Test]
        [Description("BCSS_Configuration_Export_Record")]
        [Category("Smoke")]
        [TestCaseSource(typeof(ExcelDataParser), "TestData", new object[] { "LoginData", new int[] { 1 } })]
        public void Export_BCSSConfiguration_Record(ArrowEye_Automation_Framework.Excel.TestCaseData TestCaseData)
        {
            CP_Pages.Login.LogIn(TestCaseData.GetValue("Username"), TestCaseData.GetValue("Password"));
            CP_Pages.Home.ValidateHomePageTitle();
            CS_Pages.BCSSConfigurationPage.NavigateToBCSSConfigurations();
            CS_Pages.BCSSConfigurationPage.ExportBCSSConfigurationRecord();

        }
    }
}