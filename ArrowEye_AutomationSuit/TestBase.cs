using ArrowEye_Automation_Framework.Common;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RandomString4Net;

namespace ArrowEye_Automation_Framework
{
    [TestFixture]
    public class TestBase
    {
        public IWebDriver _driver;

        [SetUp]
        public void TestSetup()
        {
           Browser.Initialize();
        }

        [TearDown]
        public void TestTearDown()
        {
            Browser.Close();
        }

        /// <summary>
        /// Random string generator
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public string RandomAlphanumericstring(string result)
        {
            Random ranstr = new Random();
            String str = "abcdefghijklmnopqrstuvwxyz0123456789";
            int size = 70;

            String randomstring = "";

            for (int i = 0; i < size; i++)
            {
                int x = ranstr.Next(str.Length);
                randomstring = randomstring + str[x];
            }

            //return randomstring;
            //var result=Console.WriteLine("Automated_Data_"+ randomstring);
            result = "Automated_Data_" + randomstring;
            return result;
        }

    }
}
