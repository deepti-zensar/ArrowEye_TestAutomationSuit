using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using OpenQA.Selenium.Interactions;
using NLog;
using System.IO;
using AventStack.ExtentReports;

namespace ArrowEye_Automation_Framework.Common
{
    public class ExtentHTMLReports :TestBase
    {
        public static ExtentReports reports=null;
        static public IWebDriver driver;
        public static void GenerateExtentReports(string input)
        {
            reports = new ExtentReports();
            //searchlocator.Clear();
            //searchlocator.SendKeys(input);
        }
    }
}
