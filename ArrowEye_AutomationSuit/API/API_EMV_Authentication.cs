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

namespace ArrowEye_Automation_Framework.API
{
    public class API_EMV_Authentication
    {
        //string BaseURL = "https://62fush641m.execute-api.us-west-2.amazonaws.com";

        [Test]
        [Description("EMV Authentication GetMethod")]
        [Category("Smoke")]
        [TestCase("Automation_EMV_Authentication_GetRequestMethod")]
        public void EMV_Authentication_GetRequestMethod(string APItoken)
        {

            var response = APICommonMethods.ResponseFromGETrequest(AppNameHelper.ApiBaseUrl, "/emvauthentications?pclId=108");
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
            var response = APICommonMethods.ResponseFromPostRequest(AppNameHelper.ApiBaseUrl, "/emvauthentications", Jsonbody);
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
            var response = APICommonMethods.ResponseFromPutRequest(AppNameHelper.ApiBaseUrl, "/emvauthentications", Jsonbody);
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
            var response = APICommonMethods.ResponseFromDeleteRequest(AppNameHelper.ApiBaseUrl, "/emvauthentications", Jsonbody);
            Console.WriteLine(response.Content);
            Assert.That((int)response.StatusCode, Is.EqualTo(200));
        }

        //https://62fush641m.execute-api.us-west-2.amazonaws.com/emvauthentications
        //https://62fush641m.execute-api.us-west-2.amazonaws.com/cardprofiles
        [Test]
        [Description("EMV Card Profile Create")]
        [Category("Smoke")]
        [TestCase("Automation_EMV_CardProfile_Create")]
        public void EMV_CardProfile_Create(string APItoken)
        {
            //string randomString = RandomString.GetString(Types.ALPHANUMERIC_MIXEDCASE, 15);
            string Jsonbody = "{\"name\": \"Profile12\",\"description\": \"Desc-Profile12\",\"issuerId\": 28,\"expirationDate\": \"2024-07-25\"}";
            var response = APICommonMethods.ResponseFromPostRequest(AppNameHelper.ApiBaseUrl, "/cardprofiles", Jsonbody);
            //Console.WriteLine(response.Content);
            Assert.That((int)response.StatusCode, Is.EqualTo(201));
        }

        [Test]
        [Description("EMV Card Profile Update")]
        [Category("Smoke")]
        [TestCase("Automation_EMV_CardProfile_Update")]
        public void EMV_CardProfile_Update(string APItoken)
        {
            string Jsonbody = "{\"name\":\"Profile85\",\"description\":\"Desc-Profile85\",\"issuerId\":28,\"expirationDate\":\"2024-07-25\",\"cardProfileId\":85}";
            var response = APICommonMethods.ResponseFromPutRequest(AppNameHelper.ApiBaseUrl, "/cardprofiles", Jsonbody);
            Console.WriteLine(response.Content);
            Assert.That((int)response.StatusCode, Is.EqualTo(200));
        }


        [Test]
        [Description("EMV Card Profile Get")]
        [Category("Smoke")]
        [TestCase("Automation_EMV_Card_Profile_Get")]
        public void EMV_Card_Profile_Get(string APItoken)
        {

            var response = APICommonMethods.ResponseFromGETrequest(AppNameHelper.ApiBaseUrl, "/cardprofiles");
            //Console.WriteLine(response.Content);
            Assert.That((int)response.StatusCode, Is.EqualTo(200));

        }

        [Test]
        [Description("EMV Configurations Create")]
        [Category("Smoke")]
        [TestCase("Automation_EMV_Configurations_Create")]
        public void EMV_Configurations_Create(string APItoken)
        {
            //string randomString = RandomString.GetString(Types.ALPHANUMERIC_MIXEDCASE, 15);
            string Jsonbody = "{\"name\": \"Config12\",\"issuerId\": 28,\"cardProfileId\": 85,\"personalizationScriptId\": 60,\"moduleId\": 8,\"authenticationTypeId\": 1021,\"inTest\": true,\"pclId\": 108,\"isCreate\": true,\"id\": 2}";
            var response = APICommonMethods.ResponseFromPostRequest(AppNameHelper.ApiBaseUrl, "/configurations", Jsonbody);
            //Console.WriteLine(response.Content);
            Assert.That((int)response.StatusCode, Is.EqualTo(201));
        }

