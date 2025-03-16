
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrowEye_Automation_Framework;
using ArrowEye_Automation_Framework.Excel;
using ArrowEye_Automation_Portal.PageRepository.EMV;
using ArrowEye_Automation_Portal.PageRepository.Products;
using NUnit.Framework;
using RandomString4Net;

namespace ArrowEye_Automation_Portal.Tests.Feature.Products
{
    [TestFixture]
    public class MultiSheetLetterCarriers : TestBase
    {
        string randomString = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 10);


        [Test]
        [Description("Create_Records")]
        [Category("Smoke")]
        [TestCaseSource(typeof(ExcelDataParser), "TestData", new object[] { "LoginData", new int[] { 1 } })]
        public void Create_Records(ArrowEye_Automation_Framework.Excel.TestCaseData TestCaseData)
        {
            CP_Pages.Login.LogIn(TestCaseData.GetValue("Username"), TestCaseData.GetValue("Password"));
            Product_Pages.MultiSheetCarrierPage.NavigateToMultiSheetLetterCarrierPage();
            Product_Pages.MultiSheetCarrierPage.AddNewMultiSheetLettersCarriers("MultisheetLetterCarrier-" + randomString);
               
        }

        [Test]
        [Description("Edit_Records")]
        [Category("Smoke")]
        [TestCaseSource(typeof(ExcelDataParser), "TestData", new object[] { "LoginData", new int[] { 1 } })]
        public void Edit_Records(ArrowEye_Automation_Framework.Excel.TestCaseData TestCaseData)
        {
            CP_Pages.Login.LogIn(TestCaseData.GetValue("Username"), TestCaseData.GetValue("Password"));
            Product_Pages.MultiSheetCarrierPage.NavigateToMultiSheetLetterCarrierPage();
            Product_Pages.MultiSheetCarrierPage.EditMultiSheetLettersCarriers("MSLC-" + randomString);

        }

        [Test]
        [Description("Delete_Records")]
        [Category("Smoke")]
        [TestCaseSource(typeof(ExcelDataParser), "TestData", new object[] { "LoginData", new int[] { 1 } })]
        public void Delete_Records(ArrowEye_Automation_Framework.Excel.TestCaseData TestCaseData)
        {
            CP_Pages.Login.LogIn(TestCaseData.GetValue("Username"), TestCaseData.GetValue("Password"));
            Product_Pages.MultiSheetCarrierPage.NavigateToMultiSheetLetterCarrierPage();
            Product_Pages.MultiSheetCarrierPage.DeleteMultiSheetLettersCarriers("MSLC-" + randomString);

        }

        [Test]
        [Description("Validate_Records")]
        [Category("Smoke")]
        [TestCaseSource(typeof(ExcelDataParser), "TestData", new object[] { "LoginData", new int[] { 1 } })]
        public void Validate_Records(ArrowEye_Automation_Framework.Excel.TestCaseData TestCaseData)
        {
            CP_Pages.Login.LogIn(TestCaseData.GetValue("Username"), TestCaseData.GetValue("Password"));
            Product_Pages.MultiSheetCarrierPage.NavigateToMultiSheetLetterCarrierPage();
            Product_Pages.MultiSheetCarrierPage.ValidateMultiSheetLettersCarriers("MSLC-" + randomString);

        }

    }
}