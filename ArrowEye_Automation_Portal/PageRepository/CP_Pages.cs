using ArrowEye_Automation_Framework.Common;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using ArrowEye_Automation_Portal.PageRepository;

namespace ArrowEye_Automation_Portal
{
    public static class CP_Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            IWebDriver driver = Browser._Driver;
            PageFactory.InitElements(Browser.Driver, page);

            return page;
        }

        public static CP_LoginPage Login
        {
            get { return GetPage<CP_LoginPage>(); }
        }

        public static CP_HomePage Home
        {
            get { return GetPage<CP_HomePage>(); }
        }

        public static CP_EMV_IssuersPage EMVIssuersPage
        {
            get { return GetPage<CP_EMV_IssuersPage>(); }
        }

        public static CP_CSPSettings_BOCDynamicInfoPage BOCDynamicInfoPage
        {
            get { return GetPage<CP_CSPSettings_BOCDynamicInfoPage>(); }
        }


    }
}
