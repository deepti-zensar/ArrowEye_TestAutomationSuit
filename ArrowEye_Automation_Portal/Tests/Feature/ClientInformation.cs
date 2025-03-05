using ArrowEye_Automation_Framework;
using ArrowEye_Automation_Framework.Common;
using NUnit.Framework;
using RandomString4Net;

namespace ArrowEye_Automation_Portal.Tests.Feature
{
    [TestFixture]
    public class ClientInformation : TestBase
    {
        string userName = "portaltestuser";
        string password = "Admin123@";
       

        [Test]
        [Description("Client_Information_Homepage")]
        [Category("Smoke")]        
        public void ClientInformation_Homepage()
        {
            CP_Pages.Login.LogIn(userName,password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Client Information");
            CP_Pages.ClientInformationPage.ValidateClientInformation_Homepage();
            DriverUtilities.TakeScreenshot(@"C:\");
        }
       
    }
}