        [Test]
        [Description("EMV Configurations Update")]
        [Category("Smoke")]
        [TestCase("Automation_EMV_Configurations_Update")]
        public void EMV_Configurations_Update(string APItoken)
        {
            //string randomString = RandomString.GetString(Types.ALPHANUMERIC_MIXEDCASE, 15);
            string Jsonbody = "{\"name\": \"Config2\",\"issuerId\": 28,\"cardProfileId\": 85,\"personalizationScriptId\": 60,\"moduleId\": 8,\"authenticationTypeId\": 1021,\"inTest\": true,\"pclId\": 108,\"isCreate\": true,\"id\": 2}";
            var response = APICommonMethods.ResponseFromPutRequest(AppNameHelper.ApiBaseUrl, "/configurations", Jsonbody);
            //Console.WriteLine(response.Content);
            Assert.That((int)response.StatusCode, Is.EqualTo(200));
        }

        [Test]
        [Description("EMV Configurations Get by AutheTypeId")]
        [Category("Smoke")]
        [TestCase("Automation_EMV_Configurations_Get_By_AutheTypeId")]
        public void EMV_Configurations_Get_By_AutheTypeId(string APItoken)
        {

            var response = APICommonMethods.ResponseFromGETrequest(AppNameHelper.ApiBaseUrl, "/configurations?AuthenticationTypeId=1021");
            //Console.WriteLine(response.Content);
            Assert.That((int)response.StatusCode, Is.EqualTo(200));

        }

        [Test]
        [Description("EMV Configurations Get by PclId")]
        [Category("Smoke")]
        [TestCase("Automation_EMV_Configurations_Get_By_PclId")]
        public void EMV_Configurations_Get_By_PclId(string APItoken)
        {

            var response = APICommonMethods.ResponseFromGETrequest(AppNameHelper.ApiBaseUrl, "/configurations?PclId=108");
            //Console.WriteLine(response.Content);
            Assert.That((int)response.StatusCode, Is.EqualTo(200));

        }

        [Test]
        [Description("EMV Configurations Get by Id")]
        [Category("Smoke")]
        [TestCase("Automation_EMV_Configurations_Get_By_Id")]
        public void EMV_Configurations_Get_By_Id(string APItoken)
        {

            var response = APICommonMethods.ResponseFromGETrequest(AppNameHelper.ApiBaseUrl, "/configurations/24/programs");
            //Console.WriteLine(response.Content);
            Assert.That((int)response.StatusCode, Is.EqualTo(200));

        }
        [Test]
        [Description("EMV Issuer Create")]
        [Category("Smoke")]
        [TestCase("Automation_EMV_Issuer_Create")]
        public void EMV_Issuer_Create(string APItoken)
        {
            string randomString = RandomString.GetString(Types.ALPHANUMERIC_MIXEDCASE, 15);
            string Jsonbody = "{\"pclId\": 108,\"name\":\"" + randomString + "\" ,\"cpv_PVT\": \"pdf\",\"approvalPathId\": 2,\"description\": \"Issuer12 Desc\"}";
            var response = APICommonMethods.ResponseFromPostRequest(AppNameHelper.ApiBaseUrl, "/issuers", Jsonbody);
            //Console.WriteLine(response.Content);
            Assert.That((int)response.StatusCode, Is.EqualTo(201));
        }

        [Test]
        [Description("EMV Issuer Update")]
        [Category("Smoke")]
        [TestCase("Automation_Issuer_Update")]
        public void EMV_Issuer_Update(string APItoken)
        {
            string Jsonbody = "{\"pclId\": 108,\"name\": \"Issuer116\",\"cpv_PVT\": \"pdf\",\"approvalPathId\": 2,\"description\":\"Issuer116 Desc\",\"id\": 116}";
            var response = APICommonMethods.ResponseFromPutRequest(AppNameHelper.ApiBaseUrl, "/issuers", Jsonbody);
            Console.WriteLine(response.Content);
            Assert.That((int)response.StatusCode, Is.EqualTo(200));
        }


