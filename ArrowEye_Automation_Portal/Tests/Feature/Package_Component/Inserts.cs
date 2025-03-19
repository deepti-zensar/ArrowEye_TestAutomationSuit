using ArrowEye_Automation_Framework.Common;
using ArrowEye_Automation_Framework;
using NUnit.Framework;
using RandomString4Net;

namespace ArrowEye_Automation_Portal.Tests.Feature.CSP_Settings
{
    public class Inserts : TestBase
    {
        string randomString = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 5);

        [Test]
        [Description("Inserts_Create")]
        [Category("Smoke")]
        [TestCase("Automation_Create")]
        public void Create_New_Inserts(string InsertsCreates)
        {
            CP_Pages.Login.LogIn("portaltester", "Portal@1234");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToPackagecomponents("Inserts");
            CP_Pages.Inserts.Create_Inserts(InsertsCreates + randomString);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("Inserts_Edit")]
        [Category("Smoke")]
        [TestCase("Automation_Edit")]
        public void Edit_Inserts(string UpdatesInsertsDetails)
        {
            CP_Pages.Login.LogIn("portaltester", "Portal@1234");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToPackagecomponents("Inserts");
            CP_Pages.Inserts.Updates_Inserts(UpdatesInsertsDetails + randomString);
            DriverUtilities.TakeScreenshot(@"C:\");
        }


        [Test]
        [Description("InsertssMaintanence_Validations")]
        [Category("Smoke")]
        [TestCase("Automation_Validations")]
        public void Negative_Validations_Inserts(string NegativeScenarios)
        {
            string randomStrings = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 50);
            CP_Pages.Login.LogIn("portaltester", "Portal@1234");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToPackagecomponents("Inserts");
            CP_Pages.Inserts.Validations_Inserts(NegativeScenarios + randomStrings);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("Inserts_DashBoard")]
        [Category("Smoke")]
        [TestCase("Automation_Dashbaord")]
        public void Inserts_Dashboard(string InsertsDashbaord)
        {
            string randomStrings = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 50);
            CP_Pages.Login.LogIn("portaltester", "Portal@1234");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToPackagecomponents("Inserts");
            CP_Pages.Inserts.DashBoard_Inserts(InsertsDashbaord + randomStrings);
            DriverUtilities.TakeScreenshot(@"C:\");
        }
    }
}

