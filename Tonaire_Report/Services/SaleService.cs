using Microsoft.Data.SqlClient;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tonaire_Report.Dtos;
using Tonaire_Report.Repo;

namespace Tonaire_Report.Services
{
    public class SaleService
    {
        private readonly SaleRepo _saleRepo;
        public SaleService()
        {
            _saleRepo = new SaleRepo();
        }
        public async Task<List<SaleDto>> GetSaleDataFilterByDatesAndNameAsync(DateTime startDate,DateTime endDate, string? productName = null)
        {
            try { 
             return await _saleRepo.GetSaleBetweenDateAndByNameAsync(startDate,endDate,productName);
            }
            catch (SqlException ex)
            {
                Log.Error(ex, "Database error while retrieving sales data for {StartDate}, {EndDate}, {ProductName}", startDate, endDate, productName);
                throw;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Unexpected error while retrieving sales data for {StartDate}, {EndDate}, {ProductName}", startDate, endDate, productName);
                throw;
            }

        }
    }
}
