using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrowEye_Automation_Framework.Common;
using ArrowEye_Automation_Portal.Tests.Feature.Client_Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace ArrowEye_Automation_Portal.PageRepository.Products
{
   
    public static class Product_Pages
    {
        
       

        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            IWebDriver driver = Browser._Driver;
         

            PageFactory.InitElements(Browser.Driver, page);


            return page;
        }

        
        public static Product_MultiSheetCarrierPage MultiSheetCarrierPage
        {
            get { return GetPage<Product_MultiSheetCarrierPage>(); }
        }



    }
}
