using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrowEye_Automation_Framework;
using ArrowEye_Automation_Framework.Common;
using NUnit.Framework;
using RandomString4Net;

namespace ArrowEye_Automation_Portal.Tests.Feature
{
    [TestFixture]
    public class Login : TestBase
    {
        string userName = "portaltestuser";
        string password = "Admin123@";
        string invalidUserName = "portal";
        string invalidPassword = "Admin123";        

        [Test]
        [Description("Successful Login")]
        [Category("Smoke")]        
        public void Successful_Login()
        {
            CP_Pages.Login.validateLoginPage();
            CP_Pages.Login.LogIn(userName, password);
            CP_Pages.Home.ValidateHomePageTitle();            
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("Unsuccessful Login")]
        [Category("Smoke")]
        public void Unsuccessful_Login()
        {
            CP_Pages.Login.validateLoginPage();
            CP_Pages.Login.LogIn(invalidUserName, invalidPassword);
            CP_Pages.Login.ValidateUnsuccessfulLogin();
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("View Password Login")]
        [Category("Smoke")]
        public void ViewPassword_Login()
        {
            CP_Pages.Login.validateLoginPage();
            CP_Pages.Login.viewPasswordLogIn(userName, password);            
            DriverUtilities.TakeScreenshot(@"C:\");
        }
    }
}
