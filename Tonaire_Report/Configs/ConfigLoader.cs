using Microsoft.Extensions.Configuration;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tonaire_Report.Configs
{
    internal static class ConfigLoader
    {
        public static IConfiguration LoadConfig()
        {
            var config = new ConfigurationBuilder()
         .SetBasePath(AppContext.BaseDirectory)
         .AddJsonFile("appsettings.json", false, true)
         .Build();
            Console.WriteLine($"Config loaded: {config.GetConnectionString("DefaultConnection")}");
            return config;
        }
       

    }

}
