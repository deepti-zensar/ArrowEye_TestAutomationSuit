using ArrowEye_Automation_Framework;
using ArrowEye_Automation_Framework.Common;
using NUnit.Framework;
using RandomString4Net;

namespace ArrowEye_Automation_Portal.Tests.Feature.Client_Settings
{
    [TestFixture]
    public class DefaultProofReplacements : TestBase
    {
        public string getRandomString()
        {
            return RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 5); ;
        }

        [Test]
        [Description("Default_Proof_Replacements_Create")]
        [Category("Smoke")]
        [TestCase("FirstName", "Automation_")]
        
        public void Create_DefaultProofReplacements(string replacementTag, string replacementValue)
        {
            CP_Pages.Login.LogIn("sbabu", "Sudarshan@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToClientSettingsSubmenu("Default Proof Replacements");
            CP_Pages.DefaultProofReplacementsPage.AddNewProofReplacement(replacementTag, replacementValue + getRandomString());
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("Default_Proof_Replacements_Edit")]
        [Category("Smoke")]
        [TestCase("FirstName", "Automation_")]
        public void Edit_DefaultProofReplacements(string replacementTag, string replacementValue)
        {
            CP_Pages.Login.LogIn("sudarshan", "Test@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToClientSettingsSubmenu("Default Proof Replacements");
            CP_Pages.DefaultProofReplacementsPage.EditProofReplacement(replacementTag, replacementValue + getRandomString());
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("Default_Proof_Replacements_Delete")]
        [Category("Smoke")]
        [TestCase("FirstName", "Automation_")]
        public void Delete_DefaultProofReplacements(string replacementTag, string replacementValue)
        {
            CP_Pages.Login.LogIn("sbabu", "Sudarshan@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToClientSettingsSubmenu("Default Proof Replacements");
            CP_Pages.DefaultProofReplacementsPage.DeleteProofReplacement(replacementTag, replacementValue + getRandomString());
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("Default_Proof_Replacements_Validate")]
        [Category("Smoke")]
        [TestCase("FirstName", "Automation_")]
        public void Validate_DefaultProofReplacements(string replacementTag, string replacementValue)
        {
            CP_Pages.Login.LogIn("sbabu", "Sudarshan@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToClientSettingsSubmenu("Default Proof Replacements");
            CP_Pages.DefaultProofReplacementsPage.ValidateProofReplacement(replacementTag, replacementValue + getRandomString());
            DriverUtilities.TakeScreenshot(@"C:\");
        }
        
        [Test]
        [Description("Default_Proof_Replacements_Homepage_View")]
        [Category("Smoke")]
        [TestCase("ID", "Replacement Tag", "Replacement value", "Actions")]
        public void HomepageView_DefaultProofReplacements(params string[] listOfOptions)
        {
            CP_Pages.Login.LogIn("sbabu", "Sudarshan@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToClientSettingsSubmenu("Default Proof Replacements");
            CP_Pages.DefaultProofReplacementsPage.ProofReplacementHomepageView(listOfOptions);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("Default_Proof_Replacements_Export")]
        [Category("Smoke")]
        [TestCase("React App.csv")]
        public void Export_DefaultProofReplacements(string fileName)
        {
            CP_Pages.Login.LogIn("sbabu", "Sudarshan@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToClientSettingsSubmenu("Default Proof Replacements");
            CP_Pages.DefaultProofReplacementsPage.ProofReplacementExport(fileName);
            DriverUtilities.TakeScreenshot(@"C:\");
        }
    }
}
