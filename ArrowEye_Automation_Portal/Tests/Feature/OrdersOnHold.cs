using ArrowEye_Automation_Framework;
using ArrowEye_Automation_Framework.Common;
using NUnit.Framework;
using RandomString4Net;

namespace ArrowEye_Automation_Portal.Tests.Feature
{
    [TestFixture]
    public class OrdersOnHold : TestBase
    {
        string userName = "sbabu";
        string password = "Sudarshan@12345";
        public string getRandomString()
        {
            return RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 5); ;
        }

        
        [Test]
        [Description("OrdersOnHold_Homepage_View")]
        [Category("Smoke")]
        [TestCase("ID", "Program Name", "Package ID", "Ecount ID", "Last 4 Digits (PAN)", "Card Holder Name", "Date File Received", "Expected Deletion", "Emboss File Name")]
        public void HomepageView_OrdersOnHold(params string[] listOfOptions)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Orders On Hold");
            CP_Pages.OrdersOnHoldPage.OrdersOnHoldHomepageView(listOfOptions);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("OrdersOnHold_Export")]
        [Category("Smoke")]
        [TestCase("React App.csv")]
        public void Export_OrdersOnHold(string fileName)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Configuration Hierarchy");
            CP_Pages.OrdersOnHoldPage.OrdersOnHoldExport(fileName);
            DriverUtilities.TakeScreenshot(@"C:\");
        }
    }
}