        [Test]
        [Description("EMV Issuer Get")]
        [Category("Smoke")]
        [TestCase("Automation_EMV_Issuer_Get")]
        public void EMV_Issuer_Get(string APItoken)
        {

            var response = APICommonMethods.ResponseFromGETrequest(AppNameHelper.ApiBaseUrl, "/issuers?PclId=108");
            //Console.WriteLine(response.Content);
            Assert.That((int)response.StatusCode, Is.EqualTo(200));

        }

        [Test]
        [Description("EMV Module Create")]
        [Category("Smoke")]
        [TestCase("Automation_EMV_Module_Create")]
        public void EMV_Module_Create(string APItoken)
        {
            string randomString = RandomString.GetString(Types.ALPHANUMERIC_MIXEDCASE, 15);
            string Jsonbody = "{\"name\":\""+ randomString +"\",\"description\": \"Modules12 Desc\",\"travelerLabel\": \"Test Mod84\",\"cmiProgram\": \"Mod84\",\"groupId\": 12}";
            var response = APICommonMethods.ResponseFromPostRequest(AppNameHelper.ApiBaseUrl, "/modules", Jsonbody);
            Console.WriteLine(response.Content);
            Assert.That((int)response.StatusCode, Is.EqualTo(201));
        }


        [Test]
        [Description("EMV Module Update")]
        [Category("Smoke")]
        [TestCase("Automation_Module_Update")]
        public void EMV_Module_Update(string APItoken)
        {
            string Jsonbody = "{\"name\": \"Modules84\",\"description\": \"Modules84 Desc\",\"travelerLabel\": \"Test Mod84\", \"cmiProgram\": \"Mod84\",\"groupId\": 12,\"id\": 84}";
            var response = APICommonMethods.ResponseFromPutRequest(AppNameHelper.ApiBaseUrl, "/modules", Jsonbody);
            //Console.WriteLine(response.Content);
            Assert.That((int)response.StatusCode, Is.EqualTo(200));
        }


        [Test]
        [Description("EMV Module Get")]
        [Category("Smoke")]
        [TestCase("Automation_EMV_Module_Get")]
        public void EMV_Module_Get(string APItoken)
        {

            var response = APICommonMethods.ResponseFromGETrequest(AppNameHelper.ApiBaseUrl, "/modules");
            //Console.WriteLine(response.Content);
            Assert.That((int)response.StatusCode, Is.EqualTo(200));

        }

        [Test]
        [Description("EMV Script Create")]
        [Category("Smoke")]
        [TestCase("Automation_EMV_Script_Create")]
        public void EMV_Script_Create(string APItoken)
        {
            string randomString = RandomString.GetString(Types.ALPHANUMERIC_MIXEDCASE, 15);
            string Jsonbody = "{\"name\": \""+ randomString+"\",\"description\": \"Script12 Desc\",\"profileName\": \"Scr12\"}";
            var response = APICommonMethods.ResponseFromPostRequest(AppNameHelper.ApiBaseUrl, "/scripts", Jsonbody);
            Console.WriteLine(response.Content);
            Assert.That((int)response.StatusCode, Is.EqualTo(201));
        }


        [Test]
        [Description("EMV Script Update")]
        [Category("Smoke")]
        [TestCase("Automation_Script_Update")]
        public void EMV_Script_Update(string APItoken)
        {
            string Jsonbody = "{\"name\": \"Script89\",\"description\": \"Script12 Desc\",\"profileName\": \"Scr12\",\"id\":89}";
            var response = APICommonMethods.ResponseFromPutRequest(AppNameHelper.ApiBaseUrl, "/scripts", Jsonbody);
            Console.WriteLine(response.Content);
            Assert.That((int)response.StatusCode, Is.EqualTo(200));
        }


        [Test]
        [Description("EMV Script Get")]
        [Category("Smoke")]
        [TestCase("Automation_EMV_Script_Get")]
        public void EMV_Script_Get(string APItoken)
        {

            var response = APICommonMethods.ResponseFromGETrequest(AppNameHelper.ApiBaseUrl, "/scripts");
            //Console.WriteLine(response.Content);
            Assert.That((int)response.StatusCode, Is.EqualTo(200));

        }


    }


}