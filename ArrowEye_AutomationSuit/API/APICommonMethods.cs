using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
namespace ArrowEye_Automation_Framework.API
{
    public class APICommonMethods
    {
        public static string APItoken= "eyJraWQiOiJaTGJkVTczTk9YZEZCU29CZE13eWtyOTZaT2xSSWFHRWJlZGN4XC8yb2p0Zz0iLCJhbGciOiJSUzI1NiJ9.eyJzdWIiOiI4MTA3YWRhOS04YTRjLTQ1NTYtOTM3Yy1lMjI2ZGRiMDhkZjMiLCJlbWFpbF92ZXJpZmllZCI6dHJ1ZSwiaXNzIjoiaHR0cHM6XC9cL2NvZ25pdG8taWRwLnVzLXdlc3QtMi5hbWF6b25hd3MuY29tXC91cy13ZXN0LTJfM3p4Zk1GempvIiwiY29nbml0bzp1c2VybmFtZSI6InNiYWJ1IiwiYXVkIjoiMWZmNDFnaDVhaWp2OTA0amJubzMxNzU5MzEiLCJldmVudF9pZCI6ImYzOTJhNDlmLTUyOTQtNGM3Yy05Zjg3LWFjZjg4NzMzZTBkZSIsInRva2VuX3VzZSI6ImlkIiwiYXV0aF90aW1lIjoxNzM3NjEzOTA5LCJuYW1lIjoiIFN1ZGFyc2hhbiBCYWJ1IFNlZ2dhcmkiLCJleHAiOjE3Mzc3MDAzMDksImlhdCI6MTczNzYxMzkwOSwiZW1haWwiOiJzLnN1ZGFyc2hhbkB6ZW5zYXIuY29tIn0.JlH7gAYBk7JbHIrQcHFYRXf7g_3dhbo3unaM01K6XWQkDFWxOAfA7xTE6hDF43ojMsq1OTQ0LsOHxD5_NCjQWFlxrz5t4CLVbhztGjbLDj_T5zbcxlamb0VhHHaswWk4pgtcJtjniQyiiLGasvdB7bGmKkLoRaJmn7w48Pgyx7VxdxTN5775gk4xPuQueYaDE2xL4IjoBTRf82JvdYK9bhcx1kUHF996Q8dzwv1udBKkIeOhcl0tIefZ_oaO1hlChUOXeC0IE-IS8sBcjUFjgOun0Y2Z4zYsg_zZugp0vA-coYtO3sWIBor-jypeYuDnVXtAcTWwNjPMTaDG5MJ89A";
        
        //Get
        static public IRestResponse ResponseFromGETrequest(string baseURL,string resourceAndQuery)
        {
            var request = GETRequest(resourceAndQuery);            
            //Execute Request
            IRestResponse response = GetRestClient(baseURL).Execute(request);
            return response;
        }
        static public RestRequest GETRequest(string resourceAndQuery)
        {
            var request = new RestRequest(Method.GET);
            request.Resource = resourceAndQuery;
            //APItoken = APIConstants.APItoken;
            request.AddHeader("Authorization", "Bearer "+APItoken);
            request.AddHeader("content-type", "application/json");
            return request;
        }
        static public RestClient GetRestClient(string baseURL)
        {
            var client = new RestClient();
            client.BaseUrl = new Uri(baseURL);
            //client.Authenticator = new NtlmAuthenticator(userName, passWord);
            client.Authenticator = new NtlmAuthenticator();
            return client;
        }

        //Post 
        
        static public IRestResponse ResponseFromPostRequest(string baseURL, string resourceAndQuery, string json)
        {

            var request = PostRequest(resourceAndQuery, json);
            IRestResponse response = GetRestClient(baseURL).Execute(request);
            return response;

        }
        static public RestRequest PostRequest(string resourceAndQuery, string json)
        {

            var request = new RestRequest(Method.POST);
            request.Resource = resourceAndQuery;
            request.AddHeader("Authorization","Bearer "+APItoken);
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", json, ParameterType.RequestBody);
            return request;
        }
        static public IRestResponse ResponseFromPutRequest(string baseURL, string resourceAndQuery, string jsonString)
        {

            var request = PutRequest(resourceAndQuery, jsonString);
            //Execute Request
            IRestResponse response = GetRestClient(baseURL).Execute(request);
            return response;
        }
        static public RestRequest PutRequest(string resource, string jsonString)
        {

            var request = new RestRequest(Method.PUT);
            request.Resource = resource;
            request.AddHeader("content-type", "application/json");
            request.AddHeader("Authorization", "Bearer " + APItoken);
            request.AddParameter("application/json", jsonString, ParameterType.RequestBody);           
            return request;
        }

        static public IRestResponse ResponseFromDeleteRequest(string baseURL,string resource, string jsonString)
        {

            var request = DeleteRequest(resource,jsonString);
            //Execute Request
            IRestResponse response = GetRestClient(baseURL).Execute(request);
            return response;
        }

        static public RestRequest DeleteRequest(string resource,string jsonString)
        {
            var request = new RestRequest(Method.DELETE);
            request.Resource = resource;
            request.AddHeader("Authorization", "Bearer " + APItoken);
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", jsonString, ParameterType.RequestBody);
            return request;
        }
    }
}
