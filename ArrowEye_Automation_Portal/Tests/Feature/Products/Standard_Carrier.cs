using ArrowEye_Automation_Framework.Common;
using ArrowEye_Automation_Framework;
using NUnit.Framework;
using RandomString4Net;

namespace ArrowEye_Automation_Portal.Tests.Feature.CSP_Settings
{
    public class Standard_Carrier : TestBase
    {
        string randomString = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 5);
        

        [Test]
        [Description("Standard_Carrier_Create")]
        [Category("Smoke")]
        [TestCase("Automatio_")]
        public void Create_New_Standard_Carrier(string StandardCarrierCreates)
        {
            CP_Pages.Login.LogIn("portaltester", "Portal@1234");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToProducts("StandardCarriers");
            CP_Pages.StandardCarrier.CreateStandardCarrier(StandardCarrierCreates + randomString);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("Standard_Carrier_Edit")]
        [Category("Smoke")]
        [TestCase("Automation_")]
        public void Edit_Standard_Carrier(string UpdateStandardCarrierDetails)
        {
            CP_Pages.Login.LogIn("portaltester", "Portal@1234");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToProducts("StandardCarriers");
            CP_Pages.StandardCarrier.EditStandardCarrier(UpdateStandardCarrierDetails + randomString);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("Standard_Carrier_Category_Maintanence")]
        [Category("Smoke")]
        [TestCase("Automation_SCMaintanence")]
        public void Standard_Category_Maintanence(string StandardCategoryMaintance)
        {
            CP_Pages.Login.LogIn("portaltester", "Portal@1234");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToProducts("StandardCarriers");
            CP_Pages.StandardCarrier.Maintanence_StandardCarrier(StandardCategoryMaintance + randomString);
            DriverUtilities.TakeScreenshot(@"C:\");
        }


        [Test]
        [Description("Standard_Carrier_Validations")]
        [Category("Smoke")]
        [TestCase("Automation_Validations")]
        public void Negative_Validations_Standard_Carrier(string NegativeScenarios)
        {
            string randomStrings = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 50);
            CP_Pages.Login.LogIn("portaltester", "Portal@1234");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToProducts("StandardCarriers");
            CP_Pages.StandardCarrier.Validations_StandardCarrier(NegativeScenarios + randomStrings);
            DriverUtilities.TakeScreenshot(@"C:\");
        }
    }
}

