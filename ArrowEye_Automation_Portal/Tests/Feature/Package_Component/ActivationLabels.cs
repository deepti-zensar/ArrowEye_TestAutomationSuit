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
        [TestCase("Automatio_")]
        public void Create_New_ActivationLabels(string StandardCarrierCreates)
        {
            CP_Pages.Login.LogIn("shaikhussainpasha", "Shaik@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToPackagecomponents("ActivationLabels");
            CP_Pages.ActivationLabels.CreateActivationLabels(StandardCarrierCreates + randomString);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("ActivationLabels_Edit")]
        [Category("Smoke")]
        [TestCase("Automation_")]
        public void Edit_ActivationLabels(string UpdateStandardCarrierDetails)
        {
            CP_Pages.Login.LogIn("shaikhussainpasha", "Shaik@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToProducts("StandardCarriers");
            CP_Pages.ActivationLabels.EditActivationLabels(UpdateStandardCarrierDetails + randomString);
            DriverUtilities.TakeScreenshot(@"C:\");
        }


        [Test]
        [Description("ActivationLabels_Validations")]
        [Category("Smoke")]
        [TestCase("Automation_Validations")]
        public void Negative_Validations_ActivationLabels(string NegativeScenarios)
        {
            string randomStrings = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 50);
            CP_Pages.Login.LogIn("shaikhussainpasha", "Shaik@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToProducts("StandardCarriers");
            CP_Pages.ActivationLabels.Validations_ActivationLabels(NegativeScenarios + randomStrings);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("ActivationLabels_RecordHistory")]
        [Category("Smoke")]
        [TestCase("Automation_Validations")]
        public void ActivationLablesDashboard(string NegativeScenarios)
        {
            string randomStrings = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 50);
            CP_Pages.Login.LogIn("shaikhussainpasha", "Shaik@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToProducts("StandardCarriers");
            CP_Pages.ActivationLabels.Validations_ActivationLabels(NegativeScenarios + randomStrings);
            DriverUtilities.TakeScreenshot(@"C:\");
        }
    }
}

