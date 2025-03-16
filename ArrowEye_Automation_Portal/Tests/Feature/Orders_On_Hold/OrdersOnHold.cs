
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

namespace ArrowEye_Automation_Portal.Tests.Feature.Orders_On_Hold
{
    [TestFixture]
    public class OrdersOnHold : TestBase
    {
        string randomString = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 10);


        [Test]
        [Description("Viewing the Parameters on Orders on Hold Dashboard")]
        [Category("Smoke")]
        [TestCaseSource(typeof(ExcelDataParser), "TestData", new object[] { "LoginData", new int[] { 1 } })]
        public void ViewingParameters(ArrowEye_Automation_Framework.Excel.TestCaseData TestCaseData)
        {
            CP_Pages.Login.LogIn(TestCaseData.GetValue("Username"), TestCaseData.GetValue("Password"));
            CP_Pages.OrderOnHold.NavigateToOrdersOnHoldHomepage();
            CP_Pages.OrderOnHold.ViewingTheParameters();





        }

        [Test]
        [Description("Exporting Orders On Hold Grid")]
        [Category("Smoke")]
        [TestCaseSource(typeof(ExcelDataParser), "TestData", new object[] { "LoginData", new int[] { 1 } })]
        public void ExportingOrders(ArrowEye_Automation_Framework.Excel.TestCaseData TestCaseData)
        {
            CP_Pages.Login.LogIn(TestCaseData.GetValue("Username"), TestCaseData.GetValue("Password"));
            CP_Pages.OrderOnHold.NavigateToOrdersOnHoldHomepage();
            CP_Pages.OrderOnHold.ExportingOrders();

        }
        [Test]
        [Description("Releasing Orders On Hold Grid")]
        [Category("Smoke")]
        [TestCaseSource(typeof(ExcelDataParser), "TestData", new object[] { "LoginData", new int[] { 1 } })]
        public void ReleasingOrders(ArrowEye_Automation_Framework.Excel.TestCaseData TestCaseData)
        {
            CP_Pages.Login.LogIn(TestCaseData.GetValue("Username"), TestCaseData.GetValue("Password"));
            CP_Pages.OrderOnHold.NavigateToOrdersOnHoldHomepage();
            CP_Pages.OrderOnHold.ReleasingOrders();

        }

    }
}