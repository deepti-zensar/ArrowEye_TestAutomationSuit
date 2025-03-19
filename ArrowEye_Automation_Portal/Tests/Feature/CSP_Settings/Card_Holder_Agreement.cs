using ArrowEye_Automation_Framework.Common;
using ArrowEye_Automation_Framework;
using NUnit.Framework;
using RandomString4Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowEye_Automation_Portal.Tests.Feature.CSP_Settings
{
    
    public class Card_Holder_Agreement : TestBase
    {
        string randomString = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 10);


        [Test]
        [Description("Card_Holder_Agreement_Create")]
        [Category("Smoke")]
        [TestCase("Automation_CardHolderAgreement_Create_Info_")]
        public void Create_New_CardHolderAggrement_Info(string CreateCardHolderAgreement)
        {
            CP_Pages.Login.LogIn("portaltester", "Portal@1234");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToCSPSettingsSubMenu("Card Holder Agreement");
            CP_Pages.CardHolderAgreement.AddCardHolderAgreementInfo(CreateCardHolderAgreement + randomString);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("Card_Holder_Agreement_Update")]
        [Category("Smoke")]
        [TestCase("Automation_CardHolderAgreement_Edit_Info_")]
        public void Edit_CardHolderAggrement_Info(string UpdateCardHolderAgreement)
        {
            CP_Pages.Login.LogIn("portaltester", "Portal@1234");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToCSPSettingsSubMenu("Card Holder Agreement");
            CP_Pages.CardHolderAgreement.EditCardHolderAgreementInfo(UpdateCardHolderAgreement + randomString);
            DriverUtilities.TakeScreenshot(@"C:\");
        }


        [Test]
        [Description("Card_Holder_Agreement_Delete")]
        [Category("Smoke")]
        [TestCase("Automation_Delete_CardHolderAgreement_")]
        public void Delete_CardHolderAggrement_Info(string DeleteCardHolderAgreement)
        {
            CP_Pages.Login.LogIn("portaltester", "Portal@1234");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToCSPSettingsSubMenu("Card Holder Agreement");
            //CP_Pages.CardHolderAgreement.DeleteCardHolderAgreementInfo(DeleteCardHolderAgreement + randomString);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("Card_Holder_Agreement_View/Search")]
        [Category("Smoke")]
        [TestCase("Automation_Search_CardHolderAgreemnet_")]
        public void View_Search_CardHolderAggrement_Info(string SearchCardHolderAgreement)
        {

            CP_Pages.Login.LogIn("portaltester", "Portal@1234");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToCSPSettingsSubMenu("Card Holder Agreement");
            //CP_Pages.CardHolderAgreement.View_SearchCardHolderAgreementInfo(SearchCardHolderAgreement + randomString);
            DriverUtilities.TakeScreenshot(@"C:\");
        }

        [Test]
        [Description("Card_Holder_Agreement_NegativeScenarios")]
        [Category("Smoke")]
        [TestCase("Automation_Negative_Validations")]
        public void Negative_Validations_CardHolderAggrement_Info(string NegativeScenariosText)
        {
            string randomStrings = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 90);
            CP_Pages.Login.LogIn("portaltester", "Portal@1234");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToCSPSettingsSubMenu("Card Holder Agreement");
            //CP_Pages.CardHolderAgreement.ValidationsCardHolderAgreementInfo(NegativeScenariosText + randomStrings);
            DriverUtilities.TakeScreenshot(@"C:\");
        }
    }
}
