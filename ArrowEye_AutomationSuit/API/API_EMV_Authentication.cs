using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrowEye_Automation_Framework.Common;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RandomString4Net;
using RestSharp.Authenticators;
using RestSharp;
using Newtonsoft.Json;
using RandomString4Net;

namespace ArrowEye_Automation_Framework.API
{
    public class API_EMV_Authentication
    {
        string BaseURL = "https://62fush641m.execute-api.us-west-2.amazonaws.com";

        [Test]
        [Description("EMV Authentication GetMethod")]
        [Category("Smoke")]
        [TestCase("Automation_EMV_Authentication_GetRequestMethod")]
        public void EMV_Authentication_GetRequestMethod(string APItoken)
        {

            var response = APICommonMethods.ResponseFromGETrequest(BaseURL, "/emvauthentications?pclId=108");
            //Console.WriteLine((int)response.StatusCode);
            Assert.That((int)response.StatusCode, Is.EqualTo(200));

        }

        //https://62fush641m.execute-api.us-west-2.amazonaws.com/emvauthentications
        [Test]
        [Description("EMV Authentication PostMethod")]
        [Category("Smoke")]
        [TestCase("Automation_EMV_Authentication_PostRequestMethod")]
        public void EMV_Authentication_PostRequestMethod(string APItoken)
        {
            string randomString = RandomString.GetString(Types.ALPHANUMERIC_MIXEDCASE, 15);
            string Jsonbody = "{\"authenticationType\":\"" + randomString + "\"}";
            var response = APICommonMethods.ResponseFromPostRequest(BaseURL, "/emvauthentications", Jsonbody);
            //Console.WriteLine(response.Content);
            Assert.That((int)response.StatusCode, Is.EqualTo(201));
        }

        [Test]
        [Description("EMV Authentication PutMethod")]
        [Category("Smoke")]
        [TestCase("Automation_EMV_Authentication_PutRequestMethod")]
        public void EMV_Authentication_PutRequestMethod(string APItoken)
        {
            string Jsonbody = "{\"authenticationType\":\"EMV1147\",\"id\":1147}";
            var response = APICommonMethods.ResponseFromPutRequest(BaseURL, "/emvauthentications", Jsonbody);
            //Console.WriteLine(response.Content);
            Assert.That((int)response.StatusCode, Is.EqualTo(200));
        }

        [Test]
        [Description("EMV Authentication DeleteMethod")]
        [Category("Smoke")]
        [TestCase("Automation_EMV_Authentication_DeleteRequestMethod")]
        public void EMV_Authentication_DeleteMethod(string APItoken)
        {
            string Jsonbody = "{\"id\":51}";
            var response = APICommonMethods.ResponseFromDeleteRequest(BaseURL, "/emvauthentications", Jsonbody);
            Console.WriteLine(response.Content);
            Assert.That((int)response.StatusCode, Is.EqualTo(200));
        }  
    }
}