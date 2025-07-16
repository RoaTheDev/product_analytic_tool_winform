using DevExpress.Data.Async;
using Microsoft.Data.SqlClient;
using Serilog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tonaire_Report.Dtos;

namespace Tonaire_Report.Repo
{
    public class SaleRepo
    {
        public async Task<List<SaleDto>> GetSaleBetweenDateAndByNameAsync(DateTime startDate,DateTime endDate, string? productName = null)
        {
            List<SaleDto> sales =  new List<SaleDto>();

                using (SqlConnection con = AppDb.GetConnection())
                {
                    await con.OpenAsync();

                    using (SqlCommand cmd = new SqlCommand("GetProductBetweenDatesAndFilterByName", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@StartDate", SqlDbType.Date) { Value = startDate });
                        cmd.Parameters.Add(new SqlParameter("@EndDate", SqlDbType.Date) { Value = endDate });
                        cmd.Parameters.Add(new SqlParameter("@ProductName", SqlDbType.NVarChar,100) { Value = productName as object ?? DBNull.Value });

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {

                            while (await reader.ReadAsync())
                            {
                                SaleDto sale = new SaleDto
                                {
                                    ProductName = reader["PRODUCTNAME"]?.ToString() ?? string.Empty,
                                    ProductCode = reader["PRODUCTCODE"]?.ToString() ?? string.Empty,
                                    Quantity = Convert.ToInt32(reader["QUANTITY"]),
                                    UnitPrice = Convert.ToDecimal(reader["UNITPRICE"]),
                                    Total = Convert.ToDecimal(reader["TOTAL"]),
                                    SaleDate = Convert.ToDateTime(reader["SALEDATE"])
                                };
                                sales.Add(sale);
                            }
                        }

                    }
                }
                
            return sales;
           
        }
    }
}
