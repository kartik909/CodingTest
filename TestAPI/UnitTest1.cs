using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingTest.Controllers;
using System.Linq;
using ConsoleApp;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Threading.Tasks;

namespace TestAPI
{
    [TestClass]
    public class UnitTest1
    {
        // First the port of  this api need to start then only this test case will pass
        [TestMethod]
        public async Task Get_OKStatus()
        {
            var config = new HttpConfiguration();
            //configure web api
            config.MapHttpAttributeRoutes();

            using (var server = new HttpServer(config))
            {

                var client = new HttpClient(server);

                string url = "http://localhost:52685/Api/Values/Get/";

                var request = new HttpRequestMessage
                {
                    RequestUri = new Uri(url),
                    Method = HttpMethod.Get
                };

                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                using (var response = await client.SendAsync(request))
                {
                    Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
                }
            }
        }
    }

}

