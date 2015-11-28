using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace Wondercard.Client.Webapi.Launcher
{
    public class Program
    {
        static void Main(string[] args)
        {
            var baseUri = ConfigurationManager.AppSettings["BaseUri"];

            Console.WriteLine("Starting web Server...");
            var startup = new Startup();
            WebApp.Start(baseUri, appBuilder => startup.Configuration(appBuilder));
            Console.WriteLine("Server running at {0} - press Enter to quit. ", baseUri);
            Console.ReadLine();
        }
    }
}
