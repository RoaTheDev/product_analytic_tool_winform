using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tonaire_Report
{
    public static class AppDb
    {

        private static string? _connectionString;
        public static void Init(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("DefaultConnection") ?? "";
        }

        public static SqlConnection GetConnection()
        {
            if (string.IsNullOrWhiteSpace(_connectionString))
            {
                throw new InvalidOperationException("Database is not initialized. Call Initialize() first.");
            }
            return new SqlConnection(_connectionString);
        }
        public static bool TryConnectDb(IConfiguration config)
        {
            try
            {
                using var con = GetConnection();
                con.Open();
                return true;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Failed to connect to the database.");
                return false;
            }
        }
    }
}
