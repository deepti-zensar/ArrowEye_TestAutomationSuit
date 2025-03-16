
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrowEye_Automation_Framework;
using ArrowEye_Automation_Framework.Excel;
using ArrowEye_Automation_Portal.PageRepository.EMV;
using ArrowEye_Automation_Portal.PageRepository.Products;
using ArrowEye_Automation_Portal.PageRepository.Programs;
using NUnit.Framework;
using RandomString4Net;

namespace ArrowEye_Automation_Portal.Tests.Feature.Programs
{
    [TestFixture]
    public class Programs : TestBase
    {
        string randomString = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 10);


        [Test]
        [Description("Verify Common Setting Programs")]
        [Category("Smoke")]
        [TestCaseSource(typeof(ExcelDataParser), "TestData", new object[] { "LoginData", new int[] { 1 } })]
        public void VerifyCommonSettingProgram(ArrowEye_Automation_Framework.Excel.TestCaseData TestCaseData)
        {
            CP_Pages.Login.LogIn(TestCaseData.GetValue("Username"), TestCaseData.GetValue("Password"));
            
            Program_Pages.ProgramsCommonSettingPage.NavigateToProgramsCommonSettingHomepage();
            Program_Pages.ProgramsCommonSettingPage.VerifyCommonSettingPageSections();

        }

        [Test]
        [Description("Update Common Setting Programs")]
        [Category("Smoke")]
        [TestCaseSource(typeof(ExcelDataParser), "TestData", new object[] { "LoginData", new int[] { 1 } })]
        public void UpdateCommonSettingProgram(ArrowEye_Automation_Framework.Excel.TestCaseData TestCaseData)
        {
            CP_Pages.Login.LogIn(TestCaseData.GetValue("Username"), TestCaseData.GetValue("Password"));

            Program_Pages.ProgramsCommonSettingPage.NavigateToProgramsCommonSettingHomepage();
            Program_Pages.ProgramsCommonSettingPage.UpdateProgramSetting();

        }

    }
}