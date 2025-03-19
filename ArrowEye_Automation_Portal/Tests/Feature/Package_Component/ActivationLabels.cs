using ArrowEye_Automation_Framework.Common;
using ArrowEye_Automation_Framework;
using NUnit.Framework;
using RandomString4Net;

namespace ArrowEye_Automation_Portal.Tests.Feature.CSP_Settings
{
    public class ActivationLabels : TestBase
    {
        string randomString = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 5);

        [Test]
        [Description("ActivationLabels_Create")]
        [Category("Smoke")]
        [TestCase("Automation_Create")]
        public void Create_New_ActivationLabels(string StandardCarrierCreates)
        {
            CP_Pages.Login.LogIn("portaltester", "Portal@1234");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToPackagecomponents("Activation Labels");
            CP_Pages.ActivationLabels.CreateActivationLabels(StandardCarrierCreates + randomString);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("ActivationLabels_Edit")]
        [Category("Smoke")]
        [TestCase("Automation_Edit")]
        public void Edit_ActivationLabels(string UpdateStandardCarrierDetails)
        {
            CP_Pages.Login.LogIn("portaltester", "Portal@1234");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToPackagecomponents("Activation Labels");
            CP_Pages.ActivationLabels.EditActivationLabels(UpdateStandardCarrierDetails + randomString);
            DriverUtilities.TakeScreenshot(@"C:\");
        }


        [Test]
        [Description("ActivationLabelsMaintanence_Validations")]
        [Category("Smoke")]
        [TestCase("Automation_Validations")]
        public void Negative_Validations_ActivationLabels(string NegativeScenarios)
        {
            string randomStrings = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 50);
            CP_Pages.Login.LogIn("portaltester", "Portal@1234");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToPackagecomponents("Activation Labels");
            CP_Pages.ActivationLabels.Validations_ActivationLabels(NegativeScenarios + randomStrings);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("ActivationLabels_DashBoard")]
        [Category("Smoke")]
        [TestCase("Automation_Dashbaord")]
        public void ActivationLables_Dashboard(string ActivationLableDashbaord)
        {
            string randomStrings = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 50);
            CP_Pages.Login.LogIn("portaltester", "Portal@1234");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToPackagecomponents("Activation Labels");
            CP_Pages.ActivationLabels.DashBoard_ActivationLabels(ActivationLableDashbaord + randomStrings);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("PackageComponents_Allassets_Default_DescOrder")]
        [Category("Smoke")]
        [TestCase("Verify_Assets_DefaultOrder")]
        public void Verify_PC_Allassets_Default_DescOrder(string verifyPCAssetsorder)
        {
            string randomStrings = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 50);
            CP_Pages.Login.LogIn("portaltester", "Portal@1234");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToPackagecomponents("Activation Labels");
            CP_Pages.ActivationLabels.PC_Verify_Assets_DefaultOrder(verifyPCAssetsorder + randomStrings);
            DriverUtilities.TakeScreenshot(@"C:\");
        }
    }
}

