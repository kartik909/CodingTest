using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{

    class Program
    {
        static void Main(string[] args)
        {
            Displayer objDisplay = new Displayer();
            objDisplay.Display();
        }

        // To get details about where to write the information to from Configuration Files(Just for convenience)

        //public static void GetConfigurationValue()
        //{
        //    var title = ConfigurationManager.AppSettings["title"];
        //    var language = ConfigurationManager.AppSettings["language"];

        //    Console.WriteLine(string.Format(title + language));
        //}
    }
}
