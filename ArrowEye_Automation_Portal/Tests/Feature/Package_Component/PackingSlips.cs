using ArrowEye_Automation_Framework.Common;
using ArrowEye_Automation_Framework;
using NUnit.Framework;
using RandomString4Net;

namespace ArrowEye_Automation_Portal.Tests.Feature.CSP_Settings
{
    public class PackingSlips : TestBase
    {
        string randomString = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 5);

        [Test]
        [Description("PackingSlips_Create")]
        [Category("Smoke")]
        [TestCase("Automation_Create")]
        public void Create_New_PackingSlips(string PackingSlips)
        {
            CP_Pages.Login.LogIn("portaltester", "Portal@1234");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToPackagecomponents("Packing Slips");
            CP_Pages.PackingSlips.Create_PackingSlips(PackingSlips + randomString);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("PackingSlips_Edit")]
        [Category("Smoke")]
        [TestCase("Automation_Edit")]
        public void Edit_PackingSlips(string UpdatesPackingSlips)
        {
            CP_Pages.Login.LogIn("portaltester", "Portal@1234");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToPackagecomponents("Packing Slips");
            CP_Pages.PackingSlips.Updates_PackingSlips(UpdatesPackingSlips + randomString);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("PackingSlips_Delete")]
        [Category("Smoke")]
        [TestCase("Automation_Delete")]
        public void Delete_PackingSlips(string DeletePackingSlips)
        {
            CP_Pages.Login.LogIn("portaltester", "Portal@1234");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToPackagecomponents("Packing Slips");
            CP_Pages.PackingSlips.Delete_PackingSlips(DeletePackingSlips + randomString);
            DriverUtilities.TakeScreenshot(@"C:\");
        }


        [Test]
        [Description("PackingSlipsMaintanence_Validations")]
        [Category("Smoke")]
        [TestCase("Automation_Validations")]
        public void Negative_Validations_PackingSlips(string NegativeScenarios)
        {
            string randomStrings = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 50);
            CP_Pages.Login.LogIn("portaltester", "Portal@1234");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToPackagecomponents("Packing Slips");
            CP_Pages.PackingSlips.Validations_PackingSlips(NegativeScenarios + randomStrings);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("PackingSlips_DashBoard")]
        [Category("Smoke")]
        [TestCase("Automation_Dashbaord")]
        public void PackingSlips_Dashboard(string PackingSlipsDashbaord)
        {
            string randomStrings = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 50);
            CP_Pages.Login.LogIn("portaltester", "Portal@1234");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToPackagecomponents("Packing Slips");
            CP_Pages.PackingSlips.DashBoard_PackingSlips(PackingSlipsDashbaord + randomStrings);
            DriverUtilities.TakeScreenshot(@"C:\");
        }
    }
}

