using ArrowEye_Automation_Framework.Common;
using ArrowEye_Automation_Framework;
using NUnit.Framework;
using RandomString4Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowEye_Automation_Portal.Tests.Feature.Client_Settings
{
   
    public class BankIdNumbers : TestBase
    {
        string randomString = RandomString.GetString(Types.NUMBERS, 5);


        [Test]
        [Description("ClinetSettings_BankIdNumber_Create")]
        [Category("Smoke")]
        [TestCase("18")]
        public void Create_New_BankIdNumbers(string CreateBankIdNumbersText)
        {
            CP_Pages.Login.LogIn("shaikhussainpasha", "Shaik@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToClientSettingsSubMenu("Bank ID Numbers");
            CP_Pages.BankIdNumbersPage.CreateNewBankIdNumbers(CreateBankIdNumbersText + randomString);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("ClinetSettings_BankIdNumber_Update")]
        [Category("Smoke")]
        [TestCase("12")]
        public void Edit_BankIdNumbers(string UpdateBankIdNumbersText)
        {
            CP_Pages.Login.LogIn("shaikhussainpasha", "Shaik@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToClientSettingsSubMenu("Bank ID Numbers");
            CP_Pages.BankIdNumbersPage.EditNewBankIdNumbers(UpdateBankIdNumbersText + randomString);
            DriverUtilities.TakeScreenshot(@"C:\");
        }


       

        [Test]
        [Description("ClinetSettings_BankIdNumber_Search_Export")]
        [Category("Smoke")]
        [TestCase("11")]
        public void View_Search_Export_BankIdNumbers(string Search_Export_BankIdNumbersText)
        {

            CP_Pages.Login.LogIn("shaikhussainpasha", "Shaik@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToClientSettingsSubMenu("Bank ID Numbers");
            CP_Pages.BankIdNumbersPage.View_export_NewBankIdNumbers(Search_Export_BankIdNumbersText + randomString);
            DriverUtilities.TakeScreenshot(@"C:\");
        }


        [Test]
        [Description("ClinetSettings_BankIdNumber_Validations")]
        [Category("Smoke")]
        [TestCase("91")]
        public void Negative_Validations_BankIdNumbers(string NegativeScenariosText)
        {
            string randomStrings = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 70);
            CP_Pages.Login.LogIn("shaikhussainpasha", "Shaik@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToClientSettingsSubMenu("Bank ID Numbers");
            CP_Pages.BankIdNumbersPage.ValidationsNewBankIdNumbers(NegativeScenariosText + randomStrings);
            DriverUtilities.TakeScreenshot(@"C:\");
        }
    }
}
