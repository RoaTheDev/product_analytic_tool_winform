using Microsoft.Extensions.Configuration;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tonaire_Report.Configs
{
    internal class LoggerConfig
    {
        public static void SetupLogging(IConfiguration config)
        {
            var rootDir = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\.."));
            var logFolder = Path.Combine(rootDir, "logs");

            if (!Directory.Exists(logFolder))
            {
                Directory.CreateDirectory(logFolder);
            }

            var logFilePath = Path.Combine(logFolder, "errors.txt");

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(config)
                .WriteTo.File(
                logFilePath,
                outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level}] {Message}{NewLine}{Exception}",
                rollingInterval: RollingInterval.Day,
                retainedFileCountLimit: 7)
                .CreateLogger();
        }
    }
}
