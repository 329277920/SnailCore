using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace SnailCore.Tester.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            var url = "http://192.168.56.1:9000";
            if (args?.Length >= 1)
            {
                url = args[0];
            }

            return WebHost.CreateDefaultBuilder()
              .UseStartup<Startup>()
              .UseUrls(url)
              .Build();
        }                      
    }
}
