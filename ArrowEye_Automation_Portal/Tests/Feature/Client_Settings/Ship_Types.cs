
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArrowEye_Automation_Framework;
using ArrowEye_Automation_Framework.Excel;
using ArrowEye_Automation_Portal.PageRepository.EMV;
using NUnit.Framework;
using RandomString4Net;

namespace ArrowEye_Automation_Portal.Tests.Feature.Client_Settings
{
    [TestFixture]
    public class Ship_Types : TestBase
    {
        string randomString = "";

        [Test]
        [Description("Ship_Types_Records_Create")]
        [Category("Smoke")]
        [TestCaseSource(typeof(ExcelDataParser), "TestData", new object[] { "LoginData", new int[] { 1 } })]
        public void ADD_New_Record(ArrowEye_Automation_Framework.Excel.TestCaseData TestCaseData)
        {
            CP_Pages.Login.LogIn(TestCaseData.GetValue("Username"), TestCaseData.GetValue("Password"));
            CP_Pages.Home.ValidateHomePageTitle();
            CS_Pages.ShipTypesPage.NavigateToShipTypes();
            CS_Pages.ShipTypesPage.AddNewShipTypesRecord(("Ship_Types-" + RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 10)), "USPS Marketing Mail");
               
        }

        [Test]
        [Description("Ship_Types_Records_Edit")]
        [Category("Smoke")]
        [TestCaseSource(typeof(ExcelDataParser), "TestData", new object[] { "LoginData", new int[] { 1 } })]
        public void Edit_Ship_Types_Record(ArrowEye_Automation_Framework.Excel.TestCaseData TestCaseData)
        {
            CP_Pages.Login.LogIn(TestCaseData.GetValue("Username"), TestCaseData.GetValue("Password"));
            CP_Pages.Home.ValidateHomePageTitle();
            CS_Pages.ShipTypesPage.NavigateToShipTypes();
            CS_Pages.ShipTypesPage.EditShipTypeRecord("ShipTypes-" + RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 10), "USPS Marketing Mail");

        }

        [Test]
        [Description("Ship_Types_Records_Delete")]
        [Category("Smoke")]
        [TestCaseSource(typeof(ExcelDataParser), "TestData", new object[] { "LoginData", new int[] { 1 } })]
        public void Delete_BCSS_Record(ArrowEye_Automation_Framework.Excel.TestCaseData TestCaseData)
        {
            CP_Pages.Login.LogIn(TestCaseData.GetValue("Username"), TestCaseData.GetValue("Password"));
            CP_Pages.Home.ValidateHomePageTitle();
            CS_Pages.ShipTypesPage.NavigateToShipTypes();
            CS_Pages.ShipTypesPage.DeleteShipTypesRecord("ShipTypes-" + RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 10), "USPS Marketing Mail");
          
        }

        [Test]
        [Description("Ship_Types_fieldValidations")]
        [Category("Smoke")]
        [TestCaseSource(typeof(ExcelDataParser), "TestData", new object[] { "LoginData", new int[] { 1 } })]
        public void Validation_ShipTypes_Field(ArrowEye_Automation_Framework.Excel.TestCaseData TestCaseData)
        {
            CP_Pages.Login.LogIn(TestCaseData.GetValue("Username"), TestCaseData.GetValue("Password"));
            CP_Pages.Home.ValidateHomePageTitle();
            CS_Pages.ShipTypesPage.NavigateToShipTypes();
            CS_Pages.ShipTypesPage.ValidateShip_TypesField();

        }
        [Test]
        [Description("Ship_Types_Export_Record")]
        [Category("Smoke")]
        [TestCaseSource(typeof(ExcelDataParser), "TestData", new object[] { "LoginData", new int[] { 1 } })]
        public void Export_ShipTypes_Record(ArrowEye_Automation_Framework.Excel.TestCaseData TestCaseData)
        {
            CP_Pages.Login.LogIn(TestCaseData.GetValue("Username"), TestCaseData.GetValue("Password"));
            CP_Pages.Home.ValidateHomePageTitle();
            CS_Pages.ShipTypesPage.NavigateToShipTypes();
            CS_Pages.ShipTypesPage.ExportShip_TypesRecord();

        }
    }
}