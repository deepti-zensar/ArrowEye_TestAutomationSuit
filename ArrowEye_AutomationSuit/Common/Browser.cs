using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Security.Policy;

namespace ArrowEye_Automation_Framework.Common
{
    public class Browser
    {
       

        public IWebDriver WebDriver { get; set; }
        public string environmentURL { get; set; }

        private static IWebDriver webDriver = new ChromeDriver();

        public Browser(IWebDriver webDriver)
        {
            environmentURL = AppNameHelper.appBaseURL;
            WebDriver = webDriver;
        }

        public static void Initialize()
        {
            //webDriver.Url = AppNameHelper.appBaseURL;
            webDriver.Url = "https://portal-dev.arroweye.com/";
            Thread.Sleep(5000);
            webDriver.Manage().Window.Maximize();

        }

        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static string CurrentURL
        {
            get { return webDriver.Url; }
        }

        public static ISearchContext Driver
        {
            get { return webDriver; }
        }

        public static IWebDriver _Driver
        {
            get { return webDriver; }
        }

        //public static void Goto(string url)
        //{
        //    webDriver.Url = AppNameHelper.appBaseURL;

        //}

        public static void Click(IWebElement element)
        {
            Thread.Sleep(3000);
            element.Click();
        }

        public static void GetText(IWebElement element, string text )
        {
            Thread.Sleep(3000);
            text = element.Text;
        }

        public static void Close()
        {
            webDriver.Close();
            webDriver.Quit();
        }
    }
}
