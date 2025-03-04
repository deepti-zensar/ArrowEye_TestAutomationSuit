using ArrowEye_Automation_Framework.Common;
using ArrowEye_Automation_Framework;
using NUnit.Framework;
using RandomString4Net;

namespace ArrowEye_Automation_Portal.Tests.Feature.CSP_Settings
{
    public class Plastic_Core_Assemblies : TestBase
    {
        string randomString = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 10);

        [Test]
        [Description("Plastic_Core_Assemblies_Create")]
        [Category("Smoke")]
        [TestCase("Automation_Create_Info_")]
        public void PlasticCoreAssemblies_CompleteFlow(string CreateFOCDynamicText)
        {
            CP_Pages.Login.LogIn("shaikhussainpasha", "Shaik@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToCSPSettings("FOCDynamicInfo");
            CP_Pages.PlasticCoreAssemblies.CreatePlasticCoreAssemblies(CreateFOCDynamicText + randomString);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

       
    }
}

