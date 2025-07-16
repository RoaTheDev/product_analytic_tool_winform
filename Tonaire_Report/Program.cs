using Tonaire_Report.Configs;

namespace Tonaire_Report
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var config = ConfigLoader.LoadConfig();
            LoggerConfig.SetupLogging(config);

            AppDb.Init(config);
            if (!AppDb.TryConnectDb(config))
            {
                MessageBox.Show("Failed to connect to the database. Check logs for details.", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new SaleReportForm());

        }
    }
}