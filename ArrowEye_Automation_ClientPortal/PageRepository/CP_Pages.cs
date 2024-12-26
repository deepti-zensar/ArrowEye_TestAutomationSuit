using ArrowEye_Automation_Framework.Common;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using ArrowEye_Automation_ClientPortal.PageRepository;

namespace ArrowEye_Automation_ClientPortal
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

        public static CP_IssuersPage IssuersPage
        {
            get { return GetPage<CP_IssuersPage>(); }
        }


    }
}
