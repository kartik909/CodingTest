using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class GlobalVariable
    {
        public void GetAllEventData() //Get All Events Records  
        {
            using (var client = new WebClient()) //WebClient  
            {
                client.Headers.Add("Content-Type:application/json"); //Content-Type  
                client.Headers.Add("Accept:application/json");
                string result = client.DownloadString("http://localhost:52685/Api/Values"); //URI  
                Console.WriteLine(result.Replace("\"", String.Empty));
            }
        }
    }
}
