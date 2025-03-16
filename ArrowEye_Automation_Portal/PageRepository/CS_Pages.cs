using ArrowEye_Automation_Framework.Common;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using ArrowEye_Automation_Portal.PageRepository;
using ArrowEye_Automation_Portal.PageRepository.EMV;

namespace ArrowEye_Automation_Portal
{
    public static class CS_Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            IWebDriver driver = Browser._Driver;
            PageFactory.InitElements(Browser.Driver, page);
            return page;
        }        

        public static CS_PrintSettingPage CSPrintSettingPage
        {
            get { return GetPage<CS_PrintSettingPage>(); }
        }

        public static CS_BCSS_ConfigurationPage BCSSConfigurationPage
        {
            get { return GetPage<CS_BCSS_ConfigurationPage>(); }
        }

        public static CS_Ship_TypesPage ShipTypesPage
        {
            get { return GetPage<CS_Ship_TypesPage>(); }
        }

        public static CS_IssuingBankPage IssuingBankPage
        {
            get { return GetPage<CS_IssuingBankPage>(); }
        }
        
        public static CS_Hot_StampsPage HotStampsPage
        {
            get { return GetPage<CS_Hot_StampsPage>(); }
        }
        public static CS_Print_TagsPage PrintTagsPage
        {
            get { return GetPage<CS_Print_TagsPage>(); }
        }

    }
}
