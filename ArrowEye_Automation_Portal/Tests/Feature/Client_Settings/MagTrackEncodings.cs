using ArrowEye_Automation_Framework;
using ArrowEye_Automation_Framework.Common;
using NUnit.Framework;
using RandomString4Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ArrowEye_Automation_Portal.Tests.Feature.Client_Settings
{
    [TestFixture]
    public class MagTrackEncodings : TestBase
    {
        string userName = "portaltestuser";
        string password = "Admin123@";
        public string getRandomString()
        {
            return RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 5); ;
        }
        
        [Test]
        [Description("Mag_Track_Encodings_Validate")]
        [Category("Smoke")]        
        public void Validate_MagTrackEncodings()
        {
            CP_Pages.Login.LogIn(userName,password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Client Settings");
            CP_Pages.Home.NavigateToSubmenu("Mag Track Encodings");
            CP_Pages.MagTrackEncodingsPage.ValidateMagTrackEncodings();
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("Mag_Track_Encodings_Delete_BIN")]
        [Category("Smoke")]
        [TestCase("test123")]
        public void Delete_BIN_MagTrackEncodings(string name)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Client Settings");
            CP_Pages.Home.NavigateToSubmenu("Mag Track Encodings");
            CP_Pages.MagTrackEncodingsPage.DeleteBINMagTrackEncodings(name);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("Mag_Track_Encodings_Homepage_View")]
        [Category("Smoke")]
        [TestCase("ID", "Name", "Description", "Track1", "Track2", "Track3", "Actions")]
        public void HomepageView_MagTrackEncodings(params string[] listOfOptions)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Client Settings");
            CP_Pages.Home.NavigateToSubmenu("Mag Track Encodings");
            CP_Pages.MagTrackEncodingsPage.MagTrackEncodingsHomepageView(listOfOptions);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("Mag_Track_Encodings_Export")]
        [Category("Smoke")]
        [TestCase("React App.csv")]
        public void Export_MagTrackEncodings(string fileName)
        {
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToMenu("Client Settings");
            CP_Pages.Home.NavigateToSubmenu("Mag Track Encodings");
            CP_Pages.MagTrackEncodingsPage.MagTrackEncodingsExport(fileName);
            DriverUtilities.TakeScreenshot(@"C:\");
        }
    }
}
